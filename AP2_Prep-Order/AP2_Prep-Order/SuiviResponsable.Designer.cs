namespace AP2_Prep_Order
{
    partial class SuiviResponsable
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lv_commandes = new System.Windows.Forms.ListView();
            this.idCommande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jourPrepa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idRespo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lv_commandes
            // 
            this.lv_commandes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCommande,
            this.jourPrepa,
            this.idRespo,
            this.Etat});
            this.lv_commandes.HideSelection = false;
            this.lv_commandes.Location = new System.Drawing.Point(48, 82);
            this.lv_commandes.Name = "lv_commandes";
            this.lv_commandes.Size = new System.Drawing.Size(493, 292);
            this.lv_commandes.TabIndex = 1;
            this.lv_commandes.UseCompatibleStateImageBehavior = false;
            this.lv_commandes.View = System.Windows.Forms.View.Details;
            // 
            // idCommande
            // 
            this.idCommande.Text = "id Commande";
            this.idCommande.Width = 120;
            // 
            // jourPrepa
            // 
            this.jourPrepa.Text = "jour Préparation";
            this.jourPrepa.Width = 120;
            // 
            // idRespo
            // 
            this.idRespo.Text = "id Rresponsable";
            this.idRespo.Width = 120;
            // 
            // Etat
            // 
            this.Etat.Text = "État";
            this.Etat.Width = 120;
            // 
            // SuiviResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_commandes);
            this.Controls.Add(this.comboBox1);
            this.Name = "SuiviResponsable";
            this.Text = "SuiviResponsable";
            this.Load += new System.EventHandler(this.SuiviResponsable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lv_commandes;
        private System.Windows.Forms.ColumnHeader idCommande;
        private System.Windows.Forms.ColumnHeader jourPrepa;
        private System.Windows.Forms.ColumnHeader idRespo;
        private System.Windows.Forms.ColumnHeader Etat;
    }
}