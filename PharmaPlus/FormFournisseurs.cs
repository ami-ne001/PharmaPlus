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
    public partial class FormFournisseurs : Form
    {
        private Pharmacien pharmacien;
        private int? selectedFournisseurId = null;
        private List<Fournisseur> fournisseursList;

        public FormFournisseurs()
        {
            InitializeComponent();
        }

        private void FormFournisseurs_Load(object sender, EventArgs e)
        {
            pharmacien = new Pharmacien();
            if (Utilisateur.UtilisateurConnecte != null)
            {
                pharmacien.ID_Utilisateur = Utilisateur.UtilisateurConnecte.ID_Utilisateur;
            }
            ChargerFournisseurs();
            ViderChamps();
        }

        private void ChargerFournisseurs()
        {
            try
            {
                fournisseursList = Fournisseur.ListerFournisseurs();
                dgvFournisseurs.Rows.Clear();
                
                foreach (Fournisseur f in fournisseursList)
                {
                    dgvFournisseurs.Rows.Add(
                        f.CodeFournisseur,
                        f.Nom ?? "",
                        f.Telephone ?? "",
                        f.Email ?? "",
                        f.Adresse ?? ""
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des fournisseurs : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            FiltrerFournisseurs();
        }

        private void FiltrerFournisseurs()
        {
            try
            {
                string recherche = textRecherche.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(recherche))
                {
                    ChargerFournisseurs();
                    return;
                }

                if (fournisseursList == null || fournisseursList.Count == 0)
                {
                    MessageBox.Show("Aucun fournisseur à rechercher.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var fournisseursFiltres = fournisseursList.Where(f =>
                    f.CodeFournisseur.ToLower().Contains(recherche) ||
                    (f.Nom != null && f.Nom.ToLower().Contains(recherche)) ||
                    (f.Telephone != null && f.Telephone.ToLower().Contains(recherche)) ||
                    (f.Email != null && f.Email.ToLower().Contains(recherche)) ||
                    (f.Adresse != null && f.Adresse.ToLower().Contains(recherche))
                ).ToList();

                if (fournisseursFiltres.Count == 0)
                {
                    MessageBox.Show($"Aucun fournisseur trouvé avec '{textRecherche.Text}'.",
                        "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvFournisseurs.Rows.Clear();
                foreach (Fournisseur f in fournisseursFiltres)
                {
                    dgvFournisseurs.Rows.Add(
                        f.CodeFournisseur,
                        f.Nom ?? "",
                        f.Telephone ?? "",
                        f.Email ?? "",
                        f.Adresse ?? ""
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReinitialiserRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                textRecherche.Clear();
                ChargerFournisseurs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la réinitialisation : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFournisseurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFournisseurs.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFournisseurs.SelectedRows[0];
                string codeFournisseur = selectedRow.Cells["CodeFournisseur"].Value?.ToString();
                
                if (!string.IsNullOrEmpty(codeFournisseur))
                {
                    Fournisseur fournisseurSelectionne = Fournisseur.RechercherParCode(codeFournisseur);
                    if (fournisseurSelectionne != null)
                    {
                        RemplirChamps(fournisseurSelectionne);
                    }
                }
            }
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtCodeFournisseur.Text))
            {
                MessageBox.Show("Le code fournisseur est obligatoire.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodeFournisseur.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le nom est obligatoire.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }

            return true;
        }

        private Fournisseur RecupererFournisseur()
        {
            return new Fournisseur
            {
                CodeFournisseur = txtCodeFournisseur.Text.Trim(),
                Nom = txtNom.Text.Trim(),
                Telephone = txtTelephone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Adresse = txtAdresse.Text.Trim()
            };
        }

        private void RemplirChamps(Fournisseur fournisseur)
        {
            selectedFournisseurId = fournisseur.ID_Fournisseur;
            txtCodeFournisseur.Text = fournisseur.CodeFournisseur;
            txtNom.Text = fournisseur.Nom;
            txtTelephone.Text = fournisseur.Telephone;
            txtEmail.Text = fournisseur.Email;
            txtAdresse.Text = fournisseur.Adresse;
        }

        private void ViderChamps()
        {
            selectedFournisseurId = null;
            txtCodeFournisseur.Clear();
            txtNom.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
            txtAdresse.Clear();
            textRecherche.Clear();

            if (dgvFournisseurs.SelectedRows.Count > 0)
            {
                dgvFournisseurs.ClearSelection();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderChamps())
                    return;

                if (Fournisseur.CodeExiste(txtCodeFournisseur.Text.Trim()))
                {
                    MessageBox.Show($"Un fournisseur avec le code '{txtCodeFournisseur.Text}' existe déjà.\nVeuillez utiliser un code unique.",
                        "Code Fournisseur dupliqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodeFournisseur.Focus();
                    txtCodeFournisseur.SelectAll();
                    return;
                }

                Fournisseur nouveauFournisseur = RecupererFournisseur();
                nouveauFournisseur.InsererFournisseur();

                if (pharmacien != null)
                {
                    pharmacien.EnregistrerHistorique($"Ajout du fournisseur: {nouveauFournisseur.CodeFournisseur} - {nouveauFournisseur.Nom}");
                }

                ChargerFournisseurs();
                ViderChamps();
                MessageBox.Show("Fournisseur ajouté avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Microsoft.Data.SqlClient.SqlException sqlEx)
            {
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show($"Un fournisseur avec le code '{txtCodeFournisseur.Text}' existe déjà dans la base de données.\nVeuillez utiliser un code unique.",
                        "Code dupliqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodeFournisseur.Focus();
                    txtCodeFournisseur.SelectAll();
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
                if (!selectedFournisseurId.HasValue)
                {
                    MessageBox.Show("Veuillez sélectionner un fournisseur à modifier.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValiderChamps())
                    return;

                Fournisseur fournisseurExistant = Fournisseur.RechercherParCode(txtCodeFournisseur.Text.Trim());
                if (fournisseurExistant != null && fournisseurExistant.ID_Fournisseur != selectedFournisseurId.Value)
                {
                    MessageBox.Show($"Un autre fournisseur utilise déjà le code '{txtCodeFournisseur.Text}'.\nVeuillez utiliser un code unique.",
                        "Code Fournisseur dupliqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodeFournisseur.Focus();
                    txtCodeFournisseur.SelectAll();
                    return;
                }

                Fournisseur fournisseurModifie = RecupererFournisseur();
                fournisseurModifie.ID_Fournisseur = selectedFournisseurId.Value;

                fournisseurModifie.MettreAJourFournisseur();

                if (pharmacien != null)
                {
                    pharmacien.EnregistrerHistorique($"Modification du fournisseur ID: {fournisseurModifie.ID_Fournisseur} - {fournisseurModifie.CodeFournisseur}");
                }

                ChargerFournisseurs();
                ViderChamps();
                MessageBox.Show("Fournisseur modifié avec succès.",
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
                if (!selectedFournisseurId.HasValue)
                {
                    MessageBox.Show("Veuillez sélectionner un fournisseur à supprimer.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer ce fournisseur ?\nToutes ses associations avec les médicaments seront également supprimées.",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                Fournisseur fournisseurASupprimer = new Fournisseur
                {
                    ID_Fournisseur = selectedFournisseurId.Value,
                    CodeFournisseur = txtCodeFournisseur.Text.Trim()
                };

                fournisseurASupprimer.SupprimerFournisseur();

                if (pharmacien != null)
                {
                    pharmacien.EnregistrerHistorique($"Suppression du fournisseur ID: {fournisseurASupprimer.ID_Fournisseur} - {fournisseurASupprimer.CodeFournisseur}");
                }

                ChargerFournisseurs();
                ViderChamps();
                MessageBox.Show("Fournisseur supprimé avec succès.",
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
