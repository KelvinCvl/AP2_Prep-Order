namespace AP2_Prep_Order
{
    partial class ConnexionCariste
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
            this.demandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmationDeStockageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDuStockageEnHauteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demandeToolStripMenuItem,
            this.confirmationDeStockageToolStripMenuItem,
            this.gestionDuStockageEnHauteurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // demandeToolStripMenuItem
            // 
            this.demandeToolStripMenuItem.Name = "demandeToolStripMenuItem";
            this.demandeToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.demandeToolStripMenuItem.Text = "Demande";
            this.demandeToolStripMenuItem.Click += new System.EventHandler(this.demandeToolStripMenuItem_Click);
            // 
            // confirmationDeStockageToolStripMenuItem
            // 
            this.confirmationDeStockageToolStripMenuItem.Name = "confirmationDeStockageToolStripMenuItem";
            this.confirmationDeStockageToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.confirmationDeStockageToolStripMenuItem.Text = "Confirmation de Stockage";
            this.confirmationDeStockageToolStripMenuItem.Click += new System.EventHandler(this.confirmationDeStockageToolStripMenuItem_Click_1);
            // 
            // gestionDuStockageEnHauteurToolStripMenuItem
            // 
            this.gestionDuStockageEnHauteurToolStripMenuItem.Name = "gestionDuStockageEnHauteurToolStripMenuItem";
            this.gestionDuStockageEnHauteurToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.gestionDuStockageEnHauteurToolStripMenuItem.Text = "Gestion du Stockage en Hauteur";
            this.gestionDuStockageEnHauteurToolStripMenuItem.Click += new System.EventHandler(this.gestionDuStockageEnHauteurToolStripMenuItem_Click);
            // 
            // ConnexionCariste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConnexionCariste";
            this.Text = "ConnexionCariste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnexionCariste_FormClosing);
            this.Load += new System.EventHandler(this.ConnexionCariste_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem demandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmationDeStockageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDuStockageEnHauteurToolStripMenuItem;
    }
}