namespace PharmaPlus
{
    partial class FormGestionLots
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
            panel1 = new Panel();
            btnRetour = new Button();
            btnReinitialiserNumeroLot = new Button();
            btnRafraichirReference = new Button();
            lblRechercherNumeroLot = new Label();
            btnRafraichirNumeroLot = new Button();
            txtRechercherNumeroLot = new TextBox();
            lblSelectionnerMedicament = new Label();
            cmbMedicaments = new ComboBox();
            lblRechercherReference = new Label();
            btnReinitialiserReference = new Button();
            txtRechercherReference = new TextBox();
            dgvMedicaments = new DataGridView();
            ID_Medicament = new DataGridViewTextBoxColumn();
            ID_Lot = new DataGridViewTextBoxColumn();
            NumeroLot = new DataGridViewTextBoxColumn();
            DatePeremption = new DataGridViewTextBoxColumn();
            Prix = new DataGridViewTextBoxColumn();
            QuantiteLot = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblGestionLots = new Label();
            txtNumeroLot = new TextBox();
            lblNumeroLot = new Label();
            btnEffacer = new Button();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnAjouter = new Button();
            nudQuantiteLot = new NumericUpDown();
            dtpDatePeremption = new DateTimePicker();
            nudPrix = new NumericUpDown();
            lblQuantiteLot = new Label();
            lblPrix = new Label();
            lblDatePeremption = new Label();
            txtID_Medicament = new TextBox();
            lblID_Medicament = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantiteLot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrix).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRetour);
            panel1.Controls.Add(btnReinitialiserNumeroLot);
            panel1.Controls.Add(btnRafraichirReference);
            panel1.Controls.Add(lblRechercherNumeroLot);
            panel1.Controls.Add(btnRafraichirNumeroLot);
            panel1.Controls.Add(txtRechercherNumeroLot);
            panel1.Controls.Add(lblSelectionnerMedicament);
            panel1.Controls.Add(cmbMedicaments);
            panel1.Controls.Add(lblRechercherReference);
            panel1.Controls.Add(btnReinitialiserReference);
            panel1.Controls.Add(txtRechercherReference);
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
            btnRetour.TabIndex = 43;
            btnRetour.Text = "< Retour";
            btnRetour.UseVisualStyleBackColor = false;
            // 
            // btnReinitialiserNumeroLot
            // 
            btnReinitialiserNumeroLot.BackColor = Color.FromArgb(0, 85, 70);
            btnReinitialiserNumeroLot.FlatStyle = FlatStyle.Popup;
            btnReinitialiserNumeroLot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReinitialiserNumeroLot.ForeColor = SystemColors.HighlightText;
            btnReinitialiserNumeroLot.Location = new Point(762, 211);
            btnReinitialiserNumeroLot.Name = "btnReinitialiserNumeroLot";
            btnReinitialiserNumeroLot.Size = new Size(131, 32);
            btnReinitialiserNumeroLot.TabIndex = 42;
            btnReinitialiserNumeroLot.Text = "Réinitialiser";
            btnReinitialiserNumeroLot.UseVisualStyleBackColor = false;
            // 
            // btnRafraichirReference
            // 
            btnRafraichirReference.BackColor = Color.FromArgb(0, 85, 70);
            btnRafraichirReference.FlatStyle = FlatStyle.Popup;
            btnRafraichirReference.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRafraichirReference.ForeColor = SystemColors.HighlightText;
            btnRafraichirReference.Location = new Point(624, 65);
            btnRafraichirReference.Name = "btnRafraichirReference";
            btnRafraichirReference.Size = new Size(131, 32);
            btnRafraichirReference.TabIndex = 41;
            btnRafraichirReference.Text = "Rafaîchir";
            btnRafraichirReference.UseVisualStyleBackColor = false;
            // 
            // lblRechercherNumeroLot
            // 
            lblRechercherNumeroLot.AutoSize = true;
            lblRechercherNumeroLot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRechercherNumeroLot.Location = new Point(21, 215);
            lblRechercherNumeroLot.Name = "lblRechercherNumeroLot";
            lblRechercherNumeroLot.Size = new Size(205, 23);
            lblRechercherNumeroLot.TabIndex = 40;
            lblRechercherNumeroLot.Text = "Rechercher par Nº de Lot";
            // 
            // btnRafraichirNumeroLot
            // 
            btnRafraichirNumeroLot.BackColor = Color.FromArgb(0, 85, 70);
            btnRafraichirNumeroLot.FlatStyle = FlatStyle.Popup;
            btnRafraichirNumeroLot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRafraichirNumeroLot.ForeColor = SystemColors.HighlightText;
            btnRafraichirNumeroLot.Location = new Point(620, 211);
            btnRafraichirNumeroLot.Name = "btnRafraichirNumeroLot";
            btnRafraichirNumeroLot.Size = new Size(131, 32);
            btnRafraichirNumeroLot.TabIndex = 39;
            btnRafraichirNumeroLot.Text = "Rafaîchir";
            btnRafraichirNumeroLot.UseVisualStyleBackColor = false;
            // 
            // txtRechercherNumeroLot
            // 
            txtRechercherNumeroLot.Font = new Font("Segoe UI", 10F);
            txtRechercherNumeroLot.Location = new Point(256, 212);
            txtRechercherNumeroLot.Name = "txtRechercherNumeroLot";
            txtRechercherNumeroLot.Size = new Size(325, 30);
            txtRechercherNumeroLot.TabIndex = 38;
            // 
            // lblSelectionnerMedicament
            // 
            lblSelectionnerMedicament.AutoSize = true;
            lblSelectionnerMedicament.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectionnerMedicament.Location = new Point(25, 120);
            lblSelectionnerMedicament.Name = "lblSelectionnerMedicament";
            lblSelectionnerMedicament.Size = new Size(230, 23);
            lblSelectionnerMedicament.TabIndex = 37;
            lblSelectionnerMedicament.Text = "Sélectionner un Médicament";
            // 
            // cmbMedicaments
            // 
            cmbMedicaments.Font = new Font("Segoe UI", 10F);
            cmbMedicaments.FormattingEnabled = true;
            cmbMedicaments.Location = new Point(261, 117);
            cmbMedicaments.Name = "cmbMedicaments";
            cmbMedicaments.Size = new Size(636, 31);
            cmbMedicaments.TabIndex = 36;
            // 
            // lblRechercherReference
            // 
            lblRechercherReference.AutoSize = true;
            lblRechercherReference.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRechercherReference.Location = new Point(25, 70);
            lblRechercherReference.Name = "lblRechercherReference";
            lblRechercherReference.Size = new Size(208, 23);
            lblRechercherReference.TabIndex = 35;
            lblRechercherReference.Text = "Rechercher par Réference";
            // 
            // btnReinitialiserReference
            // 
            btnReinitialiserReference.BackColor = Color.FromArgb(0, 85, 70);
            btnReinitialiserReference.FlatStyle = FlatStyle.Popup;
            btnReinitialiserReference.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReinitialiserReference.ForeColor = SystemColors.HighlightText;
            btnReinitialiserReference.Location = new Point(766, 65);
            btnReinitialiserReference.Name = "btnReinitialiserReference";
            btnReinitialiserReference.Size = new Size(131, 32);
            btnReinitialiserReference.TabIndex = 34;
            btnReinitialiserReference.Text = "Réinitialiser";
            btnReinitialiserReference.UseVisualStyleBackColor = false;
            // 
            // txtRechercherReference
            // 
            txtRechercherReference.Font = new Font("Segoe UI", 10F);
            txtRechercherReference.Location = new Point(261, 66);
            txtRechercherReference.Name = "txtRechercherReference";
            txtRechercherReference.Size = new Size(338, 30);
            txtRechercherReference.TabIndex = 30;
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 85, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMedicaments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicaments.Columns.AddRange(new DataGridViewColumn[] { ID_Medicament, ID_Lot, NumeroLot, DatePeremption, Prix, QuantiteLot });
            dgvMedicaments.EnableHeadersVisualStyles = false;
            dgvMedicaments.Location = new Point(3, 269);
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.Size = new Size(928, 399);
            dgvMedicaments.TabIndex = 24;
            // 
            // ID_Medicament
            // 
            ID_Medicament.HeaderText = "ID Médicament";
            ID_Medicament.MinimumWidth = 6;
            ID_Medicament.Name = "ID_Medicament";
            ID_Medicament.Width = 140;
            // 
            // ID_Lot
            // 
            ID_Lot.HeaderText = "ID Lot";
            ID_Lot.MinimumWidth = 6;
            ID_Lot.Name = "ID_Lot";
            ID_Lot.Width = 140;
            // 
            // NumeroLot
            // 
            NumeroLot.HeaderText = "Numéro de Lot";
            NumeroLot.MinimumWidth = 6;
            NumeroLot.Name = "NumeroLot";
            NumeroLot.Width = 140;
            // 
            // DatePeremption
            // 
            DatePeremption.HeaderText = "Date de Péremption";
            DatePeremption.MinimumWidth = 6;
            DatePeremption.Name = "DatePeremption";
            DatePeremption.Width = 175;
            // 
            // Prix
            // 
            Prix.HeaderText = "Prix Unitaire";
            Prix.MinimumWidth = 6;
            Prix.Name = "Prix";
            Prix.Width = 140;
            // 
            // QuantiteLot
            // 
            QuantiteLot.HeaderText = "Quantité";
            QuantiteLot.MinimumWidth = 6;
            QuantiteLot.Name = "QuantiteLot";
            QuantiteLot.Width = 140;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblGestionLots);
            panel2.Controls.Add(txtNumeroLot);
            panel2.Controls.Add(lblNumeroLot);
            panel2.Controls.Add(btnEffacer);
            panel2.Controls.Add(btnSupprimer);
            panel2.Controls.Add(btnModifier);
            panel2.Controls.Add(btnAjouter);
            panel2.Controls.Add(nudQuantiteLot);
            panel2.Controls.Add(dtpDatePeremption);
            panel2.Controls.Add(nudPrix);
            panel2.Controls.Add(lblQuantiteLot);
            panel2.Controls.Add(lblPrix);
            panel2.Controls.Add(lblDatePeremption);
            panel2.Controls.Add(txtID_Medicament);
            panel2.Controls.Add(lblID_Medicament);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(938, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 673);
            panel2.TabIndex = 1;
            // 
            // lblGestionLots
            // 
            lblGestionLots.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionLots.ForeColor = Color.FromArgb(0, 85, 70);
            lblGestionLots.Location = new Point(18, 16);
            lblGestionLots.Name = "lblGestionLots";
            lblGestionLots.Size = new Size(289, 78);
            lblGestionLots.TabIndex = 34;
            lblGestionLots.Text = "Gestion des Lots de Médicaments";
            lblGestionLots.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumeroLot
            // 
            txtNumeroLot.Font = new Font("Segoe UI", 11F);
            txtNumeroLot.Location = new Point(18, 238);
            txtNumeroLot.Name = "txtNumeroLot";
            txtNumeroLot.Size = new Size(289, 32);
            txtNumeroLot.TabIndex = 33;
            // 
            // lblNumeroLot
            // 
            lblNumeroLot.AutoSize = true;
            lblNumeroLot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblNumeroLot.Location = new Point(18, 212);
            lblNumeroLot.Name = "lblNumeroLot";
            lblNumeroLot.Size = new Size(138, 23);
            lblNumeroLot.TabIndex = 32;
            lblNumeroLot.Text = "Numéro de Lot *";
            // 
            // btnEffacer
            // 
            btnEffacer.BackColor = Color.FromArgb(0, 85, 70);
            btnEffacer.FlatStyle = FlatStyle.Popup;
            btnEffacer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEffacer.ForeColor = SystemColors.HighlightText;
            btnEffacer.Location = new Point(167, 602);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(140, 35);
            btnEffacer.TabIndex = 31;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.FromArgb(0, 85, 70);
            btnSupprimer.FlatStyle = FlatStyle.Popup;
            btnSupprimer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.ForeColor = SystemColors.HighlightText;
            btnSupprimer.Location = new Point(18, 602);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(140, 35);
            btnSupprimer.TabIndex = 30;
            btnSupprimer.Text = "Supprimer Lot";
            btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.FromArgb(0, 85, 70);
            btnModifier.FlatStyle = FlatStyle.Popup;
            btnModifier.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.ForeColor = SystemColors.HighlightText;
            btnModifier.Location = new Point(167, 556);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(140, 35);
            btnModifier.TabIndex = 29;
            btnModifier.Text = "Modifier Lot";
            btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(0, 85, 70);
            btnAjouter.FlatStyle = FlatStyle.Popup;
            btnAjouter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.ForeColor = SystemColors.HighlightText;
            btnAjouter.Location = new Point(18, 556);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(140, 35);
            btnAjouter.TabIndex = 28;
            btnAjouter.Text = "Ajouter Lot";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // nudQuantiteLot
            // 
            nudQuantiteLot.Font = new Font("Segoe UI", 11F);
            nudQuantiteLot.Location = new Point(18, 490);
            nudQuantiteLot.Name = "nudQuantiteLot";
            nudQuantiteLot.Size = new Size(289, 32);
            nudQuantiteLot.TabIndex = 27;
            // 
            // dtpDatePeremption
            // 
            dtpDatePeremption.Font = new Font("Segoe UI", 11F);
            dtpDatePeremption.Location = new Point(18, 322);
            dtpDatePeremption.Name = "dtpDatePeremption";
            dtpDatePeremption.Size = new Size(289, 32);
            dtpDatePeremption.TabIndex = 26;
            // 
            // nudPrix
            // 
            nudPrix.Font = new Font("Segoe UI", 11F);
            nudPrix.Location = new Point(18, 406);
            nudPrix.Name = "nudPrix";
            nudPrix.Size = new Size(289, 32);
            nudPrix.TabIndex = 25;
            // 
            // lblQuantiteLot
            // 
            lblQuantiteLot.AutoSize = true;
            lblQuantiteLot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblQuantiteLot.Location = new Point(18, 464);
            lblQuantiteLot.Name = "lblQuantiteLot";
            lblQuantiteLot.Size = new Size(89, 23);
            lblQuantiteLot.TabIndex = 23;
            lblQuantiteLot.Text = "Quantité *";
            // 
            // lblPrix
            // 
            lblPrix.AutoSize = true;
            lblPrix.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPrix.Location = new Point(18, 380);
            lblPrix.Name = "lblPrix";
            lblPrix.Size = new Size(158, 23);
            lblPrix.TabIndex = 21;
            lblPrix.Text = "Prix Unitaire (DH) *";
            // 
            // lblDatePeremption
            // 
            lblDatePeremption.AutoSize = true;
            lblDatePeremption.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDatePeremption.Location = new Point(18, 296);
            lblDatePeremption.Name = "lblDatePeremption";
            lblDatePeremption.Size = new Size(151, 23);
            lblDatePeremption.TabIndex = 19;
            lblDatePeremption.Text = "Date Péremption *";
            // 
            // txtID_Medicament
            // 
            txtID_Medicament.Font = new Font("Segoe UI", 11F);
            txtID_Medicament.Location = new Point(18, 154);
            txtID_Medicament.Name = "txtID_Medicament";
            txtID_Medicament.Size = new Size(289, 32);
            txtID_Medicament.TabIndex = 18;
            // 
            // lblID_Medicament
            // 
            lblID_Medicament.AutoSize = true;
            lblID_Medicament.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblID_Medicament.Location = new Point(18, 128);
            lblID_Medicament.Name = "lblID_Medicament";
            lblID_Medicament.Size = new Size(128, 23);
            lblID_Medicament.TabIndex = 17;
            lblID_Medicament.Text = "ID Médicament";
            // 
            // FormGestionLots
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGestionLots";
            Text = "PharmaPlus - Gestion des Médicaments";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantiteLot).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtFabricant;
        private Label lblPrix;
        private Label lblDatePeremption;
        private TextBox txtID_Medicament;
        private Label lblID_Medicament;
        private NumericUpDown nudQuantiteLot;
        private NumericUpDown nudPrix;
        private DateTimePicker dtpDatePeremption;
        private Label lblQuantiteLot;
        private Button btnEffacer;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private DataGridView dgvMedicaments;
        private TextBox txtNumeroLot;
        private Label lblNumeroLot;
        private DataGridViewTextBoxColumn ID_Medicament;
        private DataGridViewTextBoxColumn ID_Lot;
        private DataGridViewTextBoxColumn NumeroLot;
        private DataGridViewTextBoxColumn DatePeremption;
        private DataGridViewTextBoxColumn Prix;
        private DataGridViewTextBoxColumn QuantiteLot;
        private TextBox txtRechercherReference;
        private Label label6;
        private Button btnReinitialiserReference;
        private Label lblRechercherReference;
        private Label lblSelectionnerMedicament;
        private ComboBox cmbMedicaments;
        private Label lblRechercherNumeroLot;
        private Button btnRafraichirNumeroLot;
        private TextBox txtRechercherNumeroLot;
        private Button btnRafraichirReference;
        private Button btnReinitialiserNumeroLot;
        private Label lblGestionLots;
        private Button btnRetour;
    }
}