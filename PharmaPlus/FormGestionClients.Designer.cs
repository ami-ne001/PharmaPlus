namespace PharmaPlus
{
    partial class FormGestionClients
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnRetour = new Button();
            btnReinitialiserRecherche = new Button();
            btnRafraichir = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            dgvClients = new DataGridView();
            panel2 = new Panel();
            textCodeClient = new TextBox();
            label0 = new Label();
            lblGestionMedicaments = new Label();
            btnEffacer = new Button();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            txtAdresse = new TextBox();
            label4 = new Label();
            txtTelephone = new TextBox();
            label3 = new Label();
            txtPrenom = new TextBox();
            label2 = new Label();
            txtNom = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRetour);
            panel1.Controls.Add(btnReinitialiserRecherche);
            panel1.Controls.Add(btnRafraichir);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dgvClients);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 673);
            panel1.TabIndex = 1;
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
            btnRetour.Click += btnRetour_Click;
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
            btnReinitialiserRecherche.Click += btnReinitialiserRecherche_Click;
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
            btnRafraichir.Click += btnRafraichir_Click;
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
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 85, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClients.EnableHeadersVisualStyles = false;
            dgvClients.Location = new Point(37, 103);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClients.RowHeadersWidth = 51;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new Size(873, 557);
            dgvClients.TabIndex = 23;
            dgvClients.CellContentClick += dgvClients_CellContentClick;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textCodeClient);
            panel2.Controls.Add(label0);
            panel2.Controls.Add(lblGestionMedicaments);
            panel2.Controls.Add(btnEffacer);
            panel2.Controls.Add(btnSupprimer);
            panel2.Controls.Add(btnModifier);
            panel2.Controls.Add(btnAjouter);
            panel2.Controls.Add(txtAdresse);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTelephone);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPrenom);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNom);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(938, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 673);
            panel2.TabIndex = 2;
            // 
            // textCodeClient
            // 
            textCodeClient.Font = new Font("Segoe UI", 11F);
            textCodeClient.Location = new Point(24, 157);
            textCodeClient.Name = "textCodeClient";
            textCodeClient.Size = new Size(273, 32);
            textCodeClient.TabIndex = 37;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label0.Location = new Point(24, 129);
            label0.Name = "label0";
            label0.Size = new Size(99, 23);
            label0.TabIndex = 36;
            label0.Text = "Code Client";
            // 
            // lblGestionMedicaments
            // 
            lblGestionMedicaments.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionMedicaments.ForeColor = Color.FromArgb(0, 85, 70);
            lblGestionMedicaments.Location = new Point(24, 20);
            lblGestionMedicaments.Name = "lblGestionMedicaments";
            lblGestionMedicaments.Size = new Size(273, 82);
            lblGestionMedicaments.TabIndex = 35;
            lblGestionMedicaments.Text = "Gestion des Clients";
            lblGestionMedicaments.TextAlign = ContentAlignment.MiddleCenter;
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
            btnEffacer.Click += btnEffacer_Click;
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
            btnSupprimer.Click += btnSupprimer_Click;
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
            btnModifier.Click += btnModifier_Click;
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
            btnAjouter.Click += btnAjouter_Click;
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
            // txtTelephone
            // 
            txtTelephone.Font = new Font("Segoe UI", 11F);
            txtTelephone.Location = new Point(24, 392);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(273, 32);
            txtTelephone.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 364);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 13;
            label3.Text = "Téléphone";
            // 
            // txtPrenom
            // 
            txtPrenom.Font = new Font("Segoe UI", 11F);
            txtPrenom.Location = new Point(24, 309);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(273, 32);
            txtPrenom.TabIndex = 12;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 281);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 11;
            label2.Text = "Prénom";
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
            // FormGestionClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGestionClients";
            Text = "PharmaPlus - Gestion des Clients";
            Load += FormGestionClients_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRetour;
        private Button btnReinitialiserRecherche;
        private Button btnRafraichir;
        private TextBox textBox2;
        private Label label6;
        private DataGridView dgvClients;
        private Panel panel2;
        private Label lblGestionMedicaments;
        private Button btnEffacer;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private TextBox txtAdresse;
        private Label label4;
        private TextBox txtTelephone;
        private Label label3;
        private TextBox txtPrenom;
        private Label label2;
        private TextBox txtNom;
        private Label label1;
        private TextBox textCodeClient;
        private Label label0;
    }
}