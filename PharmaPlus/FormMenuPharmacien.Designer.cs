namespace PharmaPlus
{
    partial class FormMenuPharmacien
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
            btnDeconnexion = new Button();
            lblBienvenue = new Label();
            lblEspace = new Label();
            lblLogo = new Label();
            pnlLogo = new Panel();
            lblDescription = new Label();
            btnGererMedicaments = new Button();
            btnGererLots = new Button();
            btnAlertesPeremption = new Button();
            btnAlertesStockes = new Button();
            btnHistorique = new Button();
            grpGestion = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            grpAlertes = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            grpHistorique = new GroupBox();
            label10 = new Label();
            btnHistoriqueCommandes = new Button();
            label5 = new Label();
            lblConnexion = new Label();
            grpClients = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            btnClients = new Button();
            btnCommandes = new Button();
            grpFournisseurs = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            btnFournisseurs = new Button();
            btnFournisseursMedicaments = new Button();
            panel1.SuspendLayout();
            grpGestion.SuspendLayout();
            grpAlertes.SuspendLayout();
            grpHistorique.SuspendLayout();
            grpClients.SuspendLayout();
            grpFournisseurs.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 85, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDeconnexion);
            panel1.Controls.Add(lblBienvenue);
            panel1.Controls.Add(lblEspace);
            panel1.Controls.Add(lblLogo);
            panel1.Controls.Add(pnlLogo);
            panel1.Controls.Add(lblDescription);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 673);
            panel1.TabIndex = 1;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = SystemColors.Control;
            btnDeconnexion.FlatStyle = FlatStyle.Popup;
            btnDeconnexion.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeconnexion.Location = new Point(195, 608);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(194, 39);
            btnDeconnexion.TabIndex = 20;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // lblBienvenue
            // 
            lblBienvenue.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenue.ForeColor = SystemColors.HighlightText;
            lblBienvenue.Location = new Point(22, 256);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(540, 64);
            lblBienvenue.TabIndex = 6;
            lblBienvenue.Text = "Bienvenue Dr. [Nom Prénom]";
            lblBienvenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEspace
            // 
            lblEspace.Font = new Font("Segoe UI", 15F);
            lblEspace.ForeColor = SystemColors.HighlightText;
            lblEspace.Location = new Point(22, 312);
            lblEspace.Name = "lblEspace";
            lblEspace.Size = new Size(540, 44);
            lblEspace.TabIndex = 5;
            lblEspace.Text = "Espace Pharmacien";
            lblEspace.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = SystemColors.HighlightText;
            lblLogo.Location = new Point(22, 146);
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
            pnlLogo.Location = new Point(232, 36);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(120, 115);
            pnlLogo.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.FromArgb(0, 85, 70);
            lblDescription.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.HighlightText;
            lblDescription.Location = new Point(22, 469);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(540, 93);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "\" Gérez Efficacement Votre Pharmacie\net Offrez le Meilleur Service à Vos Clients \"";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGererMedicaments
            // 
            btnGererMedicaments.BackColor = Color.FromArgb(0, 85, 70);
            btnGererMedicaments.FlatStyle = FlatStyle.Popup;
            btnGererMedicaments.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGererMedicaments.ForeColor = SystemColors.HighlightText;
            btnGererMedicaments.Location = new Point(10, 29);
            btnGererMedicaments.Name = "btnGererMedicaments";
            btnGererMedicaments.Size = new Size(298, 38);
            btnGererMedicaments.TabIndex = 2;
            btnGererMedicaments.Text = "Gérer les Médicaments";
            btnGererMedicaments.UseVisualStyleBackColor = false;
            btnGererMedicaments.Click += btnGererMedicaments_Click;
            // 
            // btnGererLots
            // 
            btnGererLots.BackColor = Color.FromArgb(0, 85, 70);
            btnGererLots.FlatStyle = FlatStyle.Popup;
            btnGererLots.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGererLots.ForeColor = SystemColors.HighlightText;
            btnGererLots.Location = new Point(342, 29);
            btnGererLots.Name = "btnGererLots";
            btnGererLots.Size = new Size(298, 38);
            btnGererLots.TabIndex = 3;
            btnGererLots.Text = "Gérer les Lots";
            btnGererLots.UseVisualStyleBackColor = false;
            btnGererLots.Click += btnGererLots_Click;
            // 
            // btnAlertesPeremption
            // 
            btnAlertesPeremption.BackColor = Color.FromArgb(0, 85, 70);
            btnAlertesPeremption.FlatStyle = FlatStyle.Popup;
            btnAlertesPeremption.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAlertesPeremption.ForeColor = SystemColors.HighlightText;
            btnAlertesPeremption.Location = new Point(342, 29);
            btnAlertesPeremption.Name = "btnAlertesPeremption";
            btnAlertesPeremption.Size = new Size(298, 38);
            btnAlertesPeremption.TabIndex = 5;
            btnAlertesPeremption.Text = "Alertes Péremption";
            btnAlertesPeremption.UseVisualStyleBackColor = false;
            btnAlertesPeremption.Click += btnAlertesPeremption_Click;
            // 
            // btnAlertesStockes
            // 
            btnAlertesStockes.BackColor = Color.FromArgb(0, 85, 70);
            btnAlertesStockes.FlatStyle = FlatStyle.Popup;
            btnAlertesStockes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAlertesStockes.ForeColor = SystemColors.HighlightText;
            btnAlertesStockes.Location = new Point(10, 29);
            btnAlertesStockes.Name = "btnAlertesStockes";
            btnAlertesStockes.Size = new Size(298, 38);
            btnAlertesStockes.TabIndex = 4;
            btnAlertesStockes.Text = "Alertes Stockes";
            btnAlertesStockes.UseVisualStyleBackColor = false;
            btnAlertesStockes.Click += btnAlertesStockes_Click;
            // 
            // btnHistorique
            // 
            btnHistorique.BackColor = Color.FromArgb(0, 85, 70);
            btnHistorique.FlatStyle = FlatStyle.Popup;
            btnHistorique.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnHistorique.ForeColor = SystemColors.HighlightText;
            btnHistorique.Location = new Point(10, 29);
            btnHistorique.Name = "btnHistorique";
            btnHistorique.Size = new Size(298, 38);
            btnHistorique.TabIndex = 6;
            btnHistorique.Text = "Consulter l'Historique";
            btnHistorique.UseVisualStyleBackColor = false;
            btnHistorique.Click += btnHistorique_Click;
            // 
            // grpGestion
            // 
            grpGestion.Controls.Add(label2);
            grpGestion.Controls.Add(label1);
            grpGestion.Controls.Add(btnGererLots);
            grpGestion.Controls.Add(btnGererMedicaments);
            grpGestion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            grpGestion.Location = new Point(601, 58);
            grpGestion.Name = "grpGestion";
            grpGestion.Size = new Size(650, 120);
            grpGestion.TabIndex = 7;
            grpGestion.TabStop = false;
            grpGestion.Text = "Gestion des Médicaments";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(342, 70);
            label2.Name = "label2";
            label2.Size = new Size(259, 40);
            label2.TabIndex = 11;
            label2.Text = "Gérer les lots de médicaments, prix et dates de péremption";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(10, 70);
            label1.Name = "label1";
            label1.Size = new Size(259, 40);
            label1.TabIndex = 10;
            label1.Text = "Ajouter, modifier ou supprimer des médicaments du catalogue";
            // 
            // grpAlertes
            // 
            grpAlertes.Controls.Add(label4);
            grpAlertes.Controls.Add(label3);
            grpAlertes.Controls.Add(btnAlertesStockes);
            grpAlertes.Controls.Add(btnAlertesPeremption);
            grpAlertes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            grpAlertes.Location = new Point(601, 180);
            grpAlertes.Name = "grpAlertes";
            grpAlertes.Size = new Size(650, 120);
            grpAlertes.TabIndex = 8;
            grpAlertes.TabStop = false;
            grpAlertes.Text = "Alertes et Notifications";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(342, 70);
            label4.Name = "label4";
            label4.Size = new Size(259, 40);
            label4.TabIndex = 12;
            label4.Text = "Voir les lots périmés ou proches de la péremption";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(10, 70);
            label3.Name = "label3";
            label3.Size = new Size(259, 40);
            label3.TabIndex = 11;
            label3.Text = "Consulter les médicaments avec stock insuffisant";
            // 
            // grpHistorique
            // 
            grpHistorique.Controls.Add(label10);
            grpHistorique.Controls.Add(btnHistoriqueCommandes);
            grpHistorique.Controls.Add(label5);
            grpHistorique.Controls.Add(btnHistorique);
            grpHistorique.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            grpHistorique.Location = new Point(601, 546);
            grpHistorique.Name = "grpHistorique";
            grpHistorique.Size = new Size(650, 120);
            grpHistorique.TabIndex = 9;
            grpHistorique.TabStop = false;
            grpHistorique.Text = "Suivi et Historique";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(342, 70);
            label10.Name = "label10";
            label10.Size = new Size(259, 40);
            label10.TabIndex = 14;
            label10.Text = "Voir toutes les commandes effectuées sur le système";
            // 
            // btnHistoriqueCommandes
            // 
            btnHistoriqueCommandes.BackColor = Color.FromArgb(0, 85, 70);
            btnHistoriqueCommandes.FlatStyle = FlatStyle.Popup;
            btnHistoriqueCommandes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnHistoriqueCommandes.ForeColor = SystemColors.HighlightText;
            btnHistoriqueCommandes.Location = new Point(342, 29);
            btnHistoriqueCommandes.Name = "btnHistoriqueCommandes";
            btnHistoriqueCommandes.Size = new Size(298, 38);
            btnHistoriqueCommandes.TabIndex = 13;
            btnHistoriqueCommandes.Text = "Consulter les Commandes";
            btnHistoriqueCommandes.UseVisualStyleBackColor = false;
            btnHistoriqueCommandes.Click += btnHistoriqueCommandes_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(10, 70);
            label5.Name = "label5";
            label5.Size = new Size(259, 40);
            label5.TabIndex = 12;
            label5.Text = "Voir toutes les actions effectuées sur le système";
            // 
            // lblConnexion
            // 
            lblConnexion.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConnexion.ForeColor = Color.FromArgb(0, 85, 70);
            lblConnexion.Location = new Point(601, 3);
            lblConnexion.Name = "lblConnexion";
            lblConnexion.Size = new Size(650, 51);
            lblConnexion.TabIndex = 19;
            lblConnexion.Text = "Tableu de Bord";
            lblConnexion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpClients
            // 
            grpClients.Controls.Add(label6);
            grpClients.Controls.Add(label7);
            grpClients.Controls.Add(btnClients);
            grpClients.Controls.Add(btnCommandes);
            grpClients.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            grpClients.Location = new Point(601, 302);
            grpClients.Name = "grpClients";
            grpClients.Size = new Size(650, 120);
            grpClients.TabIndex = 13;
            grpClients.TabStop = false;
            grpClients.Text = "Clients et Commandes";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(342, 70);
            label6.Name = "label6";
            label6.Size = new Size(259, 40);
            label6.TabIndex = 12;
            label6.Text = "Ajouter des nouvelles commandes";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(10, 70);
            label7.Name = "label7";
            label7.Size = new Size(259, 40);
            label7.TabIndex = 11;
            label7.Text = "Ajouter, modifier ou supprimer des clients au système";
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.FromArgb(0, 85, 70);
            btnClients.FlatStyle = FlatStyle.Popup;
            btnClients.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnClients.ForeColor = SystemColors.HighlightText;
            btnClients.Location = new Point(10, 29);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(298, 38);
            btnClients.TabIndex = 4;
            btnClients.Text = "Gérer les Clients";
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += btnClients_Click;
            // 
            // btnCommandes
            // 
            btnCommandes.BackColor = Color.FromArgb(0, 85, 70);
            btnCommandes.FlatStyle = FlatStyle.Popup;
            btnCommandes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCommandes.ForeColor = SystemColors.HighlightText;
            btnCommandes.Location = new Point(342, 29);
            btnCommandes.Name = "btnCommandes";
            btnCommandes.Size = new Size(298, 38);
            btnCommandes.TabIndex = 5;
            btnCommandes.Text = "Ajouter des Commandes";
            btnCommandes.UseVisualStyleBackColor = false;
            btnCommandes.Click += btnCommandes_Click;
            // 
            // grpFournisseurs
            // 
            grpFournisseurs.Controls.Add(label8);
            grpFournisseurs.Controls.Add(label9);
            grpFournisseurs.Controls.Add(btnFournisseurs);
            grpFournisseurs.Controls.Add(btnFournisseursMedicaments);
            grpFournisseurs.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            grpFournisseurs.Location = new Point(601, 424);
            grpFournisseurs.Name = "grpFournisseurs";
            grpFournisseurs.Size = new Size(650, 120);
            grpFournisseurs.TabIndex = 14;
            grpFournisseurs.TabStop = false;
            grpFournisseurs.Text = "Fourisseurs";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(342, 70);
            label8.Name = "label8";
            label8.Size = new Size(259, 40);
            label8.TabIndex = 12;
            label8.Text = "Gérer l’attribution des médicaments aux fournisseurs";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(10, 70);
            label9.Name = "label9";
            label9.Size = new Size(259, 40);
            label9.TabIndex = 11;
            label9.Text = "Ajouter, modifier ou supprimer des fournisseurs au système";
            // 
            // btnFournisseurs
            // 
            btnFournisseurs.BackColor = Color.FromArgb(0, 85, 70);
            btnFournisseurs.FlatStyle = FlatStyle.Popup;
            btnFournisseurs.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnFournisseurs.ForeColor = SystemColors.HighlightText;
            btnFournisseurs.Location = new Point(10, 29);
            btnFournisseurs.Name = "btnFournisseurs";
            btnFournisseurs.Size = new Size(298, 38);
            btnFournisseurs.TabIndex = 4;
            btnFournisseurs.Text = "Gérer les Fournisseurs";
            btnFournisseurs.UseVisualStyleBackColor = false;
            btnFournisseurs.Click += btnFournisseurs_Click;
            // 
            // btnFournisseursMedicaments
            // 
            btnFournisseursMedicaments.BackColor = Color.FromArgb(0, 85, 70);
            btnFournisseursMedicaments.FlatStyle = FlatStyle.Popup;
            btnFournisseursMedicaments.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnFournisseursMedicaments.ForeColor = SystemColors.HighlightText;
            btnFournisseursMedicaments.Location = new Point(342, 29);
            btnFournisseursMedicaments.Name = "btnFournisseursMedicaments";
            btnFournisseursMedicaments.Size = new Size(298, 38);
            btnFournisseursMedicaments.TabIndex = 5;
            btnFournisseursMedicaments.Text = "Gérer fournisseur–médicament";
            btnFournisseursMedicaments.UseVisualStyleBackColor = false;
            btnFournisseursMedicaments.Click += btnFournisseursMedicaments_Click;
            // 
            // FormMenuPharmacien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(grpFournisseurs);
            Controls.Add(grpClients);
            Controls.Add(lblConnexion);
            Controls.Add(grpHistorique);
            Controls.Add(grpAlertes);
            Controls.Add(grpGestion);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenuPharmacien";
            Text = "PharmaPlus - Tableau de Bord Pharmacien";
            panel1.ResumeLayout(false);
            grpGestion.ResumeLayout(false);
            grpAlertes.ResumeLayout(false);
            grpHistorique.ResumeLayout(false);
            grpClients.ResumeLayout(false);
            grpFournisseurs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblLogo;
        private Panel pnlLogo;
        private Label lblDescription;
        private Label lblEspace;
        private Label lblBienvenue;
        private Button btnGererMedicaments;
        private Button btnGererLots;
        private Button btnAlertesPeremption;
        private Button btnAlertesStockes;
        private Button btnHistorique;
        private GroupBox grpGestion;
        private GroupBox grpAlertes;
        private GroupBox grpHistorique;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button btnDeconnexion;
        private Label lblConnexion;
        private GroupBox grpClients;
        private Label label6;
        private Label label7;
        private Button btnClients;
        private Button btnCommandes;
        private GroupBox grpFournisseurs;
        private Label label8;
        private Label label9;
        private Button btnFournisseurs;
        private Button btnFournisseursMedicaments;
        private Label label10;
        private Button btnHistoriqueCommandes;
    }
}