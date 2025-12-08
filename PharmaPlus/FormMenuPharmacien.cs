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
            MettreAJourBienvenue();
        }

        private void MettreAJourBienvenue()
        {
            var user = Utilisateur.UtilisateurConnecte;
            if (user != null && !string.IsNullOrWhiteSpace(user.Nom))
            {
                lblBienvenue.Text = $"Bienvenue Dr. {user.Nom}";
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Utilisateur.UtilisateurConnecte = null;
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.StartPosition = FormStartPosition.Manual;
            formConnexion.Location = this.Location;
            formConnexion.Show();
            this.Hide();
        }

        private void btnGererMedicaments_Click(object sender, EventArgs e)
        {
            FormGestionMedicaments formGestionMedicaments = new FormGestionMedicaments();
            formGestionMedicaments.StartPosition = FormStartPosition.Manual;
            formGestionMedicaments.Location = this.Location;
            formGestionMedicaments.Show();
            this.Hide();
        }

        private void btnGererLots_Click(object sender, EventArgs e)
        {
            FormGestionLots formGestionLots = new FormGestionLots();
            formGestionLots.StartPosition = FormStartPosition.Manual;
            formGestionLots.Location = this.Location;
            formGestionLots.Show();
            this.Hide();
        }

        private void btnAlertesPeremption_Click(object sender, EventArgs e)
        {
            FormAlertePeremption formAlertePeremption = new FormAlertePeremption();
            formAlertePeremption.StartPosition = FormStartPosition.Manual;
            formAlertePeremption.Location = this.Location;
            formAlertePeremption.Show();
            this.Hide();
        }

        private void btnAlertesStockes_Click(object sender, EventArgs e)
        {
            FormAlerteStockes formAlerteStockes = new FormAlerteStockes();
            formAlerteStockes.StartPosition = FormStartPosition.Manual;
            formAlerteStockes.Location = this.Location;
            formAlerteStockes.Show();
            this.Hide();
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            FormHistorique formHistorique = new FormHistorique();
            formHistorique.StartPosition = FormStartPosition.Manual;
            formHistorique.Location = this.Location;
            formHistorique.Show();
            this.Hide();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FormGestionClients formGestionClients = new FormGestionClients();
            formGestionClients.StartPosition = FormStartPosition.Manual;
            formGestionClients.Location = this.Location;
            formGestionClients.Show();
            this.Hide();
        }

        private void btnCommandes_Click(object sender, EventArgs e)
        {
            FormAjouterCommande formAjouterCommande = new FormAjouterCommande();
            formAjouterCommande.StartPosition = FormStartPosition.Manual;
            formAjouterCommande.Location = this.Location;
            formAjouterCommande.Show();
            this.Hide();
        }

        private void btnFournisseurs_Click(object sender, EventArgs e)
        {
            FormFournisseurs formFournisseurs = new FormFournisseurs();
            formFournisseurs.StartPosition = FormStartPosition.Manual;
            formFournisseurs.Location = this.Location;
            formFournisseurs.Show();
            this.Hide();
        }

        private void btnFournisseursMedicaments_Click(object sender, EventArgs e)
        {
            FormFournisseursMedicaments formFournisseursMedicaments = new FormFournisseursMedicaments(this);
            formFournisseursMedicaments.StartPosition = FormStartPosition.Manual;
            formFournisseursMedicaments.Location = this.Location;
            formFournisseursMedicaments.Show();
            this.Hide();
        }

        private void btnHistoriqueCommandes_Click(object sender, EventArgs e)
        {
            FormConsulterCommandes formConsulterCommandes = new FormConsulterCommandes(this);
            formConsulterCommandes.StartPosition = FormStartPosition.Manual;
            formConsulterCommandes.Location = this.Location;
            formConsulterCommandes.Show();
            this.Hide();
        }
    }
}
