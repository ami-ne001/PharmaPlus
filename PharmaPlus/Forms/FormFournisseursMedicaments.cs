using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class FormFournisseursMedicaments : Form
    {
        private List<Fournisseur> fournisseurs;
        private List<Medicament> medicaments;
        private Fournisseur fournisseurSelectionne;
        private Medicament medicamentSelectionne;
        private Form menuParent;

        public FormFournisseursMedicaments() : this(null)
        {
        }

        public FormFournisseursMedicaments(Form parent)
        {
            InitializeComponent();
            InitialiserFormulaire();
            menuParent = parent;
        }

        /// <summary>
        /// Initialiser le formulaire au chargement
        /// </summary>
        private void InitialiserFormulaire()
        {
            try
            {
                ChargerFournisseurs();
                ChargerMedicaments();
                ViderChampsFournisseur();
                ViderChampsMedicament();
                dataGridView1.Rows.Clear();

                // Configurer les événements
                cmbFournisseurs.SelectedIndexChanged += CmbFournisseurs_SelectedIndexChanged;
                comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
                btnAjouterMedAuFournisseur.Click += BtnAjouterMedAuFournisseur_Click;
                dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'initialisation du formulaire : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Charger la liste des fournisseurs dans le ComboBox
        /// </summary>
        private void ChargerFournisseurs()
        {
            try
            {
                fournisseurs = Fournisseur.ListerFournisseurs();
                cmbFournisseurs.DataSource = null;
                cmbFournisseurs.DataSource = fournisseurs;
                cmbFournisseurs.DisplayMember = "Nom";
                cmbFournisseurs.ValueMember = "ID_Fournisseur";
                cmbFournisseurs.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des fournisseurs : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Charger la liste des médicaments dans le ComboBox
        /// </summary>
        private void ChargerMedicaments()
        {
            try
            {
                medicaments = Medicament.ListerMedicaments();
                comboBox1.DataSource = null;
                comboBox1.DataSource = medicaments;
                comboBox1.DisplayMember = "Nom";
                comboBox1.ValueMember = "ID_Medicament";
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des médicaments : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Événement de changement de sélection du fournisseur
        /// </summary>
        private void CmbFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFournisseurs.SelectedIndex >= 0)
            {
                fournisseurSelectionne = (Fournisseur)cmbFournisseurs.SelectedItem;
                AfficherDetailsFournisseur(fournisseurSelectionne);
                ChargerMedicamentsDuFournisseur(fournisseurSelectionne.ID_Fournisseur);
            }
            else
            {
                ViderChampsFournisseur();
                dataGridView1.Rows.Clear();
            }
        }

        /// <summary>
        /// Événement de changement de sélection du médicament
        /// </summary>
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                medicamentSelectionne = (Medicament)comboBox1.SelectedItem;
                AfficherDetailsMedicament(medicamentSelectionne);
            }
            else
            {
                ViderChampsMedicament();
            }
        }

        /// <summary>
        /// Afficher les détails du fournisseur sélectionné
        /// </summary>
        private void AfficherDetailsFournisseur(Fournisseur fournisseur)
        {
            txtCodeFournisseur.Text = fournisseur.CodeFournisseur;
            txtNomFournisseur.Text = fournisseur.Nom;
            txtTelephoneFournisseur.Text = fournisseur.Telephone;
            txtEmailFournisseur.Text = fournisseur.Email;
            txtAdresseFournisseur.Text = fournisseur.Adresse;
        }

        /// <summary>
        /// Afficher les détails du médicament sélectionné
        /// </summary>
        private void AfficherDetailsMedicament(Medicament medicament)
        {
            txtReferenceMed.Text = medicament.Reference;
            txtNomMed.Text = medicament.Nom;
            txtFabricantMed.Text = medicament.Fabricant;
        }

        /// <summary>
        /// Vider les champs du fournisseur
        /// </summary>
        private void ViderChampsFournisseur()
        {
            txtCodeFournisseur.Clear();
            txtNomFournisseur.Clear();
            txtTelephoneFournisseur.Clear();
            txtEmailFournisseur.Clear();
            txtAdresseFournisseur.Clear();
            fournisseurSelectionne = null;
        }

        /// <summary>
        /// Vider les champs du médicament
        /// </summary>
        private void ViderChampsMedicament()
        {
            txtReferenceMed.Clear();
            txtNomMed.Clear();
            txtFabricantMed.Clear();
            medicamentSelectionne = null;
        }

        /// <summary>
        /// Charger les médicaments associés au fournisseur dans le DataGridView
        /// </summary>
        private void ChargerMedicamentsDuFournisseur(int idFournisseur)
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<Medicament> medicamentsFournisseur = FournisseurMedicament.ListerMedicamentsParFournisseur(idFournisseur);

                foreach (var med in medicamentsFournisseur)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells["Supprimer"].Value = "Supprimer";
                    row.Cells["Nom"].Value = med.Nom;
                    row.Cells["Reference"].Value = med.Reference;
                    row.Cells["Categorie"].Value = med.Categorie;
                    row.Cells["Fabricant"].Value = med.Fabricant;
                    row.Tag = med.ID_Medicament; // Stocker l'ID pour la suppression
                }

                if (medicamentsFournisseur.Count == 0)
                {
                    MessageBox.Show("Aucun médicament n'est associé à ce fournisseur.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des médicaments du fournisseur : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ajouter un médicament au fournisseur sélectionné
        /// </summary>
        private void BtnAjouterMedAuFournisseur_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (fournisseurSelectionne == null)
                {
                    MessageBox.Show("Veuillez sélectionner un fournisseur.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (medicamentSelectionne == null)
                {
                    MessageBox.Show("Veuillez sélectionner un médicament.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Vérifier si la relation existe déjà
                if (FournisseurMedicament.RelationExiste(fournisseurSelectionne.ID_Fournisseur, medicamentSelectionne.ID_Medicament))
                {
                    MessageBox.Show("Ce médicament est déjà associé à ce fournisseur.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Créer la relation
                FournisseurMedicament relation = new FournisseurMedicament
                {
                    ID_Fournisseur = fournisseurSelectionne.ID_Fournisseur,
                    ID_Medicament = medicamentSelectionne.ID_Medicament
                };

                relation.AjouterRelation();

                // Sauvegarder les noms avant de réinitialiser
                string nomFournisseur = fournisseurSelectionne.Nom;
                string nomMedicament = medicamentSelectionne.Nom;

                MessageBox.Show($"Le médicament '{nomMedicament}' a été ajouté au fournisseur '{nomFournisseur}' avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Rafraîchir la liste
                ChargerMedicamentsDuFournisseur(fournisseurSelectionne.ID_Fournisseur);

                // Réinitialiser la sélection du médicament
                comboBox1.SelectedIndex = -1;
                ViderChampsMedicament();

                // Enregistrer l'action dans l'historique
                if (Utilisateur.UtilisateurConnecte != null)
                {
                    Utilisateur.UtilisateurConnecte.EnregistrerHistorique(
                        $"Ajout relation: Fournisseur '{nomFournisseur}' - Médicament '{nomMedicament}'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la relation : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gérer le clic sur les cellules du DataGridView (bouton Supprimer)
        /// </summary>
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Vérifier si c'est la colonne "Supprimer"
                if (e.ColumnIndex == dataGridView1.Columns["Supprimer"].Index && e.RowIndex >= 0)
                {
                    if (fournisseurSelectionne == null)
                    {
                        MessageBox.Show("Aucun fournisseur sélectionné.",
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int idMedicament = (int)row.Tag;
                    string nomMedicament = row.Cells["Nom"].Value.ToString();

                    // Confirmation
                    DialogResult result = MessageBox.Show(
                        $"Voulez-vous vraiment supprimer l'association entre le fournisseur '{fournisseurSelectionne.Nom}' et le médicament '{nomMedicament}' ?",
                        "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        FournisseurMedicament.SupprimerRelation(fournisseurSelectionne.ID_Fournisseur, idMedicament);

                        MessageBox.Show("La relation a été supprimée avec succès.",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Rafraîchir la liste
                        ChargerMedicamentsDuFournisseur(fournisseurSelectionne.ID_Fournisseur);

                        // Enregistrer l'action dans l'historique
                        if (Utilisateur.UtilisateurConnecte != null)
                        {
                            Utilisateur.UtilisateurConnecte.EnregistrerHistorique(
                                $"Suppression relation: Fournisseur '{fournisseurSelectionne.Nom}' - Médicament '{nomMedicament}'");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de la relation : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            if (menuParent != null)
            {
                menuParent.Show();
                this.Hide();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
