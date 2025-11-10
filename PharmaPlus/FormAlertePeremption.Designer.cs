namespace PharmaPlus
{
    partial class FormAlertePeremption
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
            dgvMedicaments = new DataGridView();
            Nom = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            ID_Lot = new DataGridViewTextBoxColumn();
            NumeroLot = new DataGridViewTextBoxColumn();
            DatePeremption = new DataGridViewTextBoxColumn();
            QuantiteLot = new DataGridViewTextBoxColumn();
            JoursRestants = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lblNombreAlertes = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnRetour = new Button();
            nudJoursAvance = new NumericUpDown();
            btnRechercher = new Button();
            lblJoursAvance = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJoursAvance).BeginInit();
            SuspendLayout();
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
            dgvMedicaments.Columns.AddRange(new DataGridViewColumn[] { Nom, Reference, ID_Lot, NumeroLot, DatePeremption, QuantiteLot, JoursRestants, Status });
            dgvMedicaments.EnableHeadersVisualStyles = false;
            dgvMedicaments.Location = new Point(47, 66);
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.Size = new Size(1168, 407);
            dgvMedicaments.TabIndex = 25;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom Médicament";
            Nom.MinimumWidth = 6;
            Nom.Name = "Nom";
            Nom.Width = 160;
            // 
            // Reference
            // 
            Reference.HeaderText = "Réference";
            Reference.MinimumWidth = 6;
            Reference.Name = "Reference";
            Reference.Width = 130;
            // 
            // ID_Lot
            // 
            ID_Lot.HeaderText = "ID Lot";
            ID_Lot.MinimumWidth = 6;
            ID_Lot.Name = "ID_Lot";
            ID_Lot.Width = 125;
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
            // QuantiteLot
            // 
            QuantiteLot.HeaderText = "Quantité";
            QuantiteLot.MinimumWidth = 6;
            QuantiteLot.Name = "QuantiteLot";
            QuantiteLot.Width = 130;
            // 
            // JoursRestants
            // 
            JoursRestants.HeaderText = "Jours Restants";
            JoursRestants.MinimumWidth = 6;
            JoursRestants.Name = "JoursRestants";
            JoursRestants.Width = 130;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNombreAlertes);
            panel1.Controls.Add(dgvMedicaments);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 500);
            panel1.TabIndex = 26;
            // 
            // lblNombreAlertes
            // 
            lblNombreAlertes.AutoSize = true;
            lblNombreAlertes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblNombreAlertes.Location = new Point(47, 25);
            lblNombreAlertes.Name = "lblNombreAlertes";
            lblNombreAlertes.Size = new Size(262, 25);
            lblNombreAlertes.TabIndex = 48;
            lblNombreAlertes.Text = "Nombre de lots concernés : 0";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnRetour);
            panel2.Controls.Add(nudJoursAvance);
            panel2.Controls.Add(btnRechercher);
            panel2.Controls.Add(lblJoursAvance);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 171);
            panel2.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 98);
            label1.Name = "label1";
            label1.Size = new Size(553, 20);
            label1.TabIndex = 47;
            label1.Text = "Cette recherche affiche les lots périmés et ceux qui périmeront dans les X jours à venir";
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
            btnRetour.TabIndex = 46;
            btnRetour.Text = "< Retour";
            btnRetour.UseVisualStyleBackColor = false;
            // 
            // nudJoursAvance
            // 
            nudJoursAvance.Font = new Font("Segoe UI", 11F);
            nudJoursAvance.Location = new Point(505, 61);
            nudJoursAvance.Name = "nudJoursAvance";
            nudJoursAvance.Size = new Size(215, 32);
            nudJoursAvance.TabIndex = 45;
            nudJoursAvance.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // btnRechercher
            // 
            btnRechercher.BackColor = Color.FromArgb(0, 85, 70);
            btnRechercher.FlatStyle = FlatStyle.Popup;
            btnRechercher.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechercher.ForeColor = SystemColors.HighlightText;
            btnRechercher.Location = new Point(761, 60);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(131, 32);
            btnRechercher.TabIndex = 44;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = false;
            // 
            // lblJoursAvance
            // 
            lblJoursAvance.AutoSize = true;
            lblJoursAvance.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblJoursAvance.Location = new Point(260, 63);
            lblJoursAvance.Name = "lblJoursAvance";
            lblJoursAvance.Size = new Size(226, 25);
            lblJoursAvance.TabIndex = 43;
            lblJoursAvance.Text = "Alerter X jours à l'avance";
            // 
            // FormAlertePeremption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAlertePeremption";
            Text = "PharmaPlus - Alertes Péremptions";
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJoursAvance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMedicaments;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn ID_Lot;
        private DataGridViewTextBoxColumn NumeroLot;
        private DataGridViewTextBoxColumn DatePeremption;
        private DataGridViewTextBoxColumn QuantiteLot;
        private DataGridViewTextBoxColumn JoursRestants;
        private DataGridViewTextBoxColumn Status;
        private Panel panel1;
        private Panel panel2;
        private Button btnRechercher;
        private Label lblJoursAvance;
        private NumericUpDown nudJoursAvance;
        private Button btnRetour;
        private Label label1;
        private Label lblNombreAlertes;
    }
}