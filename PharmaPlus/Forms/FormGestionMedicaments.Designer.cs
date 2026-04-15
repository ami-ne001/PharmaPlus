namespace PharmaPlus
{
    partial class FormGestionMedicaments
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
            lblTotalMedicaments = new Label();
            dgvMedicaments = new DataGridView();
            ID_Medicament = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Fabricant = new DataGridViewTextBoxColumn();
            QuantiteTotale = new DataGridViewTextBoxColumn();
            SeuilAlerteStock = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblGestionMedicaments = new Label();
            btnEffacer = new Button();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            nudSeuil = new NumericUpDown();
            label5 = new Label();
            txtFabricant = new TextBox();
            label4 = new Label();
            txtCategorie = new TextBox();
            label3 = new Label();
            txtReference = new TextBox();
            label2 = new Label();
            txtNom = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSeuil).BeginInit();
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
            panel1.Controls.Add(lblTotalMedicaments);
            panel1.Controls.Add(dgvMedicaments);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 673);
            panel1.TabIndex = 0;
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
            btnReinitialiserRecherche.Location = new Point(778, 52);
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
            btnRafraichir.Location = new Point(652, 52);
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
            textBox2.Location = new Point(196, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(412, 30);
            textBox2.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(70, 55);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 23;
            label6.Text = "Rechercher";
            // 
            // lblTotalMedicaments
            // 
            lblTotalMedicaments.AutoSize = true;
            lblTotalMedicaments.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMedicaments.ForeColor = Color.Black;
            lblTotalMedicaments.Location = new Point(3, 88);
            lblTotalMedicaments.Name = "lblTotalMedicaments";
            lblTotalMedicaments.Size = new Size(250, 25);
            lblTotalMedicaments.TabIndex = 28;
            lblTotalMedicaments.Text = "Total de médicaments : 0";
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.AllowUserToAddRows = false;
            dgvMedicaments.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 85, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMedicaments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicaments.Columns.AddRange(new DataGridViewColumn[] { ID_Medicament, Nom, Reference, Categorie, Fabricant, QuantiteTotale, SeuilAlerteStock });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMedicaments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicaments.EnableHeadersVisualStyles = false;
            dgvMedicaments.Location = new Point(3, 125);
            dgvMedicaments.MultiSelect = false;
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMedicaments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicaments.Size = new Size(928, 543);
            dgvMedicaments.TabIndex = 23;
            dgvMedicaments.SelectionChanged += dgvMedicaments_SelectionChanged;
            // 
            // ID_Medicament
            // 
            ID_Medicament.HeaderText = "ID";
            ID_Medicament.MinimumWidth = 6;
            ID_Medicament.Name = "ID_Medicament";
            ID_Medicament.ReadOnly = true;
            ID_Medicament.Width = 125;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.MinimumWidth = 6;
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            Nom.Width = 125;
            // 
            // Reference
            // 
            Reference.HeaderText = "Référence";
            Reference.MinimumWidth = 6;
            Reference.Name = "Reference";
            Reference.ReadOnly = true;
            Reference.Width = 125;
            // 
            // Categorie
            // 
            Categorie.HeaderText = "Catégorie";
            Categorie.MinimumWidth = 6;
            Categorie.Name = "Categorie";
            Categorie.ReadOnly = true;
            Categorie.Width = 125;
            // 
            // Fabricant
            // 
            Fabricant.HeaderText = "Fabricant";
            Fabricant.MinimumWidth = 6;
            Fabricant.Name = "Fabricant";
            Fabricant.ReadOnly = true;
            Fabricant.Width = 125;
            // 
            // QuantiteTotale
            // 
            QuantiteTotale.HeaderText = "Quantité";
            QuantiteTotale.MinimumWidth = 6;
            QuantiteTotale.Name = "QuantiteTotale";
            QuantiteTotale.ReadOnly = true;
            QuantiteTotale.Width = 125;
            // 
            // SeuilAlerteStock
            // 
            SeuilAlerteStock.HeaderText = "Seuil";
            SeuilAlerteStock.MinimumWidth = 6;
            SeuilAlerteStock.Name = "SeuilAlerteStock";
            SeuilAlerteStock.ReadOnly = true;
            SeuilAlerteStock.Width = 125;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblGestionMedicaments);
            panel2.Controls.Add(btnEffacer);
            panel2.Controls.Add(btnSupprimer);
            panel2.Controls.Add(btnModifier);
            panel2.Controls.Add(btnAjouter);
            panel2.Controls.Add(nudSeuil);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtFabricant);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtCategorie);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtReference);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNom);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(938, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 673);
            panel2.TabIndex = 1;
            // 
            // lblGestionMedicaments
            // 
            lblGestionMedicaments.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionMedicaments.ForeColor = Color.FromArgb(0, 85, 70);
            lblGestionMedicaments.Location = new Point(24, 13);
            lblGestionMedicaments.Name = "lblGestionMedicaments";
            lblGestionMedicaments.Size = new Size(273, 98);
            lblGestionMedicaments.TabIndex = 35;
            lblGestionMedicaments.Text = "Gestion des Médicaments";
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
            // nudSeuil
            // 
            nudSeuil.Font = new Font("Segoe UI", 11F);
            nudSeuil.Location = new Point(24, 477);
            nudSeuil.Name = "nudSeuil";
            nudSeuil.Size = new Size(273, 32);
            nudSeuil.TabIndex = 19;
            nudSeuil.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 449);
            label5.Name = "label5";
            label5.Size = new Size(157, 23);
            label5.TabIndex = 17;
            label5.Text = "Seuil d'Alerte Stock";
            // 
            // txtFabricant
            // 
            txtFabricant.Font = new Font("Segoe UI", 11F);
            txtFabricant.Location = new Point(24, 396);
            txtFabricant.Name = "txtFabricant";
            txtFabricant.Size = new Size(273, 32);
            txtFabricant.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 368);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 15;
            label4.Text = "Fabricant";
            // 
            // txtCategorie
            // 
            txtCategorie.Font = new Font("Segoe UI", 11F);
            txtCategorie.Location = new Point(24, 320);
            txtCategorie.Name = "txtCategorie";
            txtCategorie.Size = new Size(273, 32);
            txtCategorie.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 292);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 13;
            label3.Text = "Catégorie";
            // 
            // txtReference
            // 
            txtReference.Font = new Font("Segoe UI", 11F);
            txtReference.Location = new Point(24, 237);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(273, 32);
            txtReference.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 209);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 11;
            label2.Text = "Référence";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Segoe UI", 11F);
            txtNom.Location = new Point(24, 161);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(273, 32);
            txtNom.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 133);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 9;
            label1.Text = "Nom";
            // 
            // FormGestionMedicaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGestionMedicaments";
            Text = "PharmaPlus - Gestion des Médicaments";
            Load += FormGestionMedicaments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSeuil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private NumericUpDown nudSeuil;
        private Label label5;
        private TextBox txtFabricant;
        private Label label4;
        private TextBox txtCategorie;
        private Label label3;
        private TextBox txtReference;
        private Label label2;
        private TextBox txtNom;
        private Label label1;
        private Button btnEffacer;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private DataGridView dgvMedicaments;
        private DataGridViewTextBoxColumn ID_Medicament;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Fabricant;
        private DataGridViewTextBoxColumn QuantiteTotale;
        private DataGridViewTextBoxColumn SeuilAlerteStock;
        private Label label6;
        private TextBox textBox2;
        private Button btnRafraichir;
        private Button btnReinitialiserRecherche;
        private Label lblGestionMedicaments;
        private Button btnRetour;
        private Label lblTotalMedicaments;
    }
}