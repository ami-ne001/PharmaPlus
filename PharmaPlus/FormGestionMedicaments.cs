using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaPlus
{
    public partial class FormGestionMedicaments : Form
    {
        private Pharmacien pharmacien;
        private int? selectedMedicamentId = null;
        private List<Medicament> medicamentsList;

        public FormGestionMedicaments()
        {
            InitializeComponent();
        }

        private void FormGestionMedicaments_Load(object sender, EventArgs e)
        {
            pharmacien = new Pharmacien();
            if (Utilisateur.UtilisateurConnecte != null)
            {
                pharmacien.ID_Utilisateur = Utilisateur.UtilisateurConnecte.ID_Utilisateur;
            }
            ChargerMedicaments();
            ConfigurerDataGridView();
            ViderChamps();
        }

        private void ChargerMedicaments()
        {
            try
            {
                medicamentsList = Medicament.ListerMedicaments();
                dgvMedicaments.DataSource = null;
                dgvMedicaments.DataSource = medicamentsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des médicaments : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            FiltrerMedicaments();
        }

        private void FiltrerMedicaments()
        {
            try
            {
                string recherche = textBox2.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(recherche))
                {
                    ChargerMedicaments();
                    return;
                }

                if (medicamentsList == null || medicamentsList.Count == 0)
                {
                    MessageBox.Show("Aucun médicament à rechercher.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var medicamentsFiltres = medicamentsList.Where(m =>
                    m.Nom.ToLower().Contains(recherche) || m.Reference.ToLower().Contains(recherche) ||
                    m.Categorie.ToLower().Contains(recherche) || m.Fabricant.ToLower().Contains(recherche)
                ).ToList();

                if (medicamentsFiltres.Count == 0)
                {
                    MessageBox.Show($"Aucun médicament trouvé avec '{textBox2.Text}'.",
                        "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvMedicaments.DataSource = null;
                dgvMedicaments.DataSource = medicamentsFiltres;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMedicaments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicaments.SelectedRows.Count > 0)
            {
                Medicament medicamentSelectionne = dgvMedicaments.SelectedRows[0].DataBoundItem as Medicament;
                if (medicamentSelectionne != null)
                {
                    RemplirChamps(medicamentSelectionne);
                }
            }
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtReference.Text))
                return false;

            return true;
        }

        private Medicament RecupererMedicament()
        {
            return new Medicament
            {
                Nom = txtNom.Text.Trim(),
                Reference = txtReference.Text.Trim(),
                Categorie = txtCategorie.Text.Trim(),
                Fabricant = txtFabricant.Text.Trim(),
                QuantiteTotale = 0,
                SeuilAlerteStock = (int)nudSeuil.Value
            };
        }

        private void RemplirChamps(Medicament medicament)
        {
            selectedMedicamentId = medicament.ID_Medicament;
            txtNom.Text = medicament.Nom;
            txtReference.Text = medicament.Reference;
            txtCategorie.Text = medicament.Categorie;
            txtFabricant.Text = medicament.Fabricant;
            nudSeuil.Value = medicament.SeuilAlerteStock;
        }

        private void ViderChamps()
        {
            selectedMedicamentId = null;
            txtNom.Clear();
            txtReference.Clear();
            txtCategorie.Clear();
            txtFabricant.Clear();
            nudSeuil.Value = 5;
            textBox2.Clear();

            if (dgvMedicaments.SelectedRows.Count > 0)
            {
                dgvMedicaments.ClearSelection();
            }
        }

        private void ConfigurerDataGridView()
        {
            dgvMedicaments.AutoGenerateColumns = false;

            dgvMedicaments.Columns.Clear();

            dgvMedicaments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nom",
                HeaderText = "Nom",
                DataPropertyName = "Nom",
                Width = 170
            });

            dgvMedicaments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Reference",
                HeaderText = "Référence",
                DataPropertyName = "Reference",
                Width = 120
            });

            dgvMedicaments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Categorie",
                HeaderText = "Catégorie",
                DataPropertyName = "Categorie",
                Width = 170
            });

            dgvMedicaments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fabricant",
                HeaderText = "Fabricant",
                DataPropertyName = "Fabricant",
                Width = 120
            });

            dgvMedicaments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantite",
                HeaderText = "Quantité",
                DataPropertyName = "QuantiteTotale",
                Width = 110
            });

            dgvMedicaments.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Seuil",
                HeaderText = "Seuil",
                DataPropertyName = "SeuilAlerteStock",
                Width = 105
            });
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderChamps())
                {
                    MessageBox.Show("Veuillez remplir au moins le nom et la référence du médicament.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Medicament nouveauMedicament = RecupererMedicament();
                pharmacien.AjouterMedicament(nouveauMedicament);
                ChargerMedicaments();
                ViderChamps();
                MessageBox.Show("Médicament ajouté avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Microsoft.Data.SqlClient.SqlException sqlEx)
            {
                // Check for unique constraint violation (duplicate reference)
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show($"Un médicament avec la référence '{txtReference.Text}' existe déjà dans la base de données.\nVeuillez utiliser une référence unique.",
                        "Référence dupliquée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtReference.Focus();
                    txtReference.SelectAll();
                }
                else
                {
                    MessageBox.Show($"Erreur lors de l'ajout : {sqlEx.Message}",
                        "Erreur base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selectedMedicamentId.HasValue)
                {
                    MessageBox.Show("Veuillez sélectionner un médicament à modifier.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValiderChamps())
                {
                    MessageBox.Show("Veuillez remplir au moins le nom et la référence du médicament.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Medicament medicamentModifie = RecupererMedicament();
                medicamentModifie.ID_Medicament = selectedMedicamentId.Value;

                pharmacien.ModifierMedicament(medicamentModifie);
                ChargerMedicaments();
                ViderChamps();
                MessageBox.Show("Médicament modifié avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selectedMedicamentId.HasValue)
                {
                    MessageBox.Show("Veuillez sélectionner un médicament à supprimer.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer ce médicament ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                Medicament medicamentASupprimer = new Medicament
                {
                    ID_Medicament = selectedMedicamentId.Value
                };

                pharmacien.SupprimerMedicament(medicamentASupprimer);
                ChargerMedicaments();
                ViderChamps();
                MessageBox.Show("Médicament supprimé avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void btnReinitialiserRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                ChargerMedicaments();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la réinitialisation : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMenuPharmacien form = new FormMenuPharmacien();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }
    }
}
