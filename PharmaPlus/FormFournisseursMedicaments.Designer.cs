namespace PharmaPlus
{
    partial class FormFournisseursMedicaments
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
            label10 = new Label();
            btnAjouterMedAuFournisseur = new Button();
            label12 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            txtAdresseFournisseur = new TextBox();
            txtFabricantMed = new TextBox();
            label4 = new Label();
            txtNomMed = new TextBox();
            label3 = new Label();
            label9 = new Label();
            label2 = new Label();
            txtReferenceMed = new TextBox();
            label1 = new Label();
            label7 = new Label();
            txtEmailFournisseur = new TextBox();
            label8 = new Label();
            txtTelephoneFournisseur = new TextBox();
            btnRetour = new Button();
            txtNomFournisseur = new TextBox();
            cmbFournisseurs = new ComboBox();
            txtCodeFournisseur = new TextBox();
            lblSelectionnerFournisseur = new Label();
            dataGridView1 = new DataGridView();
            Supprimer = new DataGridViewButtonColumn();
            Nom = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Fabricant = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(571, 31);
            label10.Name = "label10";
            label10.Size = new Size(480, 28);
            label10.TabIndex = 94;
            label10.Text = "Médicaments fournis par le fournisseur séléctionné";
            // 
            // btnAjouterMedAuFournisseur
            // 
            btnAjouterMedAuFournisseur.BackColor = Color.FromArgb(0, 85, 70);
            btnAjouterMedAuFournisseur.FlatStyle = FlatStyle.Popup;
            btnAjouterMedAuFournisseur.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouterMedAuFournisseur.ForeColor = SystemColors.HighlightText;
            btnAjouterMedAuFournisseur.Location = new Point(272, 624);
            btnAjouterMedAuFournisseur.Name = "btnAjouterMedAuFournisseur";
            btnAjouterMedAuFournisseur.Size = new Size(258, 35);
            btnAjouterMedAuFournisseur.TabIndex = 110;
            btnAjouterMedAuFournisseur.Text = "Ajouter au Fournisseur";
            btnAjouterMedAuFournisseur.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(37, 583);
            label12.Name = "label12";
            label12.Size = new Size(80, 23);
            label12.TabIndex = 108;
            label12.Text = "Fabricant";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 316);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 116;
            label5.Text = "Adresse";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 450);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(493, 31);
            comboBox1.TabIndex = 95;
            // 
            // txtAdresseFournisseur
            // 
            txtAdresseFournisseur.Font = new Font("Segoe UI", 10F);
            txtAdresseFournisseur.Location = new Point(205, 313);
            txtAdresseFournisseur.Name = "txtAdresseFournisseur";
            txtAdresseFournisseur.ReadOnly = true;
            txtAdresseFournisseur.Size = new Size(328, 30);
            txtAdresseFournisseur.TabIndex = 115;
            // 
            // txtFabricantMed
            // 
            txtFabricantMed.Font = new Font("Segoe UI", 10F);
            txtFabricantMed.Location = new Point(202, 580);
            txtFabricantMed.Name = "txtFabricantMed";
            txtFabricantMed.ReadOnly = true;
            txtFabricantMed.Size = new Size(328, 30);
            txtFabricantMed.TabIndex = 106;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 275);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 114;
            label4.Text = "Email";
            // 
            // txtNomMed
            // 
            txtNomMed.Font = new Font("Segoe UI", 10F);
            txtNomMed.Location = new Point(202, 539);
            txtNomMed.Name = "txtNomMed";
            txtNomMed.ReadOnly = true;
            txtNomMed.Size = new Size(328, 30);
            txtNomMed.TabIndex = 101;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 234);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 113;
            label3.Text = "Téléphone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(37, 424);
            label9.Name = "label9";
            label9.Size = new Size(230, 23);
            label9.TabIndex = 97;
            label9.Text = "Sélectionner un Médicament";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 193);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 112;
            label2.Text = "Nom";
            // 
            // txtReferenceMed
            // 
            txtReferenceMed.Font = new Font("Segoe UI", 10F);
            txtReferenceMed.Location = new Point(202, 498);
            txtReferenceMed.Name = "txtReferenceMed";
            txtReferenceMed.ReadOnly = true;
            txtReferenceMed.Size = new Size(328, 30);
            txtReferenceMed.TabIndex = 99;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 152);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 111;
            label1.Text = "Code Founisseur";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 542);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 105;
            label7.Text = "Nom";
            // 
            // txtEmailFournisseur
            // 
            txtEmailFournisseur.Font = new Font("Segoe UI", 10F);
            txtEmailFournisseur.Location = new Point(205, 272);
            txtEmailFournisseur.Name = "txtEmailFournisseur";
            txtEmailFournisseur.ReadOnly = true;
            txtEmailFournisseur.Size = new Size(328, 30);
            txtEmailFournisseur.TabIndex = 109;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 501);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(87, 23);
            label8.TabIndex = 103;
            label8.Text = "Référence";
            // 
            // txtTelephoneFournisseur
            // 
            txtTelephoneFournisseur.Font = new Font("Segoe UI", 10F);
            txtTelephoneFournisseur.Location = new Point(205, 231);
            txtTelephoneFournisseur.Name = "txtTelephoneFournisseur";
            txtTelephoneFournisseur.ReadOnly = true;
            txtTelephoneFournisseur.Size = new Size(328, 30);
            txtTelephoneFournisseur.TabIndex = 107;
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
            btnRetour.TabIndex = 96;
            btnRetour.Text = "< Retour";
            btnRetour.UseVisualStyleBackColor = false;
            // 
            // txtNomFournisseur
            // 
            txtNomFournisseur.Font = new Font("Segoe UI", 10F);
            txtNomFournisseur.Location = new Point(205, 190);
            txtNomFournisseur.Name = "txtNomFournisseur";
            txtNomFournisseur.ReadOnly = true;
            txtNomFournisseur.Size = new Size(328, 30);
            txtNomFournisseur.TabIndex = 104;
            // 
            // cmbFournisseurs
            // 
            cmbFournisseurs.Font = new Font("Segoe UI", 10F);
            cmbFournisseurs.FormattingEnabled = true;
            cmbFournisseurs.Location = new Point(40, 102);
            cmbFournisseurs.Name = "cmbFournisseurs";
            cmbFournisseurs.Size = new Size(493, 31);
            cmbFournisseurs.TabIndex = 98;
            // 
            // txtCodeFournisseur
            // 
            txtCodeFournisseur.Font = new Font("Segoe UI", 10F);
            txtCodeFournisseur.Location = new Point(205, 149);
            txtCodeFournisseur.Name = "txtCodeFournisseur";
            txtCodeFournisseur.ReadOnly = true;
            txtCodeFournisseur.Size = new Size(328, 30);
            txtCodeFournisseur.TabIndex = 102;
            // 
            // lblSelectionnerFournisseur
            // 
            lblSelectionnerFournisseur.AutoSize = true;
            lblSelectionnerFournisseur.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectionnerFournisseur.Location = new Point(40, 76);
            lblSelectionnerFournisseur.Name = "lblSelectionnerFournisseur";
            lblSelectionnerFournisseur.Size = new Size(222, 23);
            lblSelectionnerFournisseur.TabIndex = 100;
            lblSelectionnerFournisseur.Text = "Sélectionner un Fournisseur";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 85, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Supprimer, Nom, Reference, Categorie, Fabricant });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(571, 76);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(678, 583);
            dataGridView1.TabIndex = 117;
            // 
            // Supprimer
            // 
            Supprimer.HeaderText = "Supprimer";
            Supprimer.MinimumWidth = 6;
            Supprimer.Name = "Supprimer";
            Supprimer.ReadOnly = true;
            Supprimer.Width = 125;
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
            Categorie.Width = 150;
            // 
            // Fabricant
            // 
            Fabricant.HeaderText = "Fabricant";
            Fabricant.MinimumWidth = 6;
            Fabricant.Name = "Fabricant";
            Fabricant.ReadOnly = true;
            Fabricant.Width = 125;
            // 
            // FormFournisseursMedicaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dataGridView1);
            Controls.Add(btnAjouterMedAuFournisseur);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(txtAdresseFournisseur);
            Controls.Add(txtFabricantMed);
            Controls.Add(label4);
            Controls.Add(txtNomMed);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(txtReferenceMed);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(txtEmailFournisseur);
            Controls.Add(label8);
            Controls.Add(txtTelephoneFournisseur);
            Controls.Add(btnRetour);
            Controls.Add(txtNomFournisseur);
            Controls.Add(cmbFournisseurs);
            Controls.Add(txtCodeFournisseur);
            Controls.Add(lblSelectionnerFournisseur);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormFournisseursMedicaments";
            Text = "PharmaPlus - Gestion des Fournisseurs/Médicaments";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Button btnAjouterMedAuFournisseur;
        private Label label12;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox txtAdresseFournisseur;
        private TextBox txtFabricantMed;
        private Label label4;
        private TextBox txtNomMed;
        private Label label3;
        private Label label9;
        private Label label2;
        private TextBox txtReferenceMed;
        private Label label1;
        private Label label7;
        private TextBox txtEmailFournisseur;
        private Label label8;
        private TextBox txtTelephoneFournisseur;
        private Button btnRetour;
        private TextBox txtNomFournisseur;
        private ComboBox cmbFournisseurs;
        private TextBox txtCodeFournisseur;
        private Label lblSelectionnerFournisseur;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Supprimer;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Fabricant;
    }
}