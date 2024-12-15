namespace AP2_Prep_Order
{
    partial class ImporterResponsable
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_working = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Imorter un fichier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_error.Location = new System.Drawing.Point(140, 27);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(245, 25);
            this.lbl_error.TabIndex = 1;
            this.lbl_error.Text = "Échec de l\'importation";
            // 
            // lbl_working
            // 
            this.lbl_working.AutoSize = true;
            this.lbl_working.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_working.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_working.Location = new System.Drawing.Point(140, 27);
            this.lbl_working.Name = "lbl_working";
            this.lbl_working.Size = new System.Drawing.Size(214, 25);
            this.lbl_working.TabIndex = 2;
            this.lbl_working.Text = "Importation réussi !";
            // 
            // ImporterResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 496);
            this.Controls.Add(this.lbl_working);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.button1);
            this.Name = "ImporterResponsable";
            this.Text = "ImporterResponsable";
            this.Load += new System.EventHandler(this.ImporterResponsable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_working;
    }
}