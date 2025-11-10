namespace PharmaPlus
{
    partial class FormConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblLogo = new Label();
            pnlLogo = new Panel();
            lblDescription = new Label();
            lblBienvenue = new Label();
            panel2 = new Panel();
            lblMDPOublie = new Label();
            lblConnexion = new Label();
            btnAjouter = new Button();
            txtReference = new TextBox();
            lblMotDePasse = new Label();
            txtNom = new TextBox();
            lblNomUtilisateur = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 85, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblLogo);
            panel1.Controls.Add(pnlLogo);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblBienvenue);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 673);
            panel1.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = SystemColors.HighlightText;
            lblLogo.Location = new Point(75, 321);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(540, 51);
            lblLogo.TabIndex = 4;
            lblLogo.Text = "PharmaPlus\r\n";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            pnlLogo.BackgroundImage = Properties.Resources.PharmaPlus_logo;
            pnlLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLogo.Location = new Point(285, 211);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(120, 115);
            pnlLogo.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.HighlightText;
            lblDescription.Location = new Point(75, 432);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(540, 151);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Parcourez Notre Catalogue\nCommandez Facilement Vos Médicaments en Ligne\nProfitez d’une Livraison Sécurisée";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBienvenue
            // 
            lblBienvenue.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenue.ForeColor = SystemColors.HighlightText;
            lblBienvenue.Location = new Point(75, 97);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(540, 51);
            lblBienvenue.TabIndex = 0;
            lblBienvenue.Text = "Bienvenue sur";
            lblBienvenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblMDPOublie);
            panel2.Controls.Add(lblConnexion);
            panel2.Controls.Add(btnAjouter);
            panel2.Controls.Add(txtReference);
            panel2.Controls.Add(lblMotDePasse);
            panel2.Controls.Add(txtNom);
            panel2.Controls.Add(lblNomUtilisateur);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(702, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 673);
            panel2.TabIndex = 1;
            // 
            // lblMDPOublie
            // 
            lblMDPOublie.AutoSize = true;
            lblMDPOublie.Location = new Point(304, 488);
            lblMDPOublie.Name = "lblMDPOublie";
            lblMDPOublie.Size = new Size(151, 20);
            lblMDPOublie.TabIndex = 19;
            lblMDPOublie.Text = "Mot de passe oublié?";
            // 
            // lblConnexion
            // 
            lblConnexion.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConnexion.ForeColor = Color.FromArgb(0, 85, 70);
            lblConnexion.Location = new Point(145, 92);
            lblConnexion.Name = "lblConnexion";
            lblConnexion.Size = new Size(310, 51);
            lblConnexion.TabIndex = 18;
            lblConnexion.Text = "Connexion";
            lblConnexion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(0, 85, 70);
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Segoe UI", 12F);
            btnAjouter.ForeColor = SystemColors.HighlightText;
            btnAjouter.Location = new Point(145, 443);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(310, 42);
            btnAjouter.TabIndex = 13;
            btnAjouter.Text = "Se connecter";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // txtReference
            // 
            txtReference.Font = new Font("Segoe UI", 11F);
            txtReference.Location = new Point(145, 352);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(310, 32);
            txtReference.TabIndex = 17;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMotDePasse.Location = new Point(145, 321);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(124, 25);
            lblMotDePasse.TabIndex = 16;
            lblMotDePasse.Text = "Mot de passe";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Segoe UI", 11F);
            txtNom.Location = new Point(145, 254);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(310, 32);
            txtNom.TabIndex = 15;
            // 
            // lblNomUtilisateur
            // 
            lblNomUtilisateur.AutoSize = true;
            lblNomUtilisateur.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomUtilisateur.Location = new Point(145, 223);
            lblNomUtilisateur.Name = "lblNomUtilisateur";
            lblNomUtilisateur.Size = new Size(159, 25);
            lblNomUtilisateur.TabIndex = 14;
            lblNomUtilisateur.Text = "Nom d'utilisateur";
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormConnexion";
            Text = "PharmaPlus - Connexion";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnAjouter;
        private TextBox txtReference;
        private Label lblMotDePasse;
        private TextBox txtNom;
        private Label lblNomUtilisateur;
        private Label lblBienvenue;
        private Label lblDescription;
        private Panel pnlLogo;
        private Label lblLogo;
        private Label lblConnexion;
        private Label lblMDPOublie;
    }
}