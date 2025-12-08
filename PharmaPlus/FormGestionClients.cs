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
    public partial class FormGestionClients : Form
    {
        private Pharmacien pharmacien;
        private int? selectedClientId = null;
        private List<Client> clientsList;

        public FormGestionClients()
        {
            InitializeComponent();
        }

        private void FormGestionClients_Load(object sender, EventArgs e)
        {
            pharmacien = new Pharmacien();
            if (Utilisateur.UtilisateurConnecte != null)
            {
                pharmacien.ID_Utilisateur = Utilisateur.UtilisateurConnecte.ID_Utilisateur;
            }
            ChargerClients();
            ViderChamps();
        }

        private void ChargerClients()
        {
            try
            {
                clientsList = Client.ListerClients();
                dgvClients.DataSource = null;
                dgvClients.DataSource = clientsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des clients : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            FiltrerClients();
        }

        private void FiltrerClients()
        {
            try
            {
                string recherche = textBox2.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(recherche))
                {
                    ChargerClients();
                    return;
                }

                if (clientsList == null || clientsList.Count == 0)
                {
                    MessageBox.Show("Aucun client à rechercher.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var clientsFiltres = clientsList.Where(c =>
                    c.CodeClient.ToLower().Contains(recherche) ||
                    c.Nom.ToLower().Contains(recherche) ||
                    c.Prenom.ToLower().Contains(recherche) ||
                    (c.Telephone != null && c.Telephone.ToLower().Contains(recherche)) ||
                    (c.Adresse != null && c.Adresse.ToLower().Contains(recherche))
                ).ToList();

                if (clientsFiltres.Count == 0)
                {
                    MessageBox.Show($"Aucun client trouvé avec '{textBox2.Text}'.",
                        "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvClients.DataSource = null;
                dgvClients.DataSource = clientsFiltres;
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
                textBox2.Clear();
                ChargerClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la réinitialisation : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                Client clientSelectionne = dgvClients.SelectedRows[0].DataBoundItem as Client;
                if (clientSelectionne != null)
                {
                    RemplirChamps(clientSelectionne);
                }
            }
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(textCodeClient.Text))
            {
                MessageBox.Show("Le code client est obligatoire.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCodeClient.Focus();
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

        private Client RecupererClient()
        {
            return new Client
            {
                CodeClient = textCodeClient.Text.Trim(),
                Nom = txtNom.Text.Trim(),
                Prenom = txtPrenom.Text.Trim(),
                Telephone = txtTelephone.Text.Trim(),
                Adresse = txtAdresse.Text.Trim()
            };
        }

        private void RemplirChamps(Client client)
        {
            selectedClientId = client.ID_Client;
            textCodeClient.Text = client.CodeClient;
            txtNom.Text = client.Nom;
            txtPrenom.Text = client.Prenom;
            txtTelephone.Text = client.Telephone;
            txtAdresse.Text = client.Adresse;
        }

        private void ViderChamps()
        {
            selectedClientId = null;
            textCodeClient.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
            txtAdresse.Clear();
            textBox2.Clear();

            if (dgvClients.SelectedRows.Count > 0)
            {
                dgvClients.ClearSelection();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiderChamps())
                    return;

                if (Client.CodeClientExiste(textCodeClient.Text.Trim()))
                {
                    MessageBox.Show($"Un client avec le code '{textCodeClient.Text}' existe déjà.\nVeuillez utiliser un code unique.",
                        "Code Client dupliqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textCodeClient.Focus();
                    textCodeClient.SelectAll();
                    return;
                }

                Client nouveauClient = RecupererClient();
                nouveauClient.InsererClient();

                if (pharmacien != null)
                {
                    pharmacien.EnregistrerHistorique($"Ajout du client: {nouveauClient.CodeClient} - {nouveauClient.NomComplet()}");
                }

                ChargerClients();
                ViderChamps();
                MessageBox.Show("Client ajouté avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Microsoft.Data.SqlClient.SqlException sqlEx)
            {
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show($"Un client avec le code '{textCodeClient.Text}' existe déjà dans la base de données.\nVeuillez utiliser un code unique.",
                        "Code dupliqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textCodeClient.Focus();
                    textCodeClient.SelectAll();
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
                if (!selectedClientId.HasValue)
                {
                    MessageBox.Show("Veuillez sélectionner un client à modifier.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValiderChamps())
                    return;

                Client clientExistant = Client.RechercherParCode(textCodeClient.Text.Trim());
                if (clientExistant != null && clientExistant.ID_Client != selectedClientId.Value)
                {
                    MessageBox.Show($"Un autre client utilise déjà le code '{textCodeClient.Text}'.\nVeuillez utiliser un code unique.",
                        "Code Client dupliqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textCodeClient.Focus();
                    textCodeClient.SelectAll();
                    return;
                }

                Client clientModifie = RecupererClient();
                clientModifie.ID_Client = selectedClientId.Value;

                clientModifie.MettreAJourClient();

                if (pharmacien != null)
                {
                    pharmacien.EnregistrerHistorique($"Modification du client ID: {clientModifie.ID_Client} - {clientModifie.CodeClient}");
                }

                ChargerClients();
                ViderChamps();
                MessageBox.Show("Client modifié avec succès.",
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
                if (!selectedClientId.HasValue)
                {
                    MessageBox.Show("Veuillez sélectionner un client à supprimer.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer ce client ?\nToutes ses commandes seront également supprimées.",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                Client clientASupprimer = new Client
                {
                    ID_Client = selectedClientId.Value,
                    CodeClient = textCodeClient.Text.Trim()
                };

                clientASupprimer.SupprimerClient();

                if (pharmacien != null)
                {
                    pharmacien.EnregistrerHistorique($"Suppression du client ID: {clientASupprimer.ID_Client} - {clientASupprimer.CodeClient}");
                }

                ChargerClients();
                ViderChamps();
                MessageBox.Show("Client supprimé avec succès.",
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