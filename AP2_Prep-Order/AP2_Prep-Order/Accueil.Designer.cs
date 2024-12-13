namespace AP2_Prep_Order
{
    partial class Accueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.préparateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caristeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteManquanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préparateurToolStripMenuItem,
            this.caristeToolStripMenuItem,
            this.responsableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // préparateurToolStripMenuItem
            // 
            this.préparateurToolStripMenuItem.Name = "préparateurToolStripMenuItem";
            this.préparateurToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.préparateurToolStripMenuItem.Text = "Préparateur";
            this.préparateurToolStripMenuItem.Click += new System.EventHandler(this.préparateurToolStripMenuItem_Click);
            // 
            // caristeToolStripMenuItem
            // 
            this.caristeToolStripMenuItem.Name = "caristeToolStripMenuItem";
            this.caristeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.caristeToolStripMenuItem.Text = "Cariste";
            // 
            // responsableToolStripMenuItem
            // 
            this.responsableToolStripMenuItem.Name = "responsableToolStripMenuItem";
            this.responsableToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.responsableToolStripMenuItem.Text = "Responsable";
            this.responsableToolStripMenuItem.Click += new System.EventHandler(this.responsableToolStripMenuItem_Click);
            // 
            // paletteManquanteToolStripMenuItem
            // 
            this.paletteManquanteToolStripMenuItem.Name = "paletteManquanteToolStripMenuItem";
            this.paletteManquanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paletteManquanteToolStripMenuItem.Text = "palette manquante";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accueil";
            this.Text = "Page d\'accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem préparateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caristeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletteManquanteToolStripMenuItem;
    }
}