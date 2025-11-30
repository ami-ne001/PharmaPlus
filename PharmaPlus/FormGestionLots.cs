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
            ConfigurerDataGridView();
        }

        private void ConfigurerDataGridView()
        {
            try
            {
                // Configure column widths to ensure all columns are visible
                if (dgvMedicaments.Columns.Count >= 5)
                {
                    dgvMedicaments.Columns["Reference"].Width = 150;
                    dgvMedicaments.Columns["NumeroLot"].Width = 150;
                    dgvMedicaments.Columns["DatePeremption"].Width = 160;
                    dgvMedicaments.Columns["Prix"].Width = 120;
                    // Make sure Quantite column is fully visible
                    dgvMedicaments.Columns["QuantiteLot"].Width = 120;
                    dgvMedicaments.Columns["QuantiteLot"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
            }
            catch
            {
            }
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

            // Load all medications to get references
            List<Medicament> medicaments = Medicament.ListerMedicaments();

            foreach (var lot in lots)
            {
                var medicament = medicaments.FirstOrDefault(m => m.ID_Medicament == lot.ID_Medicament);
                string reference = medicament != null ? medicament.Reference : "N/A";

                dgvMedicaments.Rows.Add(
                    reference,
                    lot.NumeroLot,
                    lot.DatePeremption.ToString("dd/MM/yyyy"),
                    lot.Prix.ToString("0.00"),
                    lot.QuantiteLot
                );
            }

            // Ensure columns are properly configured after adding data
            ConfigurerDataGridView();
        }

        private void btnRafraichirReference_Click(object sender, EventArgs e)
        {
            try
            {
                string reference = txtRechercherReference.Text.Trim();

                if (string.IsNullOrEmpty(reference))
                {
                    MessageBox.Show("Veuillez entrer une référence à rechercher.", 
                        "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show($"Aucun médicament trouvé avec la référence '{reference}'.", 
                        "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                string numeroLot = txtRechercherNumeroLot.Text.Trim();

                if (string.IsNullOrEmpty(numeroLot))
                {
                    MessageBox.Show("Veuillez entrer un numéro de lot à rechercher.", 
                        "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lotsFiltres = listeLots.Where(l =>
                    l.NumeroLot.Contains(numeroLot, StringComparison.OrdinalIgnoreCase)).ToList();

                if (lotsFiltres.Count == 0)
                {
                    MessageBox.Show($"Aucun lot trouvé avec le numéro contenant '{numeroLot}'.", 
                        "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AfficherLots(lotsFiltres);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                SelectionnerLot(e.RowIndex);
            }
        }

        private void dgvMedicaments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicaments.SelectedRows.Count > 0)
            {
                SelectionnerLot(dgvMedicaments.SelectedRows[0].Index);
            }
        }

        private void SelectionnerLot(int rowIndex)
        {
            try
            {
                if (rowIndex >= 0 && rowIndex < dgvMedicaments.Rows.Count)
                {
                    DataGridViewRow row = dgvMedicaments.Rows[rowIndex];

                if (row.Cells["NumeroLot"].Value != null)
                {
                    // Find the lot by numero and reference to get the ID
                    string reference = row.Cells["Reference"].Value?.ToString() ?? "";
                    string numeroLot = row.Cells["NumeroLot"].Value?.ToString() ?? "";
                    
                    var medicament = listeMedicaments.FirstOrDefault(m => m.Reference == reference);
                    if (medicament != null)
                    {
                        var lot = listeLots.FirstOrDefault(l => l.ID_Medicament == medicament.ID_Medicament && l.NumeroLot == numeroLot);
                        if (lot != null)
                        {
                            lotSelectionneID = lot.ID_Lot;
                            txtID_Medicament.Text = medicament.ID_Medicament.ToString();
                        }
                    }
                    
                    txtNumeroLot.Text = numeroLot;

                        if (row.Cells["DatePeremption"].Value != null)
                        {
                            DateTime datePeremption = DateTime.ParseExact(row.Cells["DatePeremption"].Value.ToString(),
                                    "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                            dtpDatePeremption.Value = datePeremption;
                        }

                        if (row.Cells["Prix"].Value != null)
                        {
                            nudPrix.Value = Convert.ToDecimal(row.Cells["Prix"].Value);
                        }

                        if (row.Cells["QuantiteLot"].Value != null)
                        {
                            nudQuantiteLot.Value = Convert.ToInt32(row.Cells["QuantiteLot"].Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sélection du lot : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lot ajouté avec succès.", 
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Microsoft.Data.SqlClient.SqlException sqlEx)
            {
                // Check for unique constraint violation (duplicate lot number for same medication)
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show($"Un lot avec le numéro '{txtNumeroLot.Text}' existe déjà pour ce médicament.\nVeuillez utiliser un numéro de lot unique.", 
                        "Numéro de lot dupliqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumeroLot.Focus();
                    txtNumeroLot.SelectAll();
                }
                else
                {
                    MessageBox.Show($"Erreur lors de l'ajout du lot : {sqlEx.Message}", 
                        "Erreur base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                MessageBox.Show("Lot modifié avec succès.", 
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer ce lot ?", 
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                LotMedicament lotASupprimer = new LotMedicament
                {
                    ID_Lot = lotSelectionneID,
                    ID_Medicament = int.Parse(txtID_Medicament.Text)
                };

                lotASupprimer.SupprimerLot();

                ChargerTousLesLots();
                EffacerChamps();
                MessageBox.Show("Lot supprimé avec succès.", 
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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