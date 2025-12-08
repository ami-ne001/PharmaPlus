using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PharmaPlus
{
    public partial class FormAjouterCommande : Form
    {
        private List<Client> clients;
        private List<Medicament> medicaments;
        private Client clientSelectionne;
        private Medicament medicamentSelectionne;
        private List<LotMedicament> lotsDisponibles;
        private LotMedicament lotSelectionne;
        private DataTable panier;
        private Pharmacien pharmacien;

        public FormAjouterCommande()
        {
            InitializeComponent();
            panier = new DataTable();
            panier.Columns.Add("ID_Medicament", typeof(int));
            panier.Columns.Add("ID_Lot", typeof(int));
            panier.Columns.Add("Reference", typeof(string));
            panier.Columns.Add("Nom", typeof(string));
            panier.Columns.Add("Fabricant", typeof(string));
            panier.Columns.Add("Quantite", typeof(int));
            panier.Columns.Add("PrixUnitaire", typeof(decimal));
            panier.Columns.Add("PrixTotal", typeof(decimal));
        }

        private void FormAjouterCommande_Load(object sender, EventArgs e)
        {
            pharmacien = new Pharmacien();
            if (Utilisateur.UtilisateurConnecte != null)
            {
                pharmacien.ID_Utilisateur = Utilisateur.UtilisateurConnecte.ID_Utilisateur;
            }

            ChargerClients();
            ChargerMedicaments();
            InitialiserDataGridView();
            MettreAJourTotal();
        }

        private void btnAjouterPanier_Click(object sender, EventArgs e)
        {
            AjouterAuPanier();
        }

        private void ChargerClients()
        {
            try
            {
                clients = Client.ListerClients();
                cmbMedicaments.Items.Clear();
                cmbMedicaments.DisplayMember = "ToString";
                cmbMedicaments.ValueMember = "ID_Client";

                foreach (var client in clients)
                {
                    cmbMedicaments.Items.Add(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des clients: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerMedicaments()
        {
            try
            {
                medicaments = Medicament.ListerMedicaments();
                comboBox1.Items.Clear();
                comboBox1.DisplayMember = "Nom";
                comboBox1.ValueMember = "ID_Medicament";

                foreach (var med in medicaments)
                {
                    comboBox1.Items.Add(med);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des médicaments: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitialiserDataGridView()
        {
            dgvMedicaments.Columns.Clear();

            dgvMedicaments.DataSource = panier;
            dgvMedicaments.CellValueChanged += dgvMedicaments_CellValueChanged;

            // Masquer les colonnes techniques après le chargement
            dgvMedicaments.DataBindingComplete += (s, e) =>
            {
                // Masquer uniquement les colonnes techniques (ID)
                if (dgvMedicaments.Columns["ID_Medicament"] != null)
                    dgvMedicaments.Columns["ID_Medicament"].Visible = false;
                if (dgvMedicaments.Columns["ID_Lot"] != null)
                    dgvMedicaments.Columns["ID_Lot"].Visible = false;

                if (dgvMedicaments.Columns["Quantite"] != null)
                {
                    dgvMedicaments.Columns["Quantite"].ReadOnly = false;
                }

                // Configurer les colonnes visibles
                if (dgvMedicaments.Columns["Reference"] != null)
                {
                    dgvMedicaments.Columns["Reference"].HeaderText = "Référence";
                    dgvMedicaments.Columns["Reference"].Width = 120;
                }
                if (dgvMedicaments.Columns["Nom"] != null)
                {
                    dgvMedicaments.Columns["Nom"].HeaderText = "Nom Médicament";
                    dgvMedicaments.Columns["Nom"].Width = 180;
                }
                if (dgvMedicaments.Columns["Fabricant"] != null)
                {
                    dgvMedicaments.Columns["Fabricant"].HeaderText = "Fabricant";
                    dgvMedicaments.Columns["Fabricant"].Width = 120;
                }
                if (dgvMedicaments.Columns["Quantite"] != null)
                {
                    dgvMedicaments.Columns["Quantite"].HeaderText = "Quantité";
                    dgvMedicaments.Columns["Quantite"].Width = 80;
                }
                if (dgvMedicaments.Columns["PrixUnitaire"] != null)
                {
                    dgvMedicaments.Columns["PrixUnitaire"].HeaderText = "Prix Unitaire";
                    dgvMedicaments.Columns["PrixUnitaire"].Width = 110;
                    dgvMedicaments.Columns["PrixUnitaire"].DefaultCellStyle.Format = "F2";
                    dgvMedicaments.Columns["PrixUnitaire"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvMedicaments.Columns["PrixTotal"] != null)
                {
                    dgvMedicaments.Columns["PrixTotal"].HeaderText = "Prix Total";
                    dgvMedicaments.Columns["PrixTotal"].Width = 110;
                    dgvMedicaments.Columns["PrixTotal"].DefaultCellStyle.Format = "F2";
                    dgvMedicaments.Columns["PrixTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvMedicaments.Columns["PrixTotal"].DefaultCellStyle.Font = new Font(dgvMedicaments.Font, FontStyle.Bold);
                }
            };
        }

        private void cmbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicaments.SelectedItem != null)
            {
                clientSelectionne = cmbMedicaments.SelectedItem as Client;
                if (clientSelectionne != null)
                {
                    txtCodeClient.Text = clientSelectionne.CodeClient;
                    txtNomClient.Text = clientSelectionne.Nom;
                    txtPrenomClient.Text = clientSelectionne.Prenom;
                    txtTelephoneClient.Text = clientSelectionne.Telephone;
                    txtAdresseClient.Text = clientSelectionne.Adresse;
                }
            }
        }

        private void txtCodeClient_TextChanged(object sender, EventArgs e)
        {
            // Auto-remplissage si le code client correspond
            if (!string.IsNullOrWhiteSpace(txtCodeClient.Text))
            {
                var client = Client.RechercherParCode(txtCodeClient.Text);
                if (client != null)
                {
                    clientSelectionne = client;
                    txtNomClient.Text = client.Nom;
                    txtPrenomClient.Text = client.Prenom;
                    txtTelephoneClient.Text = client.Telephone;
                    txtAdresseClient.Text = client.Adresse;

                    // Sélectionner dans la combobox
                    for (int i = 0; i < cmbMedicaments.Items.Count; i++)
                    {
                        if (((Client)cmbMedicaments.Items[i]).ID_Client == client.ID_Client)
                        {
                            cmbMedicaments.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                medicamentSelectionne = comboBox1.SelectedItem as Medicament;
                if (medicamentSelectionne != null)
                {
                    txtReferenceMed.Text = medicamentSelectionne.Reference;
                    txtNomMed.Text = medicamentSelectionne.Nom;
                    txtFabricantMed.Text = medicamentSelectionne.Fabricant;
                    txtQuantiteTotaleMed.Text = medicamentSelectionne.QuantiteTotale.ToString();

                    // Charger les lots disponibles pour ce médicament
                    ChargerLotsMedicament();

                    // Mettre à jour le NumericUpDown avec la quantité disponible
                    if (lotSelectionne != null)
                    {
                        nudQuantiteMedPanier.Maximum = lotSelectionne.QuantiteLot;
                        nudQuantiteMedPanier.Value = Math.Min(1, lotSelectionne.QuantiteLot);
                        nudQuantiteMedPanier.Enabled = true;
                    }
                    else
                    {
                        nudQuantiteMedPanier.Enabled = false;
                        nudQuantiteMedPanier.Value = 1;
                    }
                }
            }
            else
            {
                nudQuantiteMedPanier.Enabled = false;
            }
        }

        private void ChargerLotsMedicament()
        {
            if (medicamentSelectionne != null)
            {
                try
                {
                    lotsDisponibles = LotMedicament.ListerLotsParMedicament(medicamentSelectionne.ID_Medicament);
                    lotsDisponibles = lotsDisponibles.Where(l => l.QuantiteLot > 0).ToList();

                    if (lotsDisponibles.Count > 0)
                    {
                        lotSelectionne = lotsDisponibles.OrderBy(l => l.DatePeremption).FirstOrDefault();
                    }
                    else
                    {
                        lotSelectionne = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement des lots: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lotsDisponibles = null;
                    lotSelectionne = null;
                }
            }
        }

        private void dgvMedicaments_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < panier.Rows.Count)
            {
                var quantiteCol = dgvMedicaments.Columns["Quantite"];
                if (quantiteCol != null && e.ColumnIndex == quantiteCol.Index)
                {
                    try
                    {
                        // Mettre à jour le prix total pour cette ligne
                        DataRow row = panier.Rows[e.RowIndex];
                        int quantite = Convert.ToInt32(row["Quantite"]);
                        decimal prixUnitaire = Convert.ToDecimal(row["PrixUnitaire"]);
                        row["PrixTotal"] = quantite * prixUnitaire;

                        MettreAJourTotal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la mise à jour: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AjouterAuPanier()
        {
            if (medicamentSelectionne == null)
            {
                MessageBox.Show("Veuillez sélectionner un médicament.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lotsDisponibles == null || lotsDisponibles.Count == 0)
            {
                MessageBox.Show("Aucun lot disponible pour ce médicament.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Utiliser le premier lot disponible (ou le lot avec la date de péremption la plus proche)
            if (lotSelectionne == null)
            {
                lotSelectionne = lotsDisponibles.OrderBy(l => l.DatePeremption).FirstOrDefault();
            }

            if (lotSelectionne == null)
            {
                MessageBox.Show("Aucun lot disponible pour ce médicament.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer la quantité depuis le NumericUpDown
            int quantite = (int)nudQuantiteMedPanier.Value;

            if (quantite <= 0)
            {
                MessageBox.Show("La quantité doit être supérieure à 0.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantite > lotSelectionne.QuantiteLot)
            {
                MessageBox.Show($"La quantité demandée dépasse le stock disponible ({lotSelectionne.QuantiteLot}).", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifier si le médicament est déjà dans le panier
            DataRow[] rowsExistantes = panier.Select($"ID_Medicament = {medicamentSelectionne.ID_Medicament}");
            if (rowsExistantes.Length > 0)
            {
                int nouvelleQuantite = Convert.ToInt32(rowsExistantes[0]["Quantite"]) + quantite;

                int stockTotalDisponible = lotsDisponibles.Sum(l => l.QuantiteLot);
                if (nouvelleQuantite > stockTotalDisponible)
                {
                    MessageBox.Show($"La quantité totale demandée dépasse le stock disponible ({stockTotalDisponible}).", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rowsExistantes[0]["Quantite"] = nouvelleQuantite;
                rowsExistantes[0]["PrixTotal"] = nouvelleQuantite * lotSelectionne.Prix;
            }
            else
            {
                DataRow row = panier.NewRow();
                row["ID_Medicament"] = medicamentSelectionne.ID_Medicament;
                row["ID_Lot"] = lotSelectionne.ID_Lot;
                row["Reference"] = medicamentSelectionne.Reference;
                row["Nom"] = medicamentSelectionne.Nom;
                row["Fabricant"] = medicamentSelectionne.Fabricant;
                row["Quantite"] = quantite;
                row["PrixUnitaire"] = lotSelectionne.Prix;
                row["PrixTotal"] = quantite * lotSelectionne.Prix;
                panier.Rows.Add(row);
            }

            MettreAJourTotal();
            MessageBox.Show("Médicament ajouté au panier avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nudQuantiteMedPanier.Value = 1;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            EnregistrerCommande();
        }

        private void MettreAJourTotal()
        {
            decimal total = 0;
            foreach (DataRow row in panier.Rows)
            {
                total += Convert.ToDecimal(row["PrixTotal"]);
            }
            textBox9.Text = total.ToString("F2") + " MAD";
        }

        private void EnregistrerCommande()
        {
            if (clientSelectionne == null)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (panier.Rows.Count == 0)
            {
                MessageBox.Show("Le panier est vide. Veuillez ajouter des médicaments.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Commande commande = new Commande
                {
                    ID_Client = clientSelectionne.ID_Client,
                    DateCommande = DateTime.Now,
                    MontantTotal = Convert.ToDecimal(textBox9.Text.Replace(" MAD", "").Replace(" ", "")),
                    Statut = "En Attente"
                };

                foreach (DataRow row in panier.Rows)
                {
                    DetailsCommande detail = new DetailsCommande
                    {
                        ID_Lot = Convert.ToInt32(row["ID_Lot"]),
                        Quantite = Convert.ToInt32(row["Quantite"]),
                        PrixVente = Convert.ToDecimal(row["PrixUnitaire"])
                    };
                    commande.Details.Add(detail);
                }

                // Insérer la commande
                commande.InsererCommande();

                if (pharmacien != null && pharmacien.ID_Utilisateur > 0)
                {
                    string codeClient = clientSelectionne?.CodeClient ?? clientSelectionne?.NomComplet() ?? "Client inconnu";
                    pharmacien.EnregistrerHistorique($"Enregistrement commande ID: {commande.ID_Commande} pour {codeClient} - Total {commande.MontantTotal:F2} MAD");
                }

                // Mettre à jour les quantités des lots
                foreach (DataRow row in panier.Rows)
                {
                    int idLot = Convert.ToInt32(row["ID_Lot"]);
                    int quantiteVendue = Convert.ToInt32(row["Quantite"]);

                    using (SqlConnection conn = Connection.GetConnexion())
                    {
                        string query = "UPDATE LotsMedicaments SET QuantiteLot = QuantiteLot - @Quantite WHERE ID_Lot = @ID_Lot";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Quantite", quantiteVendue);
                            cmd.Parameters.AddWithValue("@ID_Lot", idLot);
                            cmd.ExecuteNonQuery();
                        }

                        // Mettre à jour la quantité totale du médicament
                        int idMedicament = Convert.ToInt32(row["ID_Medicament"]);
                        Medicament med = new Medicament { ID_Medicament = idMedicament };
                        med.MettreAJourQuantiteTotale();
                    }
                }

                MessageBox.Show("Commande enregistrée avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ReinitialiserFormulaire();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement de la commande: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReinitialiserFormulaire();
        }

        private void ReinitialiserFormulaire()
        {
            cmbMedicaments.SelectedIndex = -1;
            txtCodeClient.Clear();
            txtNomClient.Clear();
            txtPrenomClient.Clear();
            txtTelephoneClient.Clear();
            txtAdresseClient.Clear();
            clientSelectionne = null;

            comboBox1.SelectedIndex = -1;
            txtReferenceMed.Clear();
            txtNomMed.Clear();
            txtFabricantMed.Clear();
            txtQuantiteTotaleMed.Clear();
            medicamentSelectionne = null;
            lotsDisponibles = null;
            lotSelectionne = null;

            nudQuantiteMedPanier.Value = 1;
            nudQuantiteMedPanier.Enabled = false;

            panier.Clear();
            MettreAJourTotal();
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
