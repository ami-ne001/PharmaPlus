using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PharmaPlus
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtMotDePasse.Text))
            {
                return;
            }

            Utilisateur utilisateur = Utilisateur.SeConnecter(txtNom.Text, txtMotDePasse.Text);

            if (utilisateur == null)
            {
                return;
            }
            
            if (utilisateur.Role == "Pharmacien")
            {
                FormMenuPharmacien menuPharmacien = new FormMenuPharmacien();
                menuPharmacien.Show();
                this.Hide();
            }
            else
            {
                //Form utilisateur normal
            }
        }
    }
}
