namespace PharmaPlus
{
    partial class FormAjouterCommande
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnRetour = new Button();
            panel1 = new Panel();
            label5 = new Label();
            txtAdresseClient = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelephoneClient = new TextBox();
            txtPrenomClient = new TextBox();
            txtNomClient = new TextBox();
            txtCodeClient = new TextBox();
            lblSelectionnerMedicament = new Label();
            cmbMedicaments = new ComboBox();
            panel2 = new Panel();
            label10 = new Label();
            dgvMedicaments = new DataGridView();
            Reference = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Fabricant = new DataGridViewTextBoxColumn();
            QuantiteMed = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label12 = new Label();
            txtFabricantMed = new TextBox();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            txtReferenceMed = new TextBox();
            txtQuantiteTotaleMed = new TextBox();
            txtNomMed = new TextBox();
            panel4 = new Panel();
            button1 = new Button();
            btnAjouter = new Button();
            textBox9 = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAdresseClient);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTelephoneClient);
            panel1.Controls.Add(txtPrenomClient);
            panel1.Controls.Add(txtNomClient);
            panel1.Controls.Add(txtCodeClient);
            panel1.Controls.Add(lblSelectionnerMedicament);
            panel1.Controls.Add(cmbMedicaments);
            panel1.Controls.Add(btnRetour);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 335);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 288);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 48;
            label5.Text = "Adresse";
            // 
            // txtAdresseClient
            // 
            txtAdresseClient.Font = new Font("Segoe UI", 10F);
            txtAdresseClient.Location = new Point(224, 285);
            txtAdresseClient.Name = "txtAdresseClient";
            txtAdresseClient.Size = new Size(372, 30);
            txtAdresseClient.TabIndex = 47;
            txtAdresseClient.TextChanged += txtAdresseClient_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 247);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 46;
            label4.Text = "Téléphone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 206);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 45;
            label3.Text = "Prénom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 165);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 44;
            label2.Text = "Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 124);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 43;
            label1.Text = "Code Client";
            // 
            // txtTelephoneClient
            // 
            txtTelephoneClient.Font = new Font("Segoe UI", 10F);
            txtTelephoneClient.Location = new Point(224, 244);
            txtTelephoneClient.Name = "txtTelephoneClient";
            txtTelephoneClient.Size = new Size(372, 30);
            txtTelephoneClient.TabIndex = 42;
            txtTelephoneClient.TextChanged += txtTelephoneClient_TextChanged;
            // 
            // txtPrenomClient
            // 
            txtPrenomClient.Font = new Font("Segoe UI", 10F);
            txtPrenomClient.Location = new Point(224, 203);
            txtPrenomClient.Name = "txtPrenomClient";
            txtPrenomClient.Size = new Size(372, 30);
            txtPrenomClient.TabIndex = 41;
            txtPrenomClient.TextChanged += txtPrenomClient_TextChanged;
            // 
            // txtNomClient
            // 
            txtNomClient.Font = new Font("Segoe UI", 10F);
            txtNomClient.Location = new Point(224, 162);
            txtNomClient.Name = "txtNomClient";
            txtNomClient.Size = new Size(372, 30);
            txtNomClient.TabIndex = 40;
            txtNomClient.TextChanged += txtNomClient_TextChanged;
            // 
            // txtCodeClient
            // 
            txtCodeClient.Font = new Font("Segoe UI", 10F);
            txtCodeClient.Location = new Point(224, 121);
            txtCodeClient.Name = "txtCodeClient";
            txtCodeClient.Size = new Size(372, 30);
            txtCodeClient.TabIndex = 39;
            txtCodeClient.TextChanged += txtCodeClient_TextChanged;
            // 
            // lblSelectionnerMedicament
            // 
            lblSelectionnerMedicament.AutoSize = true;
            lblSelectionnerMedicament.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectionnerMedicament.Location = new Point(35, 48);
            lblSelectionnerMedicament.Name = "lblSelectionnerMedicament";
            lblSelectionnerMedicament.Size = new Size(178, 23);
            lblSelectionnerMedicament.TabIndex = 38;
            lblSelectionnerMedicament.Text = "Sélectionner un Client";
            // 
            // cmbMedicaments
            // 
            cmbMedicaments.Font = new Font("Segoe UI", 10F);
            cmbMedicaments.FormattingEnabled = true;
            cmbMedicaments.Location = new Point(35, 74);
            cmbMedicaments.Name = "cmbMedicaments";
            cmbMedicaments.Size = new Size(561, 31);
            cmbMedicaments.TabIndex = 37;
            cmbMedicaments.SelectedIndexChanged += cmbMedicaments_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(dgvMedicaments);
            panel2.Location = new Point(632, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 408);
            panel2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(7, 17);
            label10.Name = "label10";
            label10.Size = new Size(68, 28);
            label10.TabIndex = 49;
            label10.Text = "Panier";
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.AllowUserToAddRows = false;
            dgvMedicaments.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 85, 70);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMedicaments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMedicaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicaments.Columns.AddRange(new DataGridViewColumn[] { Reference, Nom, Fabricant, QuantiteMed });
            dgvMedicaments.EnableHeadersVisualStyles = false;
            dgvMedicaments.Location = new Point(7, 57);
            dgvMedicaments.MultiSelect = false;
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.ReadOnly = true;
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicaments.Size = new Size(614, 321);
            dgvMedicaments.TabIndex = 24;
            dgvMedicaments.CellContentClick += dgvMedicaments_CellContentClick;
            // 
            // Reference
            // 
            Reference.HeaderText = "Référence";
            Reference.MinimumWidth = 6;
            Reference.Name = "Reference";
            Reference.ReadOnly = true;
            Reference.Width = 125;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom Médicament";
            Nom.MinimumWidth = 6;
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            Nom.Width = 180;
            // 
            // Fabricant
            // 
            Fabricant.HeaderText = "Fabricant";
            Fabricant.MinimumWidth = 6;
            Fabricant.Name = "Fabricant";
            Fabricant.ReadOnly = true;
            Fabricant.Width = 125;
            // 
            // QuantiteMed
            // 
            QuantiteMed.HeaderText = "Quantité";
            QuantiteMed.MinimumWidth = 6;
            QuantiteMed.Name = "QuantiteMed";
            QuantiteMed.ReadOnly = true;
            QuantiteMed.Width = 125;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtFabricantMed);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtReferenceMed);
            panel3.Controls.Add(txtQuantiteTotaleMed);
            panel3.Controls.Add(txtNomMed);
            panel3.Location = new Point(0, 337);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 336);
            panel3.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(35, 231);
            label12.Name = "label12";
            label12.Size = new Size(80, 23);
            label12.TabIndex = 58;
            label12.Text = "Fabricant";
            // 
            // txtFabricantMed
            // 
            txtFabricantMed.Font = new Font("Segoe UI", 10F);
            txtFabricantMed.Location = new Point(224, 228);
            txtFabricantMed.Name = "txtFabricantMed";
            txtFabricantMed.Size = new Size(372, 30);
            txtFabricantMed.TabIndex = 57;
            txtFabricantMed.TextChanged += txtFabricantMed_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 271);
            label6.Name = "label6";
            label6.Size = new Size(183, 23);
            label6.TabIndex = 56;
            label6.Text = "Quantité dans le Stock";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 55);
            label9.Name = "label9";
            label9.Size = new Size(230, 23);
            label9.TabIndex = 50;
            label9.Text = "Sélectionner un Médicament";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 190);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 55;
            label7.Text = "Nom";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(561, 31);
            comboBox1.TabIndex = 49;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 149);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(87, 23);
            label8.TabIndex = 54;
            label8.Text = "Référence";
            // 
            // txtReferenceMed
            // 
            txtReferenceMed.Font = new Font("Segoe UI", 10F);
            txtReferenceMed.Location = new Point(224, 146);
            txtReferenceMed.Name = "txtReferenceMed";
            txtReferenceMed.Size = new Size(372, 30);
            txtReferenceMed.TabIndex = 51;
            txtReferenceMed.TextChanged += txtReferenceMed_TextChanged;
            // 
            // txtQuantiteTotaleMed
            // 
            txtQuantiteTotaleMed.Font = new Font("Segoe UI", 10F);
            txtQuantiteTotaleMed.Location = new Point(224, 268);
            txtQuantiteTotaleMed.Name = "txtQuantiteTotaleMed";
            txtQuantiteTotaleMed.Size = new Size(372, 30);
            txtQuantiteTotaleMed.TabIndex = 53;
            txtQuantiteTotaleMed.TextChanged += txtQuantiteTotaleMed_TextChanged;
            // 
            // txtNomMed
            // 
            txtNomMed.Font = new Font("Segoe UI", 10F);
            txtNomMed.Location = new Point(224, 187);
            txtNomMed.Name = "txtNomMed";
            txtNomMed.Size = new Size(372, 30);
            txtNomMed.TabIndex = 52;
            txtNomMed.TextChanged += txtNomMed_TextChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(btnAjouter);
            panel4.Controls.Add(textBox9);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(632, 410);
            panel4.Name = "panel4";
            panel4.Size = new Size(630, 263);
            panel4.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 85, 70);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(332, 156);
            button1.Name = "button1";
            button1.Size = new Size(175, 35);
            button1.TabIndex = 52;
            button1.Text = "Réinitialiser Tous";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(0, 85, 70);
            btnAjouter.FlatStyle = FlatStyle.Popup;
            btnAjouter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.ForeColor = SystemColors.HighlightText;
            btnAjouter.Location = new Point(141, 156);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(175, 35);
            btnAjouter.TabIndex = 51;
            btnAjouter.Text = "Enregistrer";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 14F);
            textBox9.Location = new Point(207, 73);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(315, 39);
            textBox9.TabIndex = 49;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(99, 78);
            label11.Name = "label11";
            label11.Size = new Size(84, 28);
            label11.TabIndex = 50;
            label11.Text = "Résumé";
            // 
            // FormAjouterCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAjouterCommande";
            Text = "PharmaPlus - Ajout d'une Commande";
            Load += FormAjouterCommande_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetour;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ComboBox cmbMedicaments;
        private Label lblSelectionnerMedicament;
        private TextBox txtTelephoneClient;
        private TextBox txtPrenomClient;
        private TextBox txtNomClient;
        private TextBox txtCodeClient;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtAdresseClient;
        private Label label6;
        private Label label9;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox txtReferenceMed;
        private TextBox txtQuantiteTotaleMed;
        private TextBox txtNomMed;
        private DataGridView dgvMedicaments;
        private Label label10;
        private Label label11;
        private TextBox textBox9;
        private Button btnAjouter;
        private Button button1;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Fabricant;
        private DataGridViewTextBoxColumn QuantiteMed;
        private Label label12;
        private TextBox txtFabricantMed;
    }
}