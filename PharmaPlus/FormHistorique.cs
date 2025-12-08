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
    public partial class FormHistorique : Form
    {
        private Pharmacien pharmacien;
        private List<string> historique;

        public FormHistorique()
        {
            InitializeComponent();
        }

        private void FormHistorique_Load(object sender, EventArgs e)
        {
            pharmacien = new Pharmacien();
            ConfigurerDataGridView();
            ChargerHistorique();
        }

        private void ConfigurerDataGridView()
        {
            try
            {
                // Configure column widths to ensure all columns are visible
                if (dgvHistorique.Columns.Count >= 2)
                {
                    dgvHistorique.Columns["DateHeure"].Width = 180;
                    dgvHistorique.Columns["Action"].Width = dgvHistorique.Width - 200;
                    dgvHistorique.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch
            {
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            ChargerHistorique();
        }

        private void ChargerHistorique()
        {
            try
            {
                historique = Pharmacien.ConsulterHistorique();
                AfficherHistorique();
                lblNombreActions.Text = $"Nombre total d'actions : {historique.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement de l'historique : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherHistorique()
        {
            dgvHistorique.Rows.Clear();

            foreach (var ligne in historique)
            {
                // Parse the line: "dd/MM/yyyy HH:mm - [User] Action"
                string[] parts = ligne.Split(new[] { " - " }, 2, StringSplitOptions.None);
                string dateHeure = parts.Length > 0 ? parts[0] : "";
                string action = parts.Length > 1 ? parts[1] : ligne;

                dgvHistorique.Rows.Add(dateHeure, action);
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

