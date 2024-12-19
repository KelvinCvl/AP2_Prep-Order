namespace AP2_Prep_Order
{
    partial class ConfirmationStockage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_vide = new System.Windows.Forms.ComboBox();
            this.cb_remplie = new System.Windows.Forms.ComboBox();
            this.btn_vide = new System.Windows.Forms.Button();
            this.btn_remplie = new System.Windows.Forms.Button();
            this.cb_zone = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Palette remise en zone de picking après remplissage :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "[ERREUR] Remettre une palette en statut non remplie :";
            // 
            // cb_vide
            // 
            this.cb_vide.FormattingEnabled = true;
            this.cb_vide.Location = new System.Drawing.Point(592, 67);
            this.cb_vide.Name = "cb_vide";
            this.cb_vide.Size = new System.Drawing.Size(121, 24);
            this.cb_vide.TabIndex = 7;
            this.cb_vide.SelectedIndexChanged += new System.EventHandler(this.cb_vide_SelectedIndexChanged);
            // 
            // cb_remplie
            // 
            this.cb_remplie.FormattingEnabled = true;
            this.cb_remplie.Location = new System.Drawing.Point(592, 186);
            this.cb_remplie.Name = "cb_remplie";
            this.cb_remplie.Size = new System.Drawing.Size(121, 24);
            this.cb_remplie.TabIndex = 8;
            this.cb_remplie.SelectedIndexChanged += new System.EventHandler(this.cb_remplie_SelectedIndexChanged);
            // 
            // btn_vide
            // 
            this.btn_vide.BackColor = System.Drawing.Color.LightGreen;
            this.btn_vide.Enabled = false;
            this.btn_vide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vide.Location = new System.Drawing.Point(40, 111);
            this.btn_vide.Name = "btn_vide";
            this.btn_vide.Size = new System.Drawing.Size(144, 55);
            this.btn_vide.TabIndex = 9;
            this.btn_vide.Text = "Valider";
            this.btn_vide.UseVisualStyleBackColor = false;
            this.btn_vide.Click += new System.EventHandler(this.btn_vide_Click);
            // 
            // btn_remplie
            // 
            this.btn_remplie.BackColor = System.Drawing.Color.LightGreen;
            this.btn_remplie.Enabled = false;
            this.btn_remplie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remplie.Location = new System.Drawing.Point(40, 223);
            this.btn_remplie.Name = "btn_remplie";
            this.btn_remplie.Size = new System.Drawing.Size(144, 55);
            this.btn_remplie.TabIndex = 10;
            this.btn_remplie.Text = "Valider";
            this.btn_remplie.UseVisualStyleBackColor = false;
            this.btn_remplie.Click += new System.EventHandler(this.btn_remplie_Click);
            // 
            // cb_zone
            // 
            this.cb_zone.FormattingEnabled = true;
            this.cb_zone.Location = new System.Drawing.Point(435, 18);
            this.cb_zone.Name = "cb_zone";
            this.cb_zone.Size = new System.Drawing.Size(121, 24);
            this.cb_zone.TabIndex = 12;
            this.cb_zone.SelectedIndexChanged += new System.EventHandler(this.cb_zone_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zone :";
            // 
            // ConfirmationStockage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_zone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_remplie);
            this.Controls.Add(this.btn_vide);
            this.Controls.Add(this.cb_remplie);
            this.Controls.Add(this.cb_vide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ConfirmationStockage";
            this.Text = "ConfirmationStockage";
            this.Load += new System.EventHandler(this.GestionHauteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_vide;
        private System.Windows.Forms.ComboBox cb_remplie;
        private System.Windows.Forms.Button btn_vide;
        private System.Windows.Forms.Button btn_remplie;
        private System.Windows.Forms.ComboBox cb_zone;
        private System.Windows.Forms.Label label3;
    }
}