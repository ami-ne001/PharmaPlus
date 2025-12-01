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
    public partial class FormMenuPharmacien : Form
    {
        public FormMenuPharmacien()
        {
            InitializeComponent();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Utilisateur.UtilisateurConnecte = null;
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.Show();
            this.Hide();
        }

        private void btnGererMedicaments_Click(object sender, EventArgs e)
        {
            FormGestionMedicaments formGestionMedicaments = new FormGestionMedicaments();
            formGestionMedicaments.Show();
            this.Hide();
        }

        private void btnGererLots_Click(object sender, EventArgs e)
        {
            FormGestionLots formGestionLots = new FormGestionLots();
            formGestionLots.Show();
            this.Hide();
        }

        private void btnAlertesPeremption_Click(object sender, EventArgs e)
        {
            FormAlertePeremption formAlertePeremption = new FormAlertePeremption();
            formAlertePeremption.Show();
            this.Hide();
        }

        private void btnAlertesStockes_Click(object sender, EventArgs e)
        {
            FormAlerteStockes formAlerteStockes = new FormAlerteStockes();
            formAlerteStockes.Show();
            this.Hide();
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            FormHistorique formHistorique = new FormHistorique();
            formHistorique.Show();
            this.Hide();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FormGestionClients formGestionClients = new FormGestionClients();
            formGestionClients.Show();
            this.Hide();
        }

        private void btnCommandes_Click(object sender, EventArgs e)
        {
            FormAjouterCommande formAjouterCommande = new FormAjouterCommande();
            formAjouterCommande.Show();
            this.Hide();
        }
    }
}
