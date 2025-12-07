namespace PharmaPlus
{
    partial class FormFournisseurs
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnRetour = new Button();
            panel1 = new Panel();
            btnReinitialiserRecherche = new Button();
            btnRafraichir = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            dgvFournisseurs = new DataGridView();
            txtCodeFournisseur = new TextBox();
            label0 = new Label();
            lblGestionFournisseurs = new Label();
            btnEffacer = new Button();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            txtAdresse = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelephone = new TextBox();
            label2 = new Label();
            txtNom = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFournisseurs).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(0, 85, 70);
            btnRetour.FlatStyle = FlatStyle.Popup;
            btnRetour.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetour.ForeColor = SystemColors.HighlightText;
            btnRetour.Location = new Point(5, 5);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(105, 29);
            btnRetour.TabIndex = 26;
            btnRetour.Text = "< Retour";
            btnRetour.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRetour);
            panel1.Controls.Add(btnReinitialiserRecherche);
            panel1.Controls.Add(btnRafraichir);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dgvFournisseurs);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 673);
            panel1.TabIndex = 3;
            // 
            // btnReinitialiserRecherche
            // 
            btnReinitialiserRecherche.BackColor = Color.FromArgb(0, 85, 70);
            btnReinitialiserRecherche.FlatStyle = FlatStyle.Popup;
            btnReinitialiserRecherche.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReinitialiserRecherche.ForeColor = SystemColors.HighlightText;
            btnReinitialiserRecherche.Location = new Point(790, 49);
            btnReinitialiserRecherche.Name = "btnReinitialiserRecherche";
            btnReinitialiserRecherche.Size = new Size(120, 29);
            btnReinitialiserRecherche.TabIndex = 27;
            btnReinitialiserRecherche.Text = "Réinitialiser";
            btnReinitialiserRecherche.UseVisualStyleBackColor = false;
            // 
            // btnRafraichir
            // 
            btnRafraichir.BackColor = Color.FromArgb(0, 85, 70);
            btnRafraichir.FlatStyle = FlatStyle.Popup;
            btnRafraichir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRafraichir.ForeColor = SystemColors.HighlightText;
            btnRafraichir.Location = new Point(664, 49);
            btnRafraichir.Name = "btnRafraichir";
            btnRafraichir.Size = new Size(120, 29);
            btnRafraichir.TabIndex = 25;
            btnRafraichir.Text = "Rafraîchir";
            btnRafraichir.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(208, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(412, 30);
            textBox2.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 52);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 23;
            label6.Text = "Rechercher";
            // 
            // dgvFournisseurs
            // 
            dgvFournisseurs.AllowUserToAddRows = false;
            dgvFournisseurs.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 85, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFournisseurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFournisseurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFournisseurs.EnableHeadersVisualStyles = false;
            dgvFournisseurs.Location = new Point(37, 103);
            dgvFournisseurs.MultiSelect = false;
            dgvFournisseurs.Name = "dgvFournisseurs";
            dgvFournisseurs.ReadOnly = true;
            dgvFournisseurs.RowHeadersWidth = 51;
            dgvFournisseurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFournisseurs.Size = new Size(873, 557);
            dgvFournisseurs.TabIndex = 23;
            // 
            // txtCodeFournisseur
            // 
            txtCodeFournisseur.Font = new Font("Segoe UI", 11F);
            txtCodeFournisseur.Location = new Point(24, 157);
            txtCodeFournisseur.Name = "txtCodeFournisseur";
            txtCodeFournisseur.Size = new Size(273, 32);
            txtCodeFournisseur.TabIndex = 37;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label0.Location = new Point(24, 129);
            label0.Name = "label0";
            label0.Size = new Size(143, 23);
            label0.TabIndex = 36;
            label0.Text = "Code Fournisseur";
            // 
            // lblGestionFournisseurs
            // 
            lblGestionFournisseurs.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionFournisseurs.ForeColor = Color.FromArgb(0, 85, 70);
            lblGestionFournisseurs.Location = new Point(24, 19);
            lblGestionFournisseurs.Name = "lblGestionFournisseurs";
            lblGestionFournisseurs.Size = new Size(273, 78);
            lblGestionFournisseurs.TabIndex = 35;
            lblGestionFournisseurs.Text = "Gestion des Fournisseurs";
            lblGestionFournisseurs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEffacer
            // 
            btnEffacer.BackColor = Color.FromArgb(0, 85, 70);
            btnEffacer.FlatStyle = FlatStyle.Popup;
            btnEffacer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEffacer.ForeColor = SystemColors.HighlightText;
            btnEffacer.Location = new Point(166, 597);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(131, 35);
            btnEffacer.TabIndex = 22;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.FromArgb(0, 85, 70);
            btnSupprimer.FlatStyle = FlatStyle.Popup;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.ForeColor = SystemColors.HighlightText;
            btnSupprimer.Location = new Point(24, 597);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(131, 35);
            btnSupprimer.TabIndex = 21;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.FromArgb(0, 85, 70);
            btnModifier.FlatStyle = FlatStyle.Popup;
            btnModifier.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.ForeColor = SystemColors.HighlightText;
            btnModifier.Location = new Point(166, 548);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(131, 35);
            btnModifier.TabIndex = 20;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(0, 85, 70);
            btnAjouter.FlatStyle = FlatStyle.Popup;
            btnAjouter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.ForeColor = SystemColors.HighlightText;
            btnAjouter.Location = new Point(24, 548);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(131, 35);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // txtAdresse
            // 
            txtAdresse.Font = new Font("Segoe UI", 11F);
            txtAdresse.Location = new Point(24, 468);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(273, 32);
            txtAdresse.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 440);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 15;
            label4.Text = "Adresse";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(24, 392);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 32);
            txtEmail.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 364);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // txtTelephone
            // 
            txtTelephone.Font = new Font("Segoe UI", 11F);
            txtTelephone.Location = new Point(24, 309);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(273, 32);
            txtTelephone.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 281);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 11;
            label2.Text = "Télephone";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Segoe UI", 11F);
            txtNom.Location = new Point(24, 233);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(273, 32);
            txtNom.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 205);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 9;
            label1.Text = "Nom";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtCodeFournisseur);
            panel2.Controls.Add(label0);
            panel2.Controls.Add(lblGestionFournisseurs);
            panel2.Controls.Add(btnEffacer);
            panel2.Controls.Add(btnSupprimer);
            panel2.Controls.Add(btnModifier);
            panel2.Controls.Add(btnAjouter);
            panel2.Controls.Add(txtAdresse);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTelephone);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNom);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(938, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 673);
            panel2.TabIndex = 4;
            // 
            // FormFournisseurs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormFournisseurs";
            Text = "PharmaPlus - Gestion des Fournisseurs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFournisseurs).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetour;
        private Panel panel1;
        private Button btnReinitialiserRecherche;
        private Button btnRafraichir;
        private TextBox textBox2;
        private Label label6;
        private DataGridView dgvFournisseurs;
        private TextBox txtCodeFournisseur;
        private Label label0;
        private Label lblGestionFournisseurs;
        private Button btnEffacer;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private TextBox txtAdresse;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelephone;
        private Label label2;
        private TextBox txtNom;
        private Label label1;
        private Panel panel2;
    }
}