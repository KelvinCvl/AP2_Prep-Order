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
            this.cb_palette_vide = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_palette_remplie = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_vide = new System.Windows.Forms.Button();
            this.btn_plein = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Palette remise en zone de picking après remplissage :";
            // 
            // cb_palette_vide
            // 
            this.cb_palette_vide.FormattingEnabled = true;
            this.cb_palette_vide.Location = new System.Drawing.Point(568, 89);
            this.cb_palette_vide.Name = "cb_palette_vide";
            this.cb_palette_vide.Size = new System.Drawing.Size(121, 24);
            this.cb_palette_vide.TabIndex = 6;
            this.cb_palette_vide.SelectedIndexChanged += new System.EventHandler(this.cb_palette_vide_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "[Erreur] Remettre une palette en statut non remplie :";
            // 
            // cb_palette_remplie
            // 
            this.cb_palette_remplie.FormattingEnabled = true;
            this.cb_palette_remplie.Location = new System.Drawing.Point(568, 194);
            this.cb_palette_remplie.Name = "cb_palette_remplie";
            this.cb_palette_remplie.Size = new System.Drawing.Size(121, 24);
            this.cb_palette_remplie.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_vide
            // 
            this.btn_vide.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_vide.Enabled = false;
            this.btn_vide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vide.Location = new System.Drawing.Point(20, 125);
            this.btn_vide.Name = "btn_vide";
            this.btn_vide.Size = new System.Drawing.Size(180, 57);
            this.btn_vide.TabIndex = 10;
            this.btn_vide.Text = "Valider";
            this.btn_vide.UseVisualStyleBackColor = false;
            // 
            // btn_plein
            // 
            this.btn_plein.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_plein.Enabled = false;
            this.btn_plein.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plein.Location = new System.Drawing.Point(20, 234);
            this.btn_plein.Name = "btn_plein";
            this.btn_plein.Size = new System.Drawing.Size(180, 57);
            this.btn_plein.TabIndex = 11;
            this.btn_plein.Text = "Valider";
            this.btn_plein.UseVisualStyleBackColor = false;
            this.btn_plein.Click += new System.EventHandler(this.button3_Click);
            // 
            // ConfirmationStockage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_plein);
            this.Controls.Add(this.btn_vide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_palette_remplie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_palette_vide);
            this.Controls.Add(this.label2);
            this.Name = "ConfirmationStockage";
            this.Text = "ConfirmationStockage";
            this.Load += new System.EventHandler(this.ConfirmationStockage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_palette_vide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_palette_remplie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_vide;
        private System.Windows.Forms.Button btn_plein;
    }
}