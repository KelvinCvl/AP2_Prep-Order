namespace AP2_Prep_Order
{
    partial class GestionHauteur
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
            this.lv_stock = new System.Windows.Forms.ListView();
            this.Emplacement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alleé = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Article = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantité_Restante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.cb_zone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_stock
            // 
            this.lv_stock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Emplacement,
            this.Alleé,
            this.Etage,
            this.Article,
            this.Quantité_Restante});
            this.lv_stock.HideSelection = false;
            this.lv_stock.Location = new System.Drawing.Point(12, 75);
            this.lv_stock.Name = "lv_stock";
            this.lv_stock.Size = new System.Drawing.Size(743, 344);
            this.lv_stock.TabIndex = 9;
            this.lv_stock.UseCompatibleStateImageBehavior = false;
            this.lv_stock.View = System.Windows.Forms.View.Details;
            // 
            // Emplacement
            // 
            this.Emplacement.Text = "Emplacement";
            this.Emplacement.Width = 140;
            // 
            // Alleé
            // 
            this.Alleé.DisplayIndex = 2;
            this.Alleé.Text = "Allée";
            this.Alleé.Width = 80;
            // 
            // Etage
            // 
            this.Etage.DisplayIndex = 1;
            this.Etage.Text = "Etage";
            this.Etage.Width = 80;
            // 
            // Article
            // 
            this.Article.Text = "Article";
            this.Article.Width = 100;
            // 
            // Quantité_Restante
            // 
            this.Quantité_Restante.Text = "Quantité Restante";
            this.Quantité_Restante.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Statut des racks de stockage en hauteur";
            // 
            // cb_zone
            // 
            this.cb_zone.FormattingEnabled = true;
            this.cb_zone.Location = new System.Drawing.Point(329, 14);
            this.cb_zone.Name = "cb_zone";
            this.cb_zone.Size = new System.Drawing.Size(121, 24);
            this.cb_zone.TabIndex = 7;
            this.cb_zone.SelectedIndexChanged += new System.EventHandler(this.cb_zone_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zone :";
            // 
            // GestionHauteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_zone);
            this.Controls.Add(this.label1);
            this.Name = "GestionHauteur";
            this.Text = "GestionHauteur";
            this.Load += new System.EventHandler(this.GestionHauteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_stock;
        private System.Windows.Forms.ColumnHeader Emplacement;
        private System.Windows.Forms.ColumnHeader Alleé;
        private System.Windows.Forms.ColumnHeader Etage;
        private System.Windows.Forms.ColumnHeader Article;
        private System.Windows.Forms.ColumnHeader Quantité_Restante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_zone;
        private System.Windows.Forms.Label label1;
    }
}