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
    public partial class FormAlerteStockes : Form
    {
        private Pharmacien pharmacien;
        private List<Medicament> medicamentsAlertes;

        public FormAlerteStockes()
        {
            InitializeComponent();
        }

        private void FormAlerteStockes_Load(object sender, EventArgs e)
        {
            pharmacien = new Pharmacien();
            ConfigurerDataGridView();
            RechercherAlertesStock();
            // Clear any selection
            if (dgvMedicaments.SelectedRows.Count > 0)
            {
                dgvMedicaments.ClearSelection();
            }
        }

        private void ConfigurerDataGridView()
        {
            try
            {
                // Configure column widths to ensure all columns are visible
                if (dgvMedicaments.Columns.Count >= 7)
                {
                    dgvMedicaments.Columns["Nom"].Width = 200;
                    dgvMedicaments.Columns["Reference"].Width = 150;
                    dgvMedicaments.Columns["Categorie"].Width = 150;
                    dgvMedicaments.Columns["Fabricant"].Width = 150;
                    dgvMedicaments.Columns["QuantiteTotale"].Width = 120;
                    // Make sure SeuilAlerteStock column is fully visible
                    dgvMedicaments.Columns["SeuilAlerteStock"].Width = 120;
                    dgvMedicaments.Columns["SeuilAlerteStock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvMedicaments.Columns["Statut"].Width = 220;
                }
            }
            catch
            {
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            RechercherAlertesStock();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            try
            {
                txtRechercherReference.Clear();
                RechercherAlertesStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la réinitialisation : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RechercherAlertesStock()
        {
            try
            {
                List<Medicament> tousLesMedicaments = pharmacien.ConsulterStockAlerte();
                string referenceRecherche = txtRechercherReference.Text.Trim();

                if (string.IsNullOrEmpty(referenceRecherche))
                {
                    medicamentsAlertes = tousLesMedicaments;
                }
                else
                {
                    medicamentsAlertes = tousLesMedicaments.Where(m =>
                        m.Reference != null && m.Reference.Contains(referenceRecherche, StringComparison.OrdinalIgnoreCase)
                    ).ToList();
                }

                AfficherMedicamentsAlertes();
                lblNombreAlertes.Text = $"Nombre de médicaments en alerte : {medicamentsAlertes.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherMedicamentsAlertes()
        {
            dgvMedicaments.Rows.Clear();

            foreach (var medicament in medicamentsAlertes)
            {
                string statut;
                Color couleurLigne;

                int difference = medicament.SeuilAlerteStock - medicament.QuantiteTotale;

                if (medicament.QuantiteTotale == 0)
                {
                    statut = "RUPTURE DE STOCK";
                    couleurLigne = Color.FromArgb(255, 150, 150);
                }
                else if (medicament.QuantiteTotale < medicament.SeuilAlerteStock)
                {
                    statut = $"Stock critique ({difference} unités en dessous du seuil)";
                    couleurLigne = Color.FromArgb(255, 200, 150);
                }
                else
                {
                    statut = $"Stock faible (proche du seuil)";
                    couleurLigne = Color.FromArgb(255, 240, 200);
                }

                int rowIndex = dgvMedicaments.Rows.Add(
                    medicament.Nom,
                    medicament.Reference,
                    medicament.Categorie ?? "N/A",
                    medicament.Fabricant ?? "N/A",
                    medicament.QuantiteTotale,
                    medicament.SeuilAlerteStock,
                    statut
                );

                dgvMedicaments.Rows[rowIndex].DefaultCellStyle.BackColor = couleurLigne;
            }

            // Sort by quantity (lowest first)
            if (dgvMedicaments.Columns.Count > 0 && dgvMedicaments.Rows.Count > 0)
            {
                dgvMedicaments.Sort(dgvMedicaments.Columns["QuantiteTotale"], ListSortDirection.Ascending);
            }

            // Ensure columns are properly configured after adding data
            ConfigurerDataGridView();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMenuPharmacien formMenuPharmacien = new FormMenuPharmacien();
            formMenuPharmacien.StartPosition = FormStartPosition.Manual;
            formMenuPharmacien.Location = this.Location;
            formMenuPharmacien.Show();
            this.Hide();
        }
    }
}

