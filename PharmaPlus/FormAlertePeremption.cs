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
    public partial class FormAlertePeremption : Form
    {
        private Pharmacien pharmacien;
        private List<LotMedicament> lotsAlertes;


        public FormAlertePeremption()
        {
            InitializeComponent();
        }

        private void FormAlertePeremption_Load(object sender, EventArgs e)
        {
            pharmacien = new Pharmacien();
            RechercherLotsPeremption();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            RechercherLotsPeremption();
        }

        private void RechercherLotsPeremption()
        {
            try
            {
                int joursAvance = (int)nudJoursAvance.Value;

                lotsAlertes = pharmacien.ConsulterLotsPeremption(joursAvance);

                AfficherLotsAlertes();
                lblNombreAlertes.Text = $"Nombre de lots concernés : {lotsAlertes.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherLotsAlertes()
        {
            dgvMedicaments.Rows.Clear();

            // Charger les médicaments pour obtenir les noms
            List<Medicament> medicaments = Medicament.ListerMedicaments();

            foreach (var lot in lotsAlertes)
            {
                var medicament = medicaments.FirstOrDefault(m => m.ID_Medicament == lot.ID_Medicament);
                string nomMedicament = medicament != null ? medicament.Nom : "Inconnu";
                string reference = medicament != null ? medicament.Reference : "N/A";

                TimeSpan diff = lot.DatePeremption - DateTime.Now;
                int joursRestants = (int)diff.TotalDays;

                string statut;
                Color couleurLigne;

                if (joursRestants < 0)
                {
                    statut = $"PÉRIMÉ (depuis {Math.Abs(joursRestants)} jours)";
                    couleurLigne = Color.FromArgb(255, 180, 180);
                }
                else if (joursRestants <= 15)
                {
                    statut = $"Expire bientôt ({joursRestants} jours restants)";
                    couleurLigne = Color.FromArgb(255, 230, 200);
                }
                else
                {
                    statut = $"À surveiller ({joursRestants} jours restants)";
                    couleurLigne = Color.FromArgb(230, 255, 230);
                }

                int rowIndex = dgvMedicaments.Rows.Add(
                    lot.ID_Lot,
                    nomMedicament,
                    reference,
                    lot.NumeroLot,
                    lot.DatePeremption.ToString("dd/MM/yyyy"),
                    lot.QuantiteLot,
                    joursRestants,
                    statut
                );

                dgvMedicaments.Rows[rowIndex].DefaultCellStyle.BackColor = couleurLigne;
            }

            dgvMedicaments.Sort(dgvMedicaments.Columns["JoursRestants"], ListSortDirection.Ascending);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMenuPharmacien formMenuPhamacien = new FormMenuPharmacien();
            formMenuPhamacien.Show();
            this.Hide();
        }
    }
}
