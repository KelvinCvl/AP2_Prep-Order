namespace AP2_Prep_Order
{
    partial class VisualiserCommandesResponsable
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
            this.lv_commande = new System.Windows.Forms.ListView();
            this.idCommande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jourPreparation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preparateur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_sous_commande = new System.Windows.Forms.ListView();
            this.idSous = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idZone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_commander = new System.Windows.Forms.ListView();
            this.Article = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_commande
            // 
            this.lv_commande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCommande,
            this.jourPreparation,
            this.preparateur});
            this.lv_commande.HideSelection = false;
            this.lv_commande.Location = new System.Drawing.Point(12, 33);
            this.lv_commande.Name = "lv_commande";
            this.lv_commande.Size = new System.Drawing.Size(348, 326);
            this.lv_commande.TabIndex = 0;
            this.lv_commande.UseCompatibleStateImageBehavior = false;
            this.lv_commande.View = System.Windows.Forms.View.Details;
            this.lv_commande.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_commande_ItemSelectionChanged);
            // 
            // idCommande
            // 
            this.idCommande.Text = "idCommande";
            this.idCommande.Width = 100;
            // 
            // jourPreparation
            // 
            this.jourPreparation.Text = "jourPreparation";
            this.jourPreparation.Width = 120;
            // 
            // preparateur
            // 
            this.preparateur.Text = "preparateur";
            this.preparateur.Width = 100;
            // 
            // lv_sous_commande
            // 
            this.lv_sous_commande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idSous,
            this.idZone});
            this.lv_sous_commande.HideSelection = false;
            this.lv_sous_commande.Location = new System.Drawing.Point(366, 33);
            this.lv_sous_commande.Name = "lv_sous_commande";
            this.lv_sous_commande.Size = new System.Drawing.Size(213, 326);
            this.lv_sous_commande.TabIndex = 1;
            this.lv_sous_commande.UseCompatibleStateImageBehavior = false;
            this.lv_sous_commande.View = System.Windows.Forms.View.Details;
            this.lv_sous_commande.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_sous_commande_ItemSelectionChanged);
            // 
            // idSous
            // 
            this.idSous.Text = "Sous commande";
            this.idSous.Width = 100;
            // 
            // idZone
            // 
            this.idZone.Text = "Zone";
            this.idZone.Width = 100;
            // 
            // lv_commander
            // 
            this.lv_commander.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Article,
            this.quantite});
            this.lv_commander.HideSelection = false;
            this.lv_commander.Location = new System.Drawing.Point(585, 33);
            this.lv_commander.Name = "lv_commander";
            this.lv_commander.Size = new System.Drawing.Size(213, 326);
            this.lv_commander.TabIndex = 2;
            this.lv_commander.UseCompatibleStateImageBehavior = false;
            this.lv_commander.View = System.Windows.Forms.View.Details;
            // 
            // Article
            // 
            this.Article.Text = "Article";
            this.Article.Width = 100;
            // 
            // quantite
            // 
            this.quantite.Text = "quantite";
            this.quantite.Width = 100;
            // 
            // VisualiserCommandesResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 601);
            this.Controls.Add(this.lv_commander);
            this.Controls.Add(this.lv_sous_commande);
            this.Controls.Add(this.lv_commande);
            this.Name = "VisualiserCommandesResponsable";
            this.Text = "VisualiserCommandesResponsable";
            this.Load += new System.EventHandler(this.VisualiserCommandesResponsable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_commande;
        private System.Windows.Forms.ColumnHeader idCommande;
        private System.Windows.Forms.ColumnHeader jourPreparation;
        private System.Windows.Forms.ColumnHeader preparateur;
        private System.Windows.Forms.ListView lv_sous_commande;
        private System.Windows.Forms.ColumnHeader idSous;
        private System.Windows.Forms.ColumnHeader idZone;
        private System.Windows.Forms.ListView lv_commander;
        private System.Windows.Forms.ColumnHeader Article;
        private System.Windows.Forms.ColumnHeader quantite;
    }
}