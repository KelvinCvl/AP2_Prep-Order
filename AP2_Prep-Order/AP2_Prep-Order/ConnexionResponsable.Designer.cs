namespace AP2_Prep_Order
{
    partial class ConnexionResponsable
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
            this.importerUnFichierCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserLesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignerDesPréparateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerUnFichierCSVToolStripMenuItem,
            this.visualiserLesCommandesToolStripMenuItem,
            this.assignerDesPréparateursToolStripMenuItem,
            this.suiviDesCommandesToolStripMenuItem,
            this.utilisateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importerUnFichierCSVToolStripMenuItem
            // 
            this.importerUnFichierCSVToolStripMenuItem.Name = "importerUnFichierCSVToolStripMenuItem";
            this.importerUnFichierCSVToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.importerUnFichierCSVToolStripMenuItem.Text = "Importer un fichier CSV";
            this.importerUnFichierCSVToolStripMenuItem.Click += new System.EventHandler(this.importerUnFichierCSVToolStripMenuItem_Click);
            // 
            // visualiserLesCommandesToolStripMenuItem
            // 
            this.visualiserLesCommandesToolStripMenuItem.Name = "visualiserLesCommandesToolStripMenuItem";
            this.visualiserLesCommandesToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.visualiserLesCommandesToolStripMenuItem.Text = "Visualiser les commandes";
            this.visualiserLesCommandesToolStripMenuItem.Click += new System.EventHandler(this.visualiserLesCommandesToolStripMenuItem_Click);
            // 
            // assignerDesPréparateursToolStripMenuItem
            // 
            this.assignerDesPréparateursToolStripMenuItem.Name = "assignerDesPréparateursToolStripMenuItem";
            this.assignerDesPréparateursToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.assignerDesPréparateursToolStripMenuItem.Text = "Assigner des préparateurs";
            this.assignerDesPréparateursToolStripMenuItem.Click += new System.EventHandler(this.assignerDesPréparateursToolStripMenuItem_Click);
            // 
            // suiviDesCommandesToolStripMenuItem
            // 
            this.suiviDesCommandesToolStripMenuItem.Name = "suiviDesCommandesToolStripMenuItem";
            this.suiviDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.suiviDesCommandesToolStripMenuItem.Text = "Suivi des commandes";
            this.suiviDesCommandesToolStripMenuItem.Click += new System.EventHandler(this.suiviDesCommandesToolStripMenuItem_Click);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem.Click += new System.EventHandler(this.utilisateursToolStripMenuItem_Click);
            // 
            // ConnexionResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1131, 664);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConnexionResponsable";
            this.Text = "ConnexionResponsable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnexionResponsable_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnexionResponsable_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importerUnFichierCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserLesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignerDesPréparateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiviDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
    }
}