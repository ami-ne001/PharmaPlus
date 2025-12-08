namespace PharmaPlus
{
    partial class FormHistorique
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
            dgvHistorique = new DataGridView();
            DateHeure = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lblNombreActions = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnRetour = new Button();
            btnRafraichir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorique).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHistorique
            // 
            dgvHistorique.AllowUserToAddRows = false;
            dgvHistorique.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 85, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvHistorique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorique.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorique.Columns.AddRange(new DataGridViewColumn[] { DateHeure, Action });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorique.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorique.EnableHeadersVisualStyles = false;
            dgvHistorique.Location = new Point(21, 66);
            dgvHistorique.MultiSelect = false;
            dgvHistorique.Name = "dgvHistorique";
            dgvHistorique.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHistorique.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorique.RowHeadersWidth = 51;
            dgvHistorique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorique.Size = new Size(1220, 407);
            dgvHistorique.TabIndex = 25;
            // 
            // DateHeure
            // 
            DateHeure.HeaderText = "Date et Heure";
            DateHeure.MinimumWidth = 6;
            DateHeure.Name = "DateHeure";
            DateHeure.ReadOnly = true;
            DateHeure.Width = 180;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Width = 1040;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNombreActions);
            panel1.Controls.Add(dgvHistorique);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 500);
            panel1.TabIndex = 26;
            // 
            // lblNombreActions
            // 
            lblNombreActions.AutoSize = true;
            lblNombreActions.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblNombreActions.Location = new Point(47, 25);
            lblNombreActions.Name = "lblNombreActions";
            lblNombreActions.Size = new Size(236, 25);
            lblNombreActions.TabIndex = 48;
            lblNombreActions.Text = "Nombre total d'actions : 0";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnRetour);
            panel2.Controls.Add(btnRafraichir);
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
            label1.Size = new Size(423, 20);
            label1.TabIndex = 47;
            label1.Text = "Historique complet de toutes les actions effectuées sur le système";
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
            btnRetour.Click += btnRetour_Click;
            // 
            // btnRafraichir
            // 
            btnRafraichir.BackColor = Color.FromArgb(0, 85, 70);
            btnRafraichir.FlatStyle = FlatStyle.Popup;
            btnRafraichir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRafraichir.ForeColor = SystemColors.HighlightText;
            btnRafraichir.Location = new Point(260, 60);
            btnRafraichir.Name = "btnRafraichir";
            btnRafraichir.Size = new Size(131, 32);
            btnRafraichir.TabIndex = 44;
            btnRafraichir.Text = "Rafraîchir";
            btnRafraichir.UseVisualStyleBackColor = false;
            btnRafraichir.Click += btnRafraichir_Click;
            // 
            // FormHistorique
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormHistorique";
            Text = "PharmaPlus - Historique";
            Load += FormHistorique_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorique).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorique;
        private Panel panel1;
        private Panel panel2;
        private Button btnRafraichir;
        private Button btnRetour;
        private Label label1;
        private Label lblNombreActions;
        private DataGridViewTextBoxColumn DateHeure;
        private DataGridViewTextBoxColumn Action;
    }
}

