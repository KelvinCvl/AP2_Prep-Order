namespace AP2_Prep_Order
{
    partial class PalettesManquantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_zone = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Allée = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Étage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emplacement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Article = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantité = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zone de Picking :";
            // 
            // cb_zone
            // 
            this.cb_zone.FormattingEnabled = true;
            this.cb_zone.Location = new System.Drawing.Point(434, 27);
            this.cb_zone.Name = "cb_zone";
            this.cb_zone.Size = new System.Drawing.Size(223, 24);
            this.cb_zone.TabIndex = 3;
            this.cb_zone.SelectedIndexChanged += new System.EventHandler(this.cb_zone_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Allée,
            this.Étage,
            this.Emplacement,
            this.Article,
            this.Quantité});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(739, 463);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Allée
            // 
            this.Allée.Text = "Allée";
            this.Allée.Width = 100;
            // 
            // Étage
            // 
            this.Étage.Text = "Étage";
            this.Étage.Width = 100;
            // 
            // Emplacement
            // 
            this.Emplacement.Text = "Emplacement";
            this.Emplacement.Width = 120;
            // 
            // Article
            // 
            this.Article.Text = "Article";
            this.Article.Width = 140;
            // 
            // Quantité
            // 
            this.Quantité.Text = "Quantité";
            this.Quantité.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Remplissez avec bonne quantité et articles les palettes ";
            // 
            // PalettesManquantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cb_zone);
            this.Controls.Add(this.label1);
            this.Name = "PalettesManquantes";
            this.Text = "PalettesManquantes";
            this.Load += new System.EventHandler(this.PalettesManquantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_zone;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Allée;
        private System.Windows.Forms.ColumnHeader Étage;
        private System.Windows.Forms.ColumnHeader Emplacement;
        private System.Windows.Forms.ColumnHeader Article;
        private System.Windows.Forms.ColumnHeader Quantité;
        private System.Windows.Forms.Label label2;
    }
}