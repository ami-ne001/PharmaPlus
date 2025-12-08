namespace PharmaPlus
{
    partial class FormAlerteStockes
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
            panel1 = new Panel();
            lblNombreAlertes = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnRetour = new Button();
            btnReinitialiser = new Button();
            txtRechercherReference = new TextBox();
            lblRechercherReference = new Label();
            btnRechercher = new Button();
            Nom = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            Categorie = new DataGridViewTextBoxColumn();
            Fabricant = new DataGridViewTextBoxColumn();
            QuantiteTotale = new DataGridViewTextBoxColumn();
            SeuilAlerteStock = new DataGridViewTextBoxColumn();
            Statut = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMedicaments
            // 
            dgvMedicaments.AllowUserToAddRows = false;
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
            dgvMedicaments.Columns.AddRange(new DataGridViewColumn[] { Nom, Reference, Categorie, Fabricant, QuantiteTotale, SeuilAlerteStock, Statut });
            dgvMedicaments.EnableHeadersVisualStyles = false;
            dgvMedicaments.Location = new Point(21, 66);
            dgvMedicaments.MultiSelect = false;
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.ReadOnly = true;
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicaments.Size = new Size(1220, 407);
            dgvMedicaments.TabIndex = 25;
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
            lblNombreAlertes.Size = new Size(336, 25);
            lblNombreAlertes.TabIndex = 48;
            lblNombreAlertes.Text = "Nombre de médicaments en alerte : 0";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnRetour);
            panel2.Controls.Add(btnReinitialiser);
            panel2.Controls.Add(txtRechercherReference);
            panel2.Controls.Add(lblRechercherReference);
            panel2.Controls.Add(btnRechercher);
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
            label1.Size = new Size(566, 20);
            label1.TabIndex = 47;
            label1.Text = "Cette recherche affiche les médicaments avec un stock inférieur ou égal au seuil d'alerte";
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
            // btnReinitialiser
            // 
            btnReinitialiser.BackColor = Color.FromArgb(0, 85, 70);
            btnReinitialiser.FlatStyle = FlatStyle.Popup;
            btnReinitialiser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReinitialiser.ForeColor = SystemColors.HighlightText;
            btnReinitialiser.Location = new Point(530, 60);
            btnReinitialiser.Name = "btnReinitialiser";
            btnReinitialiser.Size = new Size(120, 32);
            btnReinitialiser.TabIndex = 49;
            btnReinitialiser.Text = "Réinitialiser";
            btnReinitialiser.UseVisualStyleBackColor = false;
            btnReinitialiser.Click += btnReinitialiser_Click;
            // 
            // txtRechercherReference
            // 
            txtRechercherReference.Font = new Font("Segoe UI", 10F);
            txtRechercherReference.Location = new Point(260, 60);
            txtRechercherReference.Name = "txtRechercherReference";
            txtRechercherReference.Size = new Size(200, 30);
            txtRechercherReference.TabIndex = 48;
            // 
            // lblRechercherReference
            // 
            lblRechercherReference.AutoSize = true;
            lblRechercherReference.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRechercherReference.Location = new Point(260, 32);
            lblRechercherReference.Name = "lblRechercherReference";
            lblRechercherReference.Size = new Size(226, 25);
            lblRechercherReference.TabIndex = 47;
            lblRechercherReference.Text = "Rechercher par référence";
            // 
            // btnRechercher
            // 
            btnRechercher.BackColor = Color.FromArgb(0, 85, 70);
            btnRechercher.FlatStyle = FlatStyle.Popup;
            btnRechercher.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechercher.ForeColor = SystemColors.HighlightText;
            btnRechercher.Location = new Point(466, 60);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(58, 32);
            btnRechercher.TabIndex = 44;
            btnRechercher.Text = "OK";
            btnRechercher.UseVisualStyleBackColor = false;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom Médicament";
            Nom.MinimumWidth = 6;
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            Nom.Width = 200;
            // 
            // Reference
            // 
            Reference.HeaderText = "Référence";
            Reference.MinimumWidth = 6;
            Reference.Name = "Reference";
            Reference.ReadOnly = true;
            Reference.Width = 150;
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
            Fabricant.Width = 150;
            // 
            // QuantiteTotale
            // 
            QuantiteTotale.HeaderText = "Quantité";
            QuantiteTotale.MinimumWidth = 6;
            QuantiteTotale.Name = "QuantiteTotale";
            QuantiteTotale.ReadOnly = true;
            QuantiteTotale.Width = 120;
            // 
            // SeuilAlerteStock
            // 
            SeuilAlerteStock.HeaderText = "Seuil d'Alerte";
            SeuilAlerteStock.MinimumWidth = 6;
            SeuilAlerteStock.Name = "SeuilAlerteStock";
            SeuilAlerteStock.ReadOnly = true;
            SeuilAlerteStock.Width = 150;
            // 
            // Statut
            // 
            Statut.HeaderText = "Statut";
            Statut.MinimumWidth = 6;
            Statut.Name = "Statut";
            Statut.ReadOnly = true;
            Statut.Width = 220;
            // 
            // FormAlerteStockes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAlerteStockes";
            Text = "PharmaPlus - Alertes de Stock";
            Load += FormAlerteStockes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMedicaments;
        private Panel panel1;
        private Panel panel2;
        private Button btnRechercher;
        private Button btnRetour;
        private Label label1;
        private Label lblNombreAlertes;
        private Button btnReinitialiser;
        private TextBox txtRechercherReference;
        private Label lblRechercherReference;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Categorie;
        private DataGridViewTextBoxColumn Fabricant;
        private DataGridViewTextBoxColumn QuantiteTotale;
        private DataGridViewTextBoxColumn SeuilAlerteStock;
        private DataGridViewTextBoxColumn Statut;
    }
}

