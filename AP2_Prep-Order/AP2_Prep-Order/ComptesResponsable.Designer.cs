namespace AP2_Prep_Order
{
    partial class ComptesResponsable
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
            this.rdbt_prepa = new System.Windows.Forms.RadioButton();
            this.rdbt_cariste = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_zone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvComptes = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_zone = new System.Windows.Forms.Label();
            this.tb_change_zone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_change_mdp = new System.Windows.Forms.TextBox();
            this.tb_change_login = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdbt_prepa);
            this.panel1.Controls.Add(this.rdbt_cariste);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tb_zone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_mdp);
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 418);
            this.panel1.TabIndex = 0;
            // 
            // rdbt_prepa
            // 
            this.rdbt_prepa.AutoSize = true;
            this.rdbt_prepa.Location = new System.Drawing.Point(44, 240);
            this.rdbt_prepa.Name = "rdbt_prepa";
            this.rdbt_prepa.Size = new System.Drawing.Size(80, 17);
            this.rdbt_prepa.TabIndex = 7;
            this.rdbt_prepa.TabStop = true;
            this.rdbt_prepa.Tag = "role";
            this.rdbt_prepa.Text = "Préparateur";
            this.rdbt_prepa.UseVisualStyleBackColor = true;
            // 
            // rdbt_cariste
            // 
            this.rdbt_cariste.AutoSize = true;
            this.rdbt_cariste.Location = new System.Drawing.Point(44, 217);
            this.rdbt_cariste.Name = "rdbt_cariste";
            this.rdbt_cariste.Size = new System.Drawing.Size(57, 17);
            this.rdbt_cariste.TabIndex = 6;
            this.rdbt_cariste.TabStop = true;
            this.rdbt_cariste.Tag = "role";
            this.rdbt_cariste.Text = "Cariste";
            this.rdbt_cariste.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter l\'utilisateur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_zone
            // 
            this.tb_zone.Location = new System.Drawing.Point(22, 161);
            this.tb_zone.Name = "tb_zone";
            this.tb_zone.Size = new System.Drawing.Size(140, 20);
            this.tb_zone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choisir un mdp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisir un login";
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(22, 103);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(140, 20);
            this.tb_mdp.TabIndex = 1;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(22, 54);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(140, 20);
            this.tb_login.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choisir une Zone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ajouter un utilisateur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choisir un Role";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_zone);
            this.panel2.Controls.Add(this.lvComptes);
            this.panel2.Controls.Add(this.tb_change_zone);
            this.panel2.Controls.Add(this.tb_change_login);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tb_change_mdp);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(219, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 418);
            this.panel2.TabIndex = 1;
            // 
            // lvComptes
            // 
            this.lvComptes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.role,
            this.id,
            this.login,
            this.zone});
            this.lvComptes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvComptes.HideSelection = false;
            this.lvComptes.Location = new System.Drawing.Point(16, 38);
            this.lvComptes.MultiSelect = false;
            this.lvComptes.Name = "lvComptes";
            this.lvComptes.Size = new System.Drawing.Size(501, 364);
            this.lvComptes.TabIndex = 0;
            this.lvComptes.UseCompatibleStateImageBehavior = false;
            this.lvComptes.View = System.Windows.Forms.View.Details;
            this.lvComptes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvComptes_ItemSelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Modifier un utilisateur";
            // 
            // role
            // 
            this.role.Text = "Role";
            this.role.Width = 120;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 120;
            // 
            // login
            // 
            this.login.Text = "Login";
            this.login.Width = 120;
            // 
            // zone
            // 
            this.zone.Text = "Zone";
            this.zone.Width = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Utilisateur choisi :";
            // 
            // lbl_zone
            // 
            this.lbl_zone.AutoSize = true;
            this.lbl_zone.Location = new System.Drawing.Point(523, 145);
            this.lbl_zone.Name = "lbl_zone";
            this.lbl_zone.Size = new System.Drawing.Size(84, 13);
            this.lbl_zone.TabIndex = 16;
            this.lbl_zone.Text = "Changer la zone";
            // 
            // tb_change_zone
            // 
            this.tb_change_zone.Location = new System.Drawing.Point(523, 161);
            this.tb_change_zone.Name = "tb_change_zone";
            this.tb_change_zone.Size = new System.Drawing.Size(150, 20);
            this.tb_change_zone.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Changer le mot de passe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Changer le login";
            // 
            // tb_change_mdp
            // 
            this.tb_change_mdp.Location = new System.Drawing.Point(523, 103);
            this.tb_change_mdp.Name = "tb_change_mdp";
            this.tb_change_mdp.Size = new System.Drawing.Size(150, 20);
            this.tb_change_mdp.TabIndex = 12;
            // 
            // tb_change_login
            // 
            this.tb_change_login.Location = new System.Drawing.Point(523, 54);
            this.tb_change_login.Name = "tb_change_login";
            this.tb_change_login.Size = new System.Drawing.Size(150, 20);
            this.tb_change_login.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(601, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ComptesResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ComptesResponsable";
            this.Text = "ComptesResponsable";
            this.Load += new System.EventHandler(this.ComptesResponsable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_zone;
        private System.Windows.Forms.RadioButton rdbt_prepa;
        private System.Windows.Forms.RadioButton rdbt_cariste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvComptes;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader login;
        private System.Windows.Forms.ColumnHeader zone;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_zone;
        private System.Windows.Forms.TextBox tb_change_zone;
        private System.Windows.Forms.TextBox tb_change_login;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_change_mdp;
        private System.Windows.Forms.Label label10;
    }
}