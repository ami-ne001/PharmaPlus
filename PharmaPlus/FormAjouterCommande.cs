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
            ChargerClients();
            ChargerMedicaments();
            InitialiserDataGridView();
            MettreAJourTotal();
            AjouterBoutonAjouterAuPanier();
            btnRetour.Click += BtnRetour_Click;
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterBoutonAjouterAuPanier()
        {
            Button btnAjouterAuPanier = new Button
            {
                Text = "Ajouter au Panier",
                BackColor = Color.FromArgb(0, 85, 70),
                FlatStyle = FlatStyle.Popup,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(224, 310),
                Size = new Size(180, 35),
                TabIndex = 100
            };
            btnAjouterAuPanier.Click += BtnAjouterAuPanier_Click;
            panel3.Controls.Add(btnAjouterAuPanier);
        }

        private void BtnAjouterAuPanier_Click(object sender, EventArgs e)
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
            // Supprimer les colonnes prédéfinies pour utiliser celles du DataTable
            dgvMedicaments.Columns.Clear();
            
            dgvMedicaments.DataSource = panier;
            dgvMedicaments.CellValueChanged += dgvMedicaments_CellValueChanged;
            dgvMedicaments.KeyDown += dgvMedicaments_KeyDown;
            
            // Masquer les colonnes techniques après le chargement
            dgvMedicaments.DataBindingComplete += (s, e) =>
            {
                if (dgvMedicaments.Columns["ID_Medicament"] != null)
                    dgvMedicaments.Columns["ID_Medicament"].Visible = false;
                if (dgvMedicaments.Columns["ID_Lot"] != null)
                    dgvMedicaments.Columns["ID_Lot"].Visible = false;
                if (dgvMedicaments.Columns["PrixUnitaire"] != null)
                    dgvMedicaments.Columns["PrixUnitaire"].Visible = false;
                if (dgvMedicaments.Columns["PrixTotal"] != null)
                    dgvMedicaments.Columns["PrixTotal"].Visible = false;
                
                // Rendre la colonne Quantite éditable
                if (dgvMedicaments.Columns["Quantite"] != null)
                {
                    dgvMedicaments.Columns["Quantite"].ReadOnly = false;
                    dgvMedicaments.Columns["Quantite"].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                
                // Configurer les colonnes visibles
                if (dgvMedicaments.Columns["Reference"] != null)
                {
                    dgvMedicaments.Columns["Reference"].HeaderText = "Référence";
                    dgvMedicaments.Columns["Reference"].Width = 125;
                }
                if (dgvMedicaments.Columns["Nom"] != null)
                {
                    dgvMedicaments.Columns["Nom"].HeaderText = "Nom Médicament";
                    dgvMedicaments.Columns["Nom"].Width = 180;
                }
                if (dgvMedicaments.Columns["Fabricant"] != null)
                {
                    dgvMedicaments.Columns["Fabricant"].HeaderText = "Fabricant";
                    dgvMedicaments.Columns["Fabricant"].Width = 125;
                }
                if (dgvMedicaments.Columns["Quantite"] != null)
                {
                    dgvMedicaments.Columns["Quantite"].HeaderText = "Quantité";
                    dgvMedicaments.Columns["Quantite"].Width = 125;
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

        private void txtNomClient_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void txtPrenomClient_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void txtTelephoneClient_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void txtAdresseClient_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
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
                }
            }
        }

        private void ChargerLotsMedicament()
        {
            if (medicamentSelectionne != null)
            {
                try
                {
                    lotsDisponibles = LotMedicament.ListerLotsParMedicament(medicamentSelectionne.ID_Medicament);
                    // Filtrer les lots avec quantité > 0
                    lotsDisponibles = lotsDisponibles.Where(l => l.QuantiteLot > 0).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement des lots: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtReferenceMed_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void txtNomMed_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void txtFabricantMed_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void txtQuantiteTotaleMed_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void dgvMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Permettre la suppression avec la touche Delete
            if (e.RowIndex >= 0 && dgvMedicaments.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Si on ajoute un bouton de suppression plus tard
            }
        }

        private void dgvMedicaments_KeyDown(object sender, KeyEventArgs e)
        {
            // Permettre la suppression avec la touche Delete
            if (e.KeyCode == Keys.Delete && dgvMedicaments.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvMedicaments.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        panier.Rows.RemoveAt(row.Index);
                    }
                }
                MettreAJourTotal();
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void AjouterAuPanier()
        {
            // Ajouter le médicament au panier
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
            lotSelectionne = lotsDisponibles.OrderBy(l => l.DatePeremption).FirstOrDefault();

            if (lotSelectionne == null)
            {
                MessageBox.Show("Aucun lot disponible pour ce médicament.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Demander la quantité
            using (FormQuantite formQuantite = new FormQuantite(lotSelectionne.QuantiteLot))
            {
                if (formQuantite.ShowDialog() == DialogResult.OK)
                {
                    int quantite = formQuantite.Quantite;

                    // Vérifier si le médicament est déjà dans le panier
                    DataRow[] rowsExistantes = panier.Select($"ID_Medicament = {medicamentSelectionne.ID_Medicament}");
                    if (rowsExistantes.Length > 0)
                    {
                        // Mettre à jour la quantité
                        int nouvelleQuantite = Convert.ToInt32(rowsExistantes[0]["Quantite"]) + quantite;
                        if (nouvelleQuantite > lotSelectionne.QuantiteLot)
                        {
                            MessageBox.Show($"La quantité demandée dépasse le stock disponible ({lotSelectionne.QuantiteLot}).", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        rowsExistantes[0]["Quantite"] = nouvelleQuantite;
                        rowsExistantes[0]["PrixTotal"] = nouvelleQuantite * lotSelectionne.Prix;
                    }
                    else
                    {
                        // Ajouter une nouvelle ligne
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
                }
            }
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
            // Enregistrer la commande
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
                // Créer la commande
                Commande commande = new Commande
                {
                    ID_Client = clientSelectionne.ID_Client,
                    DateCommande = DateTime.Now,
                    MontantTotal = Convert.ToDecimal(textBox9.Text.Replace(" MAD", "").Replace(" ", "")),
                    Statut = "En Attente"
                };

                // Ajouter les détails
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
                
                // Réinitialiser le formulaire
                ReinitialiserFormulaire();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement de la commande: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Réinitialiser tous les champs
            ReinitialiserFormulaire();
        }

        private void ReinitialiserFormulaire()
        {
            // Réinitialiser les champs client
            cmbMedicaments.SelectedIndex = -1;
            txtCodeClient.Clear();
            txtNomClient.Clear();
            txtPrenomClient.Clear();
            txtTelephoneClient.Clear();
            txtAdresseClient.Clear();
            clientSelectionne = null;

            // Réinitialiser les champs médicament
            comboBox1.SelectedIndex = -1;
            txtReferenceMed.Clear();
            txtNomMed.Clear();
            txtFabricantMed.Clear();
            txtQuantiteTotaleMed.Clear();
            medicamentSelectionne = null;
            lotsDisponibles = null;

            // Vider le panier
            panier.Clear();
            MettreAJourTotal();
        }
    }

    // Classe helper pour saisir la quantité
    public class FormQuantite : Form
    {
        private NumericUpDown numericQuantite;
        private Button btnOK;
        private Button btnAnnuler;
        private int stockMax;

        public int Quantite { get; private set; }

        public FormQuantite(int stockMax)
        {
            this.stockMax = stockMax;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Saisir la quantité";
            this.Size = new Size(300, 150);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lblQuantite = new Label
            {
                Text = $"Quantité (max: {stockMax}):",
                Location = new Point(20, 20),
                Size = new Size(150, 20)
            };

            numericQuantite = new NumericUpDown
            {
                Location = new Point(180, 18),
                Size = new Size(80, 20),
                Minimum = 1,
                Maximum = stockMax,
                Value = 1
            };

            btnOK = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Location = new Point(50, 60),
                Size = new Size(80, 30)
            };

            btnAnnuler = new Button
            {
                Text = "Annuler",
                DialogResult = DialogResult.Cancel,
                Location = new Point(150, 60),
                Size = new Size(80, 30)
            };

            btnOK.Click += (s, e) => { Quantite = (int)numericQuantite.Value; };
            btnAnnuler.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; };

            this.Controls.Add(lblQuantite);
            this.Controls.Add(numericQuantite);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnAnnuler);
        }
    }
}
