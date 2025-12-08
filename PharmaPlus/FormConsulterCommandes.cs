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
    public partial class FormConsulterCommandes : Form
    {
        private readonly Form? menuParent;
        private List<Commande> commandes;
        private List<CommandeViewModel> commandesView;
        private Commande commandeSelectionnee;

        public FormConsulterCommandes() : this(null)
        {
        }

        public FormConsulterCommandes(Form? parent)
        {
            menuParent = parent;
            InitializeComponent();
            InitialiserFormulaire();
        }

        /// <summary>
        /// Initialiser le formulaire au chargement
        /// </summary>
        private void InitialiserFormulaire()
        {
            try
            {
                ConfigurerDataGridViewCommandes();
                ConfigurerDataGridViewDetails();
                ChargerCommandes();
                ViderDetailsCommande();

                // Configurer les événements
                btnRetour.Click += BtnRetour_Click;
                btnRafraichir.Click += BtnRafraichir_Click;
                txtRecherche.TextChanged += TxtRecherche_TextChanged;
                dgvCommandes.SelectionChanged += DgvCommandes_SelectionChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'initialisation du formulaire : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configurer les colonnes du DataGridView des commandes
        /// </summary>
        private void ConfigurerDataGridViewCommandes()
        {
            dgvCommandes.AutoGenerateColumns = false;
            dgvCommandes.Columns.Clear();
            dgvCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCommandes.AllowUserToResizeColumns = false;
            dgvCommandes.AllowUserToResizeRows = false;

            dgvCommandes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientNom",
                HeaderText = "Client",
                DataPropertyName = "ClientNom",
                FillWeight = 160
            });

            dgvCommandes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DateCommande",
                HeaderText = "Date",
                DataPropertyName = "DateCommande",
                FillWeight = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvCommandes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MontantTotal",
                HeaderText = "Montant Total",
                DataPropertyName = "MontantTotal",
                FillWeight = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

        }

        /// <summary>
        /// Configurer les colonnes du DataGridView des détails
        /// </summary>
        private void ConfigurerDataGridViewDetails()
        {
            dgvDetailsCommande.AutoGenerateColumns = false;
            dgvDetailsCommande.Columns.Clear();

            dgvDetailsCommande.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NomMedicament",
                HeaderText = "Médicament",
                Width = 180
            });

            dgvDetailsCommande.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantite",
                HeaderText = "Quantité",
                Width = 80
            });

            dgvDetailsCommande.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrixUnitaire",
                HeaderText = "Prix Unitaire",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvDetailsCommande.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SousTotal",
                HeaderText = "Sous-Total",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }

        /// <summary>
        /// Charger toutes les commandes
        /// </summary>
        private void ChargerCommandes()
        {
            try
            {
                commandes = Commande.ListerCommandes();
                commandesView = ConstruireCommandesView(commandes);
                dgvCommandes.DataSource = null;
                dgvCommandes.DataSource = commandesView;

                if (commandes.Count == 0)
                {
                    MessageBox.Show("Aucune commande trouvée dans la base de données.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des commandes : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Événement de changement de sélection dans le DataGridView des commandes
        /// </summary>
        private void DgvCommandes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCommandes.SelectedRows.Count > 0)
            {
                var vm = dgvCommandes.SelectedRows[0].DataBoundItem as CommandeViewModel;
                commandeSelectionnee = vm?.Commande;
                if (commandeSelectionnee != null)
                {
                    AfficherDetailsCommande(commandeSelectionnee);
                }
            }
            else
            {
                ViderDetailsCommande();
            }
        }

        /// <summary>
        /// Afficher les détails de la commande sélectionnée
        /// </summary>
        private void AfficherDetailsCommande(Commande commande)
        {
            try
            {
                // Charger les informations du client
                Client client = Client.RechercherParID(commande.ID_Client);

                if (client != null)
                {
                    txtCodeClient.Text = client.CodeClient;
                    txtNomClient.Text = client.NomComplet();
                }
                else
                {
                    txtCodeClient.Text = commande.ID_Client.ToString();
                    txtNomClient.Text = "Client non trouvé";
                }

                // Afficher les informations de la commande
                txtDateCommande.Text = commande.DateCommande.ToString("dd/MM/yyyy HH:mm");
                txtMontantTotal.Text = commande.MontantTotal.ToString("C2");

                // Charger les détails de la commande
                commande.ChargerDetails();
                AfficherDetailsLignes(commande.Details);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'affichage des détails : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Afficher les lignes de détail dans le DataGridView
        /// </summary>
        private void AfficherDetailsLignes(List<DetailsCommande> details)
        {
            try
            {
                dgvDetailsCommande.Rows.Clear();

                foreach (var detail in details)
                {
                    int rowIndex = dgvDetailsCommande.Rows.Add();
                    DataGridViewRow row = dgvDetailsCommande.Rows[rowIndex];

                    // Récupérer le nom du médicament
                    string nomMedicament = ObtenirNomMedicament(detail.ID_Medicament);

                    row.Cells["NomMedicament"].Value = nomMedicament;
                    row.Cells["Quantite"].Value = detail.Quantite;
                    row.Cells["PrixUnitaire"].Value = detail.PrixUnitaire;
                    row.Cells["SousTotal"].Value = detail.SousTotal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'affichage des lignes de détail : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obtenir le nom d'un médicament par son ID
        /// </summary>
        private string ObtenirNomMedicament(int idMedicament)
        {
            try
            {
                var medicaments = Medicament.ListerMedicaments();
                var medicament = medicaments.FirstOrDefault(m => m.ID_Medicament == idMedicament);
                return medicament?.Nom ?? $"Médicament #{idMedicament}";
            }
            catch
            {
                return $"Médicament #{idMedicament}";
            }
        }

        /// <summary>
        /// Vider les champs de détails
        /// </summary>
        private void ViderDetailsCommande()
        {
            txtCodeClient.Clear();
            txtNomClient.Clear();
            txtDateCommande.Clear();
            txtMontantTotal.Clear();
            dgvDetailsCommande.Rows.Clear();
            commandeSelectionnee = null;
        }

        /// <summary>
        /// Rechercher des commandes
        /// </summary>
        private void TxtRecherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string recherche = txtRecherche.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(recherche))
                {
                    dgvCommandes.DataSource = null;
                    dgvCommandes.DataSource = commandesView;
                    return;
                }

                var commandesFiltrees = commandesView.Where(c =>
                {
                    if (c.ClientNom.ToLower().Contains(recherche))
                        return true;

                    if (!string.IsNullOrEmpty(c.CodeClient) && c.CodeClient.ToLower().Contains(recherche))
                        return true;

                    if (c.Commande.ID_Commande.ToString().Contains(recherche))
                        return true;

                    return false;
                }).ToList();

                dgvCommandes.DataSource = null;
                dgvCommandes.DataSource = commandesFiltrees;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Rafraîchir la liste des commandes
        /// </summary>
        private void BtnRafraichir_Click(object sender, EventArgs e)
        {
            try
            {
                txtRecherche.Clear();
                ChargerCommandes();
                ViderDetailsCommande();
                MessageBox.Show("Liste des commandes rafraîchie avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du rafraîchissement : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Retour au menu principal
        /// </summary>
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            if (menuParent != null)
            {
                menuParent.Show();
            }
            Close();
        }

        private List<CommandeViewModel> ConstruireCommandesView(List<Commande> commandesSource)
        {
            var liste = new List<CommandeViewModel>();

            foreach (var cmd in commandesSource)
            {
                Client? client = null;
                try
                {
                    client = Client.RechercherParID(cmd.ID_Client);
                }
                catch { }

                liste.Add(new CommandeViewModel
                {
                    Commande = cmd,
                    ClientNom = client?.NomComplet() ?? $"Client #{cmd.ID_Client}",
                    CodeClient = client?.CodeClient ?? string.Empty
                });
            }

            return liste;
        }

        private class CommandeViewModel
        {
            public Commande Commande { get; set; }
            public string ClientNom { get; set; }
            public string CodeClient { get; set; }
            public DateTime DateCommande => Commande.DateCommande;
            public decimal MontantTotal => Commande.MontantTotal;
        }
    }
}
