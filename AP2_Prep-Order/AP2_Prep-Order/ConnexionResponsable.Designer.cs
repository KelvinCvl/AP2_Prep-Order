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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_err = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_connect = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_connect);
            this.panel1.Controls.Add(this.btn_connect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_mdp);
            this.panel1.Controls.Add(this.tb_identifiant);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_err);
            this.panel1.Location = new System.Drawing.Point(263, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 264);
            this.panel1.TabIndex = 0;
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err.ForeColor = System.Drawing.Color.Red;
            this.lbl_err.Location = new System.Drawing.Point(13, 58);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(265, 20);
            this.lbl_err.TabIndex = 0;
            this.lbl_err.Text = "identifiant ou mot de passe incorrect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identifiant";
            // 
            // tb_identifiant
            // 
            this.tb_identifiant.Location = new System.Drawing.Point(41, 106);
            this.tb_identifiant.Name = "tb_identifiant";
            this.tb_identifiant.Size = new System.Drawing.Size(208, 20);
            this.tb_identifiant.TabIndex = 2;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(41, 179);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(208, 20);
            this.tb_mdp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(94, 215);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(107, 30);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connexion";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // lbl_connect
            // 
            this.lbl_connect.AutoSize = true;
            this.lbl_connect.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connect.Location = new System.Drawing.Point(12, 9);
            this.lbl_connect.Name = "lbl_connect";
            this.lbl_connect.Size = new System.Drawing.Size(265, 29);
            this.lbl_connect.TabIndex = 6;
            this.lbl_connect.Text = "Connexion Responsable";
            // 
            // ConnexionResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ConnexionResponsable";
            this.Text = "ConnexionResponsable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.Label lbl_connect;
    }
}