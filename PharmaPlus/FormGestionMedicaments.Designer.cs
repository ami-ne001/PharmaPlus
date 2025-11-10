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
            panel1 = new Panel();
            btnRafraichir = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            dgvMedicaments = new DataGridView();
            ID_Medicament = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Fabricant = new DataGridViewTextBoxColumn();
            QuantiteTotale = new DataGridViewTextBoxColumn();
            SeuilAlerteStock = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
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
            panel1.Controls.Add(btnRafraichir);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dgvMedicaments);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 673);
            panel1.TabIndex = 0;
            // 
            // btnRafraichir
            // 
            btnRafraichir.Location = new Point(694, 50);
            btnRafraichir.Name = "btnRafraichir";
            btnRafraichir.Size = new Size(120, 29);
            btnRafraichir.TabIndex = 25;
            btnRafraichir.Text = "Rafraîchir";
            btnRafraichir.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(429, 27);
            textBox2.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 54);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 23;
            label6.Text = "Rechercher";
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.BackgroundColor = SystemColors.Control;
            dgvMedicaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicaments.Columns.AddRange(new DataGridViewColumn[] { ID_Medicament, Nom, Reference, Categorie, Fabricant, QuantiteTotale, SeuilAlerteStock });
            dgvMedicaments.Location = new Point(3, 111);
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.Size = new Size(928, 557);
            dgvMedicaments.TabIndex = 23;
            // 
            // ID_Medicament
            // 
            ID_Medicament.HeaderText = "ID";
            ID_Medicament.MinimumWidth = 6;
            ID_Medicament.Name = "ID_Medicament";
            ID_Medicament.Width = 125;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.MinimumWidth = 6;
            Nom.Name = "Nom";
            Nom.Width = 125;
            // 
            // Reference
            // 
            Reference.HeaderText = "Référence";
            Reference.MinimumWidth = 6;
            Reference.Name = "Reference";
            Reference.Width = 125;
            // 
            // Categorie
            // 
            Categorie.HeaderText = "Catégorie";
            Categorie.MinimumWidth = 6;
            Categorie.Name = "Categorie";
            Categorie.Width = 125;
            // 
            // Fabricant
            // 
            Fabricant.HeaderText = "Fabricant";
            Fabricant.MinimumWidth = 6;
            Fabricant.Name = "Fabricant";
            Fabricant.Width = 125;
            // 
            // QuantiteTotale
            // 
            QuantiteTotale.HeaderText = "Quantité";
            QuantiteTotale.MinimumWidth = 6;
            QuantiteTotale.Name = "QuantiteTotale";
            QuantiteTotale.Width = 125;
            // 
            // SeuilAlerteStock
            // 
            SeuilAlerteStock.HeaderText = "Seuil";
            SeuilAlerteStock.MinimumWidth = 6;
            SeuilAlerteStock.Name = "SeuilAlerteStock";
            SeuilAlerteStock.Width = 125;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
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
            // btnEffacer
            // 
            btnEffacer.Location = new Point(166, 570);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(131, 29);
            btnEffacer.TabIndex = 22;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(24, 570);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(131, 29);
            btnSupprimer.TabIndex = 21;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(166, 521);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(131, 29);
            btnModifier.TabIndex = 20;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(24, 521);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(131, 29);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // nudSeuil
            // 
            nudSeuil.Location = new Point(24, 452);
            nudSeuil.Name = "nudSeuil";
            nudSeuil.Size = new Size(273, 27);
            nudSeuil.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 424);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 17;
            label5.Text = "Seuil d'Alerte Stock";
            // 
            // txtFabricant
            // 
            txtFabricant.Location = new Point(24, 373);
            txtFabricant.Name = "txtFabricant";
            txtFabricant.Size = new Size(273, 27);
            txtFabricant.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 345);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 15;
            label4.Text = "Fabricant";
            // 
            // txtCategorie
            // 
            txtCategorie.Location = new Point(24, 299);
            txtCategorie.Name = "txtCategorie";
            txtCategorie.Size = new Size(273, 27);
            txtCategorie.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 271);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 13;
            label3.Text = "Catégorie";
            // 
            // txtReference
            // 
            txtReference.Location = new Point(24, 218);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(273, 27);
            txtReference.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 190);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 11;
            label2.Text = "Référence";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(24, 144);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(273, 27);
            txtNom.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 116);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
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
            Text = "PharmaPlus - Gestion des Lots de Médicaments";
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
    }
}