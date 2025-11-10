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
            panel1 = new Panel();
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
            // btnReinitialiserNumeroLot
            // 
            btnReinitialiserNumeroLot.Location = new Point(762, 211);
            btnReinitialiserNumeroLot.Name = "btnReinitialiserNumeroLot";
            btnReinitialiserNumeroLot.Size = new Size(131, 29);
            btnReinitialiserNumeroLot.TabIndex = 42;
            btnReinitialiserNumeroLot.Text = "Réinitialiser";
            btnReinitialiserNumeroLot.UseVisualStyleBackColor = true;
            // 
            // btnRafraichirReference
            // 
            btnRafraichirReference.Location = new Point(620, 49);
            btnRafraichirReference.Name = "btnRafraichirReference";
            btnRafraichirReference.Size = new Size(131, 29);
            btnRafraichirReference.TabIndex = 41;
            btnRafraichirReference.Text = "Rafaîchir";
            btnRafraichirReference.UseVisualStyleBackColor = true;
            // 
            // lblRechercherNumeroLot
            // 
            lblRechercherNumeroLot.AutoSize = true;
            lblRechercherNumeroLot.Location = new Point(61, 215);
            lblRechercherNumeroLot.Name = "lblRechercherNumeroLot";
            lblRechercherNumeroLot.Size = new Size(175, 20);
            lblRechercherNumeroLot.TabIndex = 40;
            lblRechercherNumeroLot.Text = "Rechercher par Nº de Lot";
            // 
            // btnRafraichirNumeroLot
            // 
            btnRafraichirNumeroLot.Location = new Point(620, 211);
            btnRafraichirNumeroLot.Name = "btnRafraichirNumeroLot";
            btnRafraichirNumeroLot.Size = new Size(131, 29);
            btnRafraichirNumeroLot.TabIndex = 39;
            btnRafraichirNumeroLot.Text = "Rafaîchir";
            btnRafraichirNumeroLot.UseVisualStyleBackColor = true;
            // 
            // txtRechercherNumeroLot
            // 
            txtRechercherNumeroLot.Location = new Point(282, 212);
            txtRechercherNumeroLot.Name = "txtRechercherNumeroLot";
            txtRechercherNumeroLot.Size = new Size(299, 27);
            txtRechercherNumeroLot.TabIndex = 38;
            // 
            // lblSelectionnerMedicament
            // 
            lblSelectionnerMedicament.AutoSize = true;
            lblSelectionnerMedicament.Location = new Point(61, 104);
            lblSelectionnerMedicament.Name = "lblSelectionnerMedicament";
            lblSelectionnerMedicament.Size = new Size(198, 20);
            lblSelectionnerMedicament.TabIndex = 37;
            lblSelectionnerMedicament.Text = "Sélectionner un Médicament";
            // 
            // cmbMedicaments
            // 
            cmbMedicaments.FormattingEnabled = true;
            cmbMedicaments.Location = new Point(282, 101);
            cmbMedicaments.Name = "cmbMedicaments";
            cmbMedicaments.Size = new Size(611, 28);
            cmbMedicaments.TabIndex = 36;
            // 
            // lblRechercherReference
            // 
            lblRechercherReference.AutoSize = true;
            lblRechercherReference.Location = new Point(61, 53);
            lblRechercherReference.Name = "lblRechercherReference";
            lblRechercherReference.Size = new Size(178, 20);
            lblRechercherReference.TabIndex = 35;
            lblRechercherReference.Text = "Rechercher par Réference";
            // 
            // btnReinitialiserReference
            // 
            btnReinitialiserReference.Location = new Point(762, 49);
            btnReinitialiserReference.Name = "btnReinitialiserReference";
            btnReinitialiserReference.Size = new Size(131, 29);
            btnReinitialiserReference.TabIndex = 34;
            btnReinitialiserReference.Text = "Réinitialiser";
            btnReinitialiserReference.UseVisualStyleBackColor = true;
            // 
            // txtRechercherReference
            // 
            txtRechercherReference.Location = new Point(282, 50);
            txtRechercherReference.Name = "txtRechercherReference";
            txtRechercherReference.Size = new Size(313, 27);
            txtRechercherReference.TabIndex = 30;
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.BackgroundColor = SystemColors.Control;
            dgvMedicaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicaments.Columns.AddRange(new DataGridViewColumn[] { ID_Medicament, ID_Lot, NumeroLot, DatePeremption, Prix, QuantiteLot });
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
            // txtNumeroLot
            // 
            txtNumeroLot.Location = new Point(26, 219);
            txtNumeroLot.Name = "txtNumeroLot";
            txtNumeroLot.Size = new Size(273, 27);
            txtNumeroLot.TabIndex = 33;
            // 
            // lblNumeroLot
            // 
            lblNumeroLot.AutoSize = true;
            lblNumeroLot.Location = new Point(26, 190);
            lblNumeroLot.Name = "lblNumeroLot";
            lblNumeroLot.Size = new Size(119, 20);
            lblNumeroLot.TabIndex = 32;
            lblNumeroLot.Text = "Numéro de Lot *";
            // 
            // btnEffacer
            // 
            btnEffacer.Location = new Point(168, 568);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(131, 29);
            btnEffacer.TabIndex = 31;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(26, 568);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(131, 29);
            btnSupprimer.TabIndex = 30;
            btnSupprimer.Text = "Supprimer Lot";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(168, 522);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(131, 29);
            btnModifier.TabIndex = 29;
            btnModifier.Text = "Modifier Lot";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(26, 522);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(131, 29);
            btnAjouter.TabIndex = 28;
            btnAjouter.Text = "Ajouter Lot";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // nudQuantiteLot
            // 
            nudQuantiteLot.Location = new Point(26, 456);
            nudQuantiteLot.Name = "nudQuantiteLot";
            nudQuantiteLot.Size = new Size(273, 27);
            nudQuantiteLot.TabIndex = 27;
            // 
            // dtpDatePeremption
            // 
            dtpDatePeremption.Location = new Point(26, 298);
            dtpDatePeremption.Name = "dtpDatePeremption";
            dtpDatePeremption.Size = new Size(273, 27);
            dtpDatePeremption.TabIndex = 26;
            // 
            // nudPrix
            // 
            nudPrix.Location = new Point(26, 377);
            nudPrix.Name = "nudPrix";
            nudPrix.Size = new Size(273, 27);
            nudPrix.TabIndex = 25;
            // 
            // lblQuantiteLot
            // 
            lblQuantiteLot.AutoSize = true;
            lblQuantiteLot.Location = new Point(26, 427);
            lblQuantiteLot.Name = "lblQuantiteLot";
            lblQuantiteLot.Size = new Size(76, 20);
            lblQuantiteLot.TabIndex = 23;
            lblQuantiteLot.Text = "Quantité *";
            // 
            // lblPrix
            // 
            lblPrix.AutoSize = true;
            lblPrix.Location = new Point(26, 348);
            lblPrix.Name = "lblPrix";
            lblPrix.Size = new Size(135, 20);
            lblPrix.TabIndex = 21;
            lblPrix.Text = "Prix Unitaire (DH) *";
            // 
            // lblDatePeremption
            // 
            lblDatePeremption.AutoSize = true;
            lblDatePeremption.Location = new Point(26, 269);
            lblDatePeremption.Name = "lblDatePeremption";
            lblDatePeremption.Size = new Size(131, 20);
            lblDatePeremption.TabIndex = 19;
            lblDatePeremption.Text = "Date Péremption *";
            // 
            // txtID_Medicament
            // 
            txtID_Medicament.Location = new Point(26, 140);
            txtID_Medicament.Name = "txtID_Medicament";
            txtID_Medicament.Size = new Size(273, 27);
            txtID_Medicament.TabIndex = 18;
            // 
            // lblID_Medicament
            // 
            lblID_Medicament.AutoSize = true;
            lblID_Medicament.Location = new Point(26, 111);
            lblID_Medicament.Name = "lblID_Medicament";
            lblID_Medicament.Size = new Size(111, 20);
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
            Name = "FormGestionLots";
            Text = "FormGestionLots";
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
    }
}