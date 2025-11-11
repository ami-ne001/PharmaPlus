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
            ChargerMedicaments();
            ConfigurerDataGridView();
            ViderChamps();
        }

        private void ChargerMedicaments()
        {
            medicamentsList = Medicament.ListerMedicaments();
            dgvMedicaments.DataSource = null;
            dgvMedicaments.DataSource = medicamentsList;
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            FiltrerMedicaments();
        }

        private void FiltrerMedicaments()
        {
            string recherche = textBox2.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(recherche))
            {
                ChargerMedicaments();
                return;
            }

            var medicamentsFiltres = medicamentsList.Where(m =>
                m.Nom.ToLower().Contains(recherche) || m.Reference.ToLower().Contains(recherche) ||
                m.Categorie.ToLower().Contains(recherche) || m.Fabricant.ToLower().Contains(recherche)
            ).ToList();

            dgvMedicaments.DataSource = null;
            dgvMedicaments.DataSource = medicamentsFiltres;
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
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID_Medicament",
                Width = 80
            });

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
                Name = "Seuili",
                HeaderText = "Seuil",
                DataPropertyName = "SeuilAlerteStock",
                Width = 105
            });
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps())
                return;

            Medicament nouveauMedicament = RecupererMedicament();
            pharmacien.AjouterMedicament(nouveauMedicament);
            ChargerMedicaments();
            ViderChamps();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!selectedMedicamentId.HasValue)
                return;
            MessageBox.Show(Convert.ToString(selectedMedicamentId.Value));

            if (!ValiderChamps())
                return;

            Medicament medicamentModifie = RecupererMedicament();
            medicamentModifie.ID_Medicament = selectedMedicamentId.Value;

            pharmacien.ModifierMedicament(medicamentModifie);
            ChargerMedicaments();
            ViderChamps();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!selectedMedicamentId.HasValue)
                return;

            Medicament medicamentASupprimer = new Medicament
            {
                ID_Medicament = selectedMedicamentId.Value
            };

            pharmacien.SupprimerMedicament(medicamentASupprimer);
            ChargerMedicaments();
            ViderChamps();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            ViderChamps();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMenuPharmacien form = new FormMenuPharmacien();
            this.Hide();
            form.Show();
        }
    }
}
