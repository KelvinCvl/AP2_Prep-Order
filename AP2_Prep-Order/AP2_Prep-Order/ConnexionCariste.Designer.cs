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
            this.demandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmationDeStockageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demandesToolStripMenuItem,
            this.confirmationDeStockageToolStripMenuItem,
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // demandesToolStripMenuItem
            // 
            this.demandesToolStripMenuItem.Name = "demandesToolStripMenuItem";
            this.demandesToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.demandesToolStripMenuItem.Text = "Demandes ";
            this.demandesToolStripMenuItem.Click += new System.EventHandler(this.demandesToolStripMenuItem_Click);
            // 
            // confirmationDeStockageToolStripMenuItem
            // 
            this.confirmationDeStockageToolStripMenuItem.Name = "confirmationDeStockageToolStripMenuItem";
            this.confirmationDeStockageToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.confirmationDeStockageToolStripMenuItem.Text = "Confirmation de Stockage";
            this.confirmationDeStockageToolStripMenuItem.Click += new System.EventHandler(this.confirmationDeStockageToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.gestionToolStripMenuItem.Text = "Gestion du Stockage en Hauteur";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // ConnexionCariste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 541);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConnexionCariste";
            this.Text = "ConnexionCariste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnexionCariste_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem demandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmationDeStockageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
    }
}