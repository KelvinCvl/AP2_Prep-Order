namespace AP2_Prep_Order
{
    partial class StatutPrep
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
            this.lv_statutPrep = new System.Windows.Forms.ListView();
            this.Commandes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Signaler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_statutPrep
            // 
            this.lv_statutPrep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Commandes,
            this.Statut,
            this.Signaler});
            this.lv_statutPrep.HideSelection = false;
            this.lv_statutPrep.Location = new System.Drawing.Point(12, 72);
            this.lv_statutPrep.Name = "lv_statutPrep";
            this.lv_statutPrep.Size = new System.Drawing.Size(776, 366);
            this.lv_statutPrep.TabIndex = 0;
            this.lv_statutPrep.UseCompatibleStateImageBehavior = false;
            this.lv_statutPrep.View = System.Windows.Forms.View.Details;
            // 
            // Commandes
            // 
            this.Commandes.Text = "Commandes";
            this.Commandes.Width = 250;
            // 
            // Statut
            // 
            this.Statut.Text = "Statut";
            this.Statut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Statut.Width = 250;
            // 
            // Signaler
            // 
            this.Signaler.Text = "Signaler";
            this.Signaler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Signaler.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statut des préparations :";
            // 
            // StatutPrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_statutPrep);
            this.Name = "StatutPrep";
            this.Text = "StatutPrep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_statutPrep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Commandes;
        private System.Windows.Forms.ColumnHeader Statut;
        private System.Windows.Forms.ColumnHeader Signaler;
    }
}