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

        // ========== CHARGEMENT DES DONNÉES ==========
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
                // Trouver le nom du médicament
                string nomMedicament = ObtenirNomMedicament(lot.ID_Medicament);

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

        private string ObtenirNomMedicament(int idMedicament)
        {
            var med = listeMedicaments.FirstOrDefault(m => m.ID_Medicament == idMedicament);
            return med != null ? med.Nom : "Inconnu";
        }

        // ========== RECHERCHE PAR RÉFÉRENCE ==========
        private void btnRafraichirReference_Click(object sender, EventArgs e)
        {
            string reference = txtRechercherReference.Text.Trim();

            if (string.IsNullOrEmpty(reference))
            {
                MessageBox.Show("Veuillez entrer une référence.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var medicamentTrouve = listeMedicaments.FirstOrDefault(m =>
                m.Reference.Equals(reference, StringComparison.OrdinalIgnoreCase));

            if (medicamentTrouve != null)
            {
                // Sélectionner dans le ComboBox
                for (int i = 0; i < cmbMedicaments.Items.Count; i++)
                {
                    string item = cmbMedicaments.Items[i].ToString();
                    if (item.Contains($"[ID: {medicamentTrouve.ID_Medicament}]"))
                    {
                        cmbMedicaments.SelectedIndex = i;
                        break;
                    }
                }

                MessageBox.Show($"Médicament trouvé : {medicamentTrouve.Nom}",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun médicament trouvé avec cette référence.",
                    "Non trouvé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReinitialiserReference_Click(object sender, EventArgs e)
        {
            txtRechercherReference.Clear();
            cmbMedicaments.SelectedIndex = 0;
        }

        // ========== SÉLECTION MÉDICAMENT ==========
        private void cmbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicaments.SelectedIndex == 0)
            {
                // Tous les médicaments
                ChargerTousLesLots();
            }
            else
            {
                // Médicament spécifique
                string itemSelectionne = cmbMedicaments.SelectedItem.ToString();
                int debut = itemSelectionne.IndexOf("[ID: ") + 5;
                int fin = itemSelectionne.IndexOf("]");
                int idMedicament = int.Parse(itemSelectionne.Substring(debut, fin - debut));

                ChargerLotsParMedicament(idMedicament);
            }
        }

        // ========== RECHERCHE PAR NUMÉRO DE LOT ==========
        private void btnRafraichirNumeroLot_Click(object sender, EventArgs e)
        {
            string numeroLot = txtRechercherNumeroLot.Text.Trim();

            if (string.IsNullOrEmpty(numeroLot))
            {
                MessageBox.Show("Veuillez entrer un numéro de lot.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lotsFiltres = listeLots.Where(l =>
                l.NumeroLot.Contains(numeroLot, StringComparison.OrdinalIgnoreCase)).ToList();

            if (lotsFiltres.Count > 0)
            {
                AfficherLots(lotsFiltres);
                MessageBox.Show($"{lotsFiltres.Count} lot(s) trouvé(s).",
                    "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun lot trouvé avec ce numéro.",
                    "Non trouvé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReinitialiserNumeroLot_Click(object sender, EventArgs e)
        {
            txtRechercherNumeroLot.Clear();
            ChargerTousLesLots();
        }

        // ========== SÉLECTION DANS LE DATAGRIDVIEW ==========
        private void dgvMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicaments.Rows[e.RowIndex];

                lotSelectionneID = Convert.ToInt32(row.Cells["ID_Lot"].Value);
                txtID_Medicament.Text = row.Cells["ID_Medicament"].Value.ToString();
                txtNumeroLot.Text = row.Cells["NumeroLot"].Value.ToString();

                DateTime datePeremption = DateTime.ParseExact(
                    row.Cells["DatePeremption"].Value.ToString(),
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture);
                dtpDatePeremption.Value = datePeremption;

                nudPrix.Value = Convert.ToDecimal(row.Cells["Prix"].Value);
                nudQuantiteLot.Value = Convert.ToInt32(row.Cells["QuantiteLot"].Value);
            }
        }

        // ========== BOUTON RETOUR ==========
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ========== ÉVÉNEMENTS DE CHANGEMENT (optionnels) ==========
        private void txtID_Medicament_TextChanged(object sender, EventArgs e) { }
        private void txtNumeroLot_TextChanged(object sender, EventArgs e) { }
        private void dtpDatePeremption_ValueChanged(object sender, EventArgs e) { }
        private void nudPrix_ValueChanged(object sender, EventArgs e) { }
        private void nudQuantiteLot_ValueChanged(object sender, EventArgs e) { }

        // ========== CRUD OPERATIONS ==========
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtID_Medicament.Text))
                {
                    MessageBox.Show("Veuillez sélectionner un médicament ou entrer un ID médicament.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                // Création du lot
                LotMedicament nouveauLot = new LotMedicament
                {
                    ID_Medicament = int.Parse(txtID_Medicament.Text),
                    NumeroLot = txtNumeroLot.Text.Trim(),
                    DatePeremption = dtpDatePeremption.Value,
                    Prix = nudPrix.Value,
                    QuantiteLot = (int)nudQuantiteLot.Value
                };

                nouveauLot.InsererLot();

                // Mettre à jour la quantité totale du médicament
                Medicament med = new Medicament { ID_Medicament = nouveauLot.ID_Medicament };
                med.MettreAJourQuantiteTotale();

                MessageBox.Show("Lot ajouté avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                // Validation
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

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir modifier ce lot ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                // Modification du lot
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

                // Mettre à jour la quantité totale du médicament
                Medicament med = new Medicament { ID_Medicament = lotModifie.ID_Medicament };
                med.MettreAJourQuantiteTotale();

                MessageBox.Show("Lot modifié avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                DialogResult result = MessageBox.Show(
                    "Êtes-vous sûr de vouloir supprimer ce lot ?\nCette action est irréversible.",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;

                LotMedicament lotASupprimer = new LotMedicament
                {
                    ID_Lot = lotSelectionneID,
                    ID_Medicament = int.Parse(txtID_Medicament.Text)
                };

                lotASupprimer.SupprimerLot();

                MessageBox.Show("Lot supprimé avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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