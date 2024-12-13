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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_bdd_connected = new System.Windows.Forms.PictureBox();
            this.pb_bdd_disconnect = new System.Windows.Forms.PictureBox();
            this.pb_bdd_wait = new System.Windows.Forms.PictureBox();
            this.panel_btn_connect = new System.Windows.Forms.Panel();
            this.btn_connect_cariste = new System.Windows.Forms.Button();
            this.panel_btn_start = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_connect_prep = new System.Windows.Forms.Button();
            this.btn_connect_resp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_error = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bdd_connected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bdd_disconnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bdd_wait)).BeginInit();
            this.panel_btn_connect.SuspendLayout();
            this.panel_btn_start.SuspendLayout();
            this.panel_error.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pb_bdd_connected
            // 
            this.pb_bdd_connected.Image = ((System.Drawing.Image)(resources.GetObject("pb_bdd_connected.Image")));
            this.pb_bdd_connected.Location = new System.Drawing.Point(14, 12);
            this.pb_bdd_connected.Name = "pb_bdd_connected";
            this.pb_bdd_connected.Size = new System.Drawing.Size(75, 75);
            this.pb_bdd_connected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_bdd_connected.TabIndex = 1;
            this.pb_bdd_connected.TabStop = false;
            // 
            // pb_bdd_disconnect
            // 
            this.pb_bdd_disconnect.Image = ((System.Drawing.Image)(resources.GetObject("pb_bdd_disconnect.Image")));
            this.pb_bdd_disconnect.Location = new System.Drawing.Point(14, 174);
            this.pb_bdd_disconnect.Name = "pb_bdd_disconnect";
            this.pb_bdd_disconnect.Size = new System.Drawing.Size(75, 75);
            this.pb_bdd_disconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_bdd_disconnect.TabIndex = 2;
            this.pb_bdd_disconnect.TabStop = false;
            // 
            // pb_bdd_wait
            // 
            this.pb_bdd_wait.Image = ((System.Drawing.Image)(resources.GetObject("pb_bdd_wait.Image")));
            this.pb_bdd_wait.Location = new System.Drawing.Point(14, 93);
            this.pb_bdd_wait.Name = "pb_bdd_wait";
            this.pb_bdd_wait.Size = new System.Drawing.Size(75, 75);
            this.pb_bdd_wait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_bdd_wait.TabIndex = 3;
            this.pb_bdd_wait.TabStop = false;
            // 
            // panel_btn_connect
            // 
            this.panel_btn_connect.Controls.Add(this.label3);
            this.panel_btn_connect.Controls.Add(this.btn_connect_resp);
            this.panel_btn_connect.Controls.Add(this.btn_connect_prep);
            this.panel_btn_connect.Controls.Add(this.btn_connect_cariste);
            this.panel_btn_connect.Location = new System.Drawing.Point(323, 245);
            this.panel_btn_connect.Name = "panel_btn_connect";
            this.panel_btn_connect.Size = new System.Drawing.Size(444, 105);
            this.panel_btn_connect.TabIndex = 4;
            // 
            // btn_connect_cariste
            // 
            this.btn_connect_cariste.Location = new System.Drawing.Point(25, 45);
            this.btn_connect_cariste.Name = "btn_connect_cariste";
            this.btn_connect_cariste.Size = new System.Drawing.Size(110, 45);
            this.btn_connect_cariste.TabIndex = 0;
            this.btn_connect_cariste.Text = "Panel Cariste";
            this.btn_connect_cariste.UseVisualStyleBackColor = true;
            this.btn_connect_cariste.Click += new System.EventHandler(this.btn_connect_cariste_Click);
            // 
            // panel_btn_start
            // 
            this.panel_btn_start.Controls.Add(this.label2);
            this.panel_btn_start.Controls.Add(this.button1);
            this.panel_btn_start.Controls.Add(this.label1);
            this.panel_btn_start.Location = new System.Drawing.Point(367, 205);
            this.panel_btn_start.Name = "panel_btn_start";
            this.panel_btn_start.Size = new System.Drawing.Size(368, 164);
            this.panel_btn_start.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "bases logistiques d\'Intermarché";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ouvrir l\'application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue sur l\'application de gestion des";
            // 
            // btn_connect_prep
            // 
            this.btn_connect_prep.Location = new System.Drawing.Point(302, 45);
            this.btn_connect_prep.Name = "btn_connect_prep";
            this.btn_connect_prep.Size = new System.Drawing.Size(110, 45);
            this.btn_connect_prep.TabIndex = 1;
            this.btn_connect_prep.Text = "Panel Preparateur";
            this.btn_connect_prep.UseVisualStyleBackColor = true;
            this.btn_connect_prep.Click += new System.EventHandler(this.btn_connect_prep_Click);
            // 
            // btn_connect_resp
            // 
            this.btn_connect_resp.Location = new System.Drawing.Point(167, 45);
            this.btn_connect_resp.Name = "btn_connect_resp";
            this.btn_connect_resp.Size = new System.Drawing.Size(110, 45);
            this.btn_connect_resp.TabIndex = 2;
            this.btn_connect_resp.Text = "Panel Responsable";
            this.btn_connect_resp.UseVisualStyleBackColor = true;
            this.btn_connect_resp.Click += new System.EventHandler(this.btn_connect_resp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Connectez vous à votre profil";
            // 
            // panel_error
            // 
            this.panel_error.BackColor = System.Drawing.SystemColors.Control;
            this.panel_error.Controls.Add(this.textBox1);
            this.panel_error.Controls.Add(this.label4);
            this.panel_error.Location = new System.Drawing.Point(323, 217);
            this.panel_error.Name = "panel_error";
            this.panel_error.Size = new System.Drawing.Size(444, 152);
            this.panel_error.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(49, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Impossible de se connecter à la base de données";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(372, 117);
            this.textBox1.TabIndex = 4;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 484);
            this.Controls.Add(this.panel_error);
            this.Controls.Add(this.panel_btn_start);
            this.Controls.Add(this.panel_btn_connect);
            this.Controls.Add(this.pb_bdd_wait);
            this.Controls.Add(this.pb_bdd_disconnect);
            this.Controls.Add(this.pb_bdd_connected);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accueil";
            this.Text = "Page d\'accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bdd_connected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bdd_disconnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bdd_wait)).EndInit();
            this.panel_btn_connect.ResumeLayout(false);
            this.panel_btn_connect.PerformLayout();
            this.panel_btn_start.ResumeLayout(false);
            this.panel_btn_start.PerformLayout();
            this.panel_error.ResumeLayout(false);
            this.panel_error.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem préparateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caristeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsableToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_bdd_connected;
        private System.Windows.Forms.PictureBox pb_bdd_disconnect;
        private System.Windows.Forms.PictureBox pb_bdd_wait;
        private System.Windows.Forms.Panel panel_btn_connect;
        private System.Windows.Forms.Button btn_connect_cariste;
        private System.Windows.Forms.Panel panel_btn_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connect_resp;
        private System.Windows.Forms.Button btn_connect_prep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}