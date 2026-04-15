namespace PharmaPlus
{
    partial class FormConsulterCommandes
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnRetour = new Button();
            btnRafraichir = new Button();
            txtRecherche = new TextBox();
            label6 = new Label();
            lblTotalCommandes = new Label();
            dgvCommandes = new DataGridView();
            panel2 = new Panel();
            dgvDetailsCommande = new DataGridView();
            label7 = new Label();
            txtMontantTotal = new TextBox();
            label4 = new Label();
            txtDateCommande = new TextBox();
            label3 = new Label();
            txtNomClient = new TextBox();
            label2 = new Label();
            txtCodeClient = new TextBox();
            label1 = new Label();
            lblTitre = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailsCommande).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRetour);
            panel1.Controls.Add(btnRafraichir);
            panel1.Controls.Add(txtRecherche);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblTotalCommandes);
            panel1.Controls.Add(dgvCommandes);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 673);
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
            // 
            // btnRafraichir
            // 
            btnRafraichir.BackColor = Color.FromArgb(0, 85, 70);
            btnRafraichir.FlatStyle = FlatStyle.Popup;
            btnRafraichir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRafraichir.ForeColor = SystemColors.HighlightText;
            btnRafraichir.Location = new Point(466, 49);
            btnRafraichir.Name = "btnRafraichir";
            btnRafraichir.Size = new Size(130, 29);
            btnRafraichir.TabIndex = 25;
            btnRafraichir.Text = "Rafraîchir";
            btnRafraichir.UseVisualStyleBackColor = false;
            // 
            // txtRecherche
            // 
            txtRecherche.Font = new Font("Segoe UI", 10F);
            txtRecherche.Location = new Point(150, 48);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.PlaceholderText = "Rechercher par client ou code...";
            txtRecherche.Size = new Size(291, 30);
            txtRecherche.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 52);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 23;
            label6.Text = "Rechercher";
            // 
            // lblTotalCommandes
            // 
            lblTotalCommandes.AutoSize = true;
            lblTotalCommandes.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCommandes.ForeColor = Color.Black;
            lblTotalCommandes.Location = new Point(20, 80);
            lblTotalCommandes.Name = "lblTotalCommandes";
            lblTotalCommandes.Size = new Size(220, 25);
            lblTotalCommandes.TabIndex = 27;
            lblTotalCommandes.Text = "Total de commandes : 0";
            // 
            // dgvCommandes
            // 
            dgvCommandes.AllowUserToAddRows = false;
            dgvCommandes.AllowUserToDeleteRows = false;
            dgvCommandes.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 85, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCommandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCommandes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCommandes.EnableHeadersVisualStyles = false;
            dgvCommandes.Location = new Point(20, 117);
            dgvCommandes.MultiSelect = false;
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCommandes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCommandes.RowHeadersWidth = 51;
            dgvCommandes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCommandes.Size = new Size(600, 543);
            dgvCommandes.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvDetailsCommande);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtMontantTotal);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtDateCommande);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNomClient);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtCodeClient);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTitre);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(642, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 673);
            panel2.TabIndex = 1;
            // 
            // dgvDetailsCommande
            // 
            dgvDetailsCommande.AllowUserToAddRows = false;
            dgvDetailsCommande.AllowUserToDeleteRows = false;
            dgvDetailsCommande.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 85, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDetailsCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetailsCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDetailsCommande.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDetailsCommande.EnableHeadersVisualStyles = false;
            dgvDetailsCommande.Location = new Point(24, 368);
            dgvDetailsCommande.MultiSelect = false;
            dgvDetailsCommande.Name = "dgvDetailsCommande";
            dgvDetailsCommande.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 160, 120);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDetailsCommande.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvDetailsCommande.RowHeadersWidth = 51;
            dgvDetailsCommande.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetailsCommande.Size = new Size(572, 279);
            dgvDetailsCommande.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 85, 70);
            label7.Location = new Point(24, 340);
            label7.Name = "label7";
            label7.Size = new Size(218, 25);
            label7.TabIndex = 12;
            label7.Text = "Détails de la commande";
            // 
            // txtMontantTotal
            // 
            txtMontantTotal.Font = new Font("Segoe UI", 11F);
            txtMontantTotal.Location = new Point(24, 277);
            txtMontantTotal.Name = "txtMontantTotal";
            txtMontantTotal.ReadOnly = true;
            txtMontantTotal.Size = new Size(572, 32);
            txtMontantTotal.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 249);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 8;
            label4.Text = "Montant Total";
            // 
            // txtDateCommande
            // 
            txtDateCommande.Font = new Font("Segoe UI", 11F);
            txtDateCommande.Location = new Point(24, 211);
            txtDateCommande.Name = "txtDateCommande";
            txtDateCommande.ReadOnly = true;
            txtDateCommande.Size = new Size(572, 32);
            txtDateCommande.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 183);
            label3.Name = "label3";
            label3.Size = new Size(161, 23);
            label3.TabIndex = 6;
            label3.Text = "Date de commande";
            // 
            // txtNomClient
            // 
            txtNomClient.Font = new Font("Segoe UI", 11F);
            txtNomClient.Location = new Point(296, 145);
            txtNomClient.Name = "txtNomClient";
            txtNomClient.ReadOnly = true;
            txtNomClient.Size = new Size(300, 32);
            txtNomClient.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(296, 117);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 4;
            label2.Text = "Nom Client";
            // 
            // txtCodeClient
            // 
            txtCodeClient.Font = new Font("Segoe UI", 11F);
            txtCodeClient.Location = new Point(24, 145);
            txtCodeClient.Name = "txtCodeClient";
            txtCodeClient.ReadOnly = true;
            txtCodeClient.Size = new Size(240, 32);
            txtCodeClient.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 117);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 2;
            label1.Text = "Code Client";
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = Color.FromArgb(0, 85, 70);
            lblTitre.Location = new Point(24, 20);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(572, 79);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Détails de la Commande";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormConsulterCommandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormConsulterCommandes";
            Text = "PharmaPlus - Consulter les Commandes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailsCommande).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvCommandes;
        private Panel panel2;
        private Label lblTitre;
        private Button btnRetour;
        private Button btnRafraichir;
        private TextBox txtRecherche;
        private Label label6;
        private TextBox txtCodeClient;
        private Label label1;
        private TextBox txtNomClient;
        private Label label2;
        private TextBox txtDateCommande;
        private Label label3;
        private TextBox txtMontantTotal;
        private Label label4;
        private Label label7;
        private DataGridView dgvDetailsCommande;
        private Label lblTotalCommandes;
    }
}
