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
    public partial class FormGestionLots : Form
    {
        private List<Medicament> listeMedicaments;
        private List<LotMedicament> listeLots;
        private int lotSelectionneID = -1;

        public FormGestionLots()
        {
            InitializeComponent();
        }

        private void FormGestionLots_Load(object sender, EventArgs e)
        {
            ChargerMedicaments();
            ChargerTousLesLots();
        }

        private void ChargerMedicaments()
        {
            try
            {
                listeMedicaments = Medicament.ListerMedicaments();
                cmbMedicaments.Items.Clear();
                cmbMedicaments.Items.Add("-- Tous les médicaments --");

                foreach (var med in listeMedicaments)
                {
                    cmbMedicaments.Items.Add($"[ID: {med.ID_Medicament}] {med.Nom} - {med.Reference}");
                }

                cmbMedicaments.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des médicaments : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerTousLesLots()
        {
            try
            {
                listeLots = LotMedicament.ListerTousLesLots();
                AfficherLots(listeLots);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des lots : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerLotsParMedicament(int idMedicament)
        {
            try
            {
                listeLots = LotMedicament.ListerLotsParMedicament(idMedicament);
                AfficherLots(listeLots);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des lots : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherLots(List<LotMedicament> lots)
        {
            dgvMedicaments.Rows.Clear();

            foreach (var lot in lots)
            {
                dgvMedicaments.Rows.Add(
                    lot.ID_Medicament,
                    lot.ID_Lot,
                    lot.NumeroLot,
                    lot.DatePeremption.ToString("dd/MM/yyyy"),
                    lot.Prix.ToString("0.00"),
                    lot.QuantiteLot
                );
            }
        }

        private void btnRafraichirReference_Click(object sender, EventArgs e)
        {
            string reference = txtRechercherReference.Text.Trim();

            if (string.IsNullOrEmpty(reference))
            {
                return;
            }

            var medicamentTrouve = listeMedicaments.FirstOrDefault(m =>
                m.Reference.Equals(reference, StringComparison.OrdinalIgnoreCase));

            if (medicamentTrouve != null)
            {
                for (int i = 0; i < cmbMedicaments.Items.Count; i++)
                {
                    string item = cmbMedicaments.Items[i].ToString();
                    if (item.Contains($"[ID: {medicamentTrouve.ID_Medicament}]"))
                    {
                        cmbMedicaments.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnReinitialiserReference_Click(object sender, EventArgs e)
        {
            txtRechercherReference.Clear();
            cmbMedicaments.SelectedIndex = 0;
        }

        private void cmbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicaments.SelectedIndex == 0)
            {
                ChargerTousLesLots();
            }
            else
            {
                string itemSelectionne = cmbMedicaments.SelectedItem.ToString();
                int debut = itemSelectionne.IndexOf("[ID: ") + 5;
                int fin = itemSelectionne.IndexOf("]");
                int idMedicament = int.Parse(itemSelectionne.Substring(debut, fin - debut));

                ChargerLotsParMedicament(idMedicament);
            }
        }

        private void btnRafraichirNumeroLot_Click(object sender, EventArgs e)
        {
            string numeroLot = txtRechercherNumeroLot.Text.Trim();

            if (string.IsNullOrEmpty(numeroLot))
            {
                return;
            }

            var lotsFiltres = listeLots.Where(l =>
                l.NumeroLot.Contains(numeroLot, StringComparison.OrdinalIgnoreCase)).ToList();

        }

        private void btnReinitialiserNumeroLot_Click(object sender, EventArgs e)
        {
            txtRechercherNumeroLot.Clear();
            ChargerTousLesLots();
        }

        private void dgvMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicaments.Rows[e.RowIndex];

                lotSelectionneID = Convert.ToInt32(row.Cells["ID_Lot"].Value);
                txtID_Medicament.Text = row.Cells["ID_Medicament"].Value.ToString();
                txtNumeroLot.Text = row.Cells["NumeroLot"].Value.ToString();

                DateTime datePeremption = DateTime.ParseExact(row.Cells["DatePeremption"].Value.ToString(),
                        "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                dtpDatePeremption.Value = datePeremption;

                nudPrix.Value = Convert.ToDecimal(row.Cells["Prix"].Value);
                nudQuantiteLot.Value = Convert.ToInt32(row.Cells["QuantiteLot"].Value);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormMenuPharmacien menuPharmacien = new FormMenuPharmacien();
            menuPharmacien.Show();
            this.Hide();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID_Medicament.Text))
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNumeroLot.Text))
                {
                    MessageBox.Show("Le numéro de lot est obligatoire.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumeroLot.Focus();
                    return;
                }

                if (dtpDatePeremption.Value <= DateTime.Now)
                {
                    DialogResult result = MessageBox.Show(
                        "La date de péremption est passée ou aujourd'hui. Voulez-vous continuer ?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                        return;
                }

                if (nudPrix.Value <= 0)
                {
                    MessageBox.Show("Le prix doit être supérieur à 0.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LotMedicament nouveauLot = new LotMedicament
                {
                    ID_Medicament = int.Parse(txtID_Medicament.Text),
                    NumeroLot = txtNumeroLot.Text.Trim(),
                    DatePeremption = dtpDatePeremption.Value,
                    Prix = nudPrix.Value,
                    QuantiteLot = (int)nudQuantiteLot.Value
                };

                nouveauLot.InsererLot();

                Medicament med = new Medicament { ID_Medicament = nouveauLot.ID_Medicament };
                med.MettreAJourQuantiteTotale();

                ChargerTousLesLots();
                EffacerChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du lot : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (lotSelectionneID == -1)
                {
                    MessageBox.Show("Veuillez sélectionner un lot à modifier.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNumeroLot.Text))
                {
                    MessageBox.Show("Le numéro de lot est obligatoire.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nudPrix.Value <= 0)
                {
                    MessageBox.Show("Le prix doit être supérieur à 0.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LotMedicament lotModifie = new LotMedicament
                {
                    ID_Lot = lotSelectionneID,
                    ID_Medicament = int.Parse(txtID_Medicament.Text),
                    NumeroLot = txtNumeroLot.Text.Trim(),
                    DatePeremption = dtpDatePeremption.Value,
                    Prix = nudPrix.Value,
                    QuantiteLot = (int)nudQuantiteLot.Value
                };

                lotModifie.MettreAJourLot();

                Medicament med = new Medicament { ID_Medicament = lotModifie.ID_Medicament };
                med.MettreAJourQuantiteTotale();

                ChargerTousLesLots();
                EffacerChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification du lot : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (lotSelectionneID == -1)
                {
                    MessageBox.Show("Veuillez sélectionner un lot à supprimer.",
                        "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LotMedicament lotASupprimer = new LotMedicament
                {
                    ID_Lot = lotSelectionneID,
                    ID_Medicament = int.Parse(txtID_Medicament.Text)
                };

                lotASupprimer.SupprimerLot();

                ChargerTousLesLots();
                EffacerChamps();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du lot : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            EffacerChamps();
        }

        private void EffacerChamps()
        {
            lotSelectionneID = -1;
            txtID_Medicament.Clear();
            txtNumeroLot.Clear();
            dtpDatePeremption.Value = DateTime.Now;
            nudPrix.Value = 0;
            nudQuantiteLot.Value = 1;

            if (dgvMedicaments.SelectedRows.Count > 0)
            {
                dgvMedicaments.ClearSelection();
            }
        }
    }
}