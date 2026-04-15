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
            try
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtMotDePasse.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", 
                        "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Utilisateur utilisateur = Utilisateur.SeConnecter(txtNom.Text, txtMotDePasse.Text);

                if (utilisateur == null)
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", 
                        "Échec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMotDePasse.Clear();
                    txtNom.Focus();
                    return;
                }
                
                if (utilisateur.Role == "Pharmacien")
                {
                    Utilisateur.UtilisateurConnecte = utilisateur;
                    
                    FormMenuPharmacien menuPharmacien = new FormMenuPharmacien();
                    menuPharmacien.StartPosition = FormStartPosition.Manual;
                    menuPharmacien.Location = this.Location;
                    menuPharmacien.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Accès non autorisé. Seuls les pharmaciens peuvent se connecter.", 
                        "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue lors de la connexion : {ex.Message}", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
