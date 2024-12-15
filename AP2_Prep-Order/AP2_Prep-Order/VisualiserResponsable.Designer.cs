namespace AP2_Prep_Order
{
    partial class VisualiserResponsable
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantités = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbZones = new System.Windows.Forms.ComboBox();
            this.lbl_visu = new System.Windows.Forms.Label();
            this.btn_redirect = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Produits,
            this.Quantités,
            this.Zones});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // Produits
            // 
            this.Produits.Text = "Produits";
            this.Produits.Width = 180;
            // 
            // Quantités
            // 
            this.Quantités.Text = "Quantités";
            this.Quantités.Width = 120;
            // 
            // Zones
            // 
            this.Zones.Text = "Zones";
            this.Zones.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Importer dans la base de données";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trier par zone :";
            // 
            // cbZones
            // 
            this.cbZones.FormattingEnabled = true;
            this.cbZones.Location = new System.Drawing.Point(581, 73);
            this.cbZones.Name = "cbZones";
            this.cbZones.Size = new System.Drawing.Size(121, 21);
            this.cbZones.TabIndex = 3;
            this.cbZones.SelectedIndexChanged += new System.EventHandler(this.cbZones_SelectedIndexChanged);
            // 
            // lbl_visu
            // 
            this.lbl_visu.AutoSize = true;
            this.lbl_visu.Location = new System.Drawing.Point(12, 9);
            this.lbl_visu.Name = "lbl_visu";
            this.lbl_visu.Size = new System.Drawing.Size(117, 13);
            this.lbl_visu.TabIndex = 4;
            this.lbl_visu.Text = "Visualisation du fichier :";
            // 
            // btn_redirect
            // 
            this.btn_redirect.Location = new System.Drawing.Point(135, 4);
            this.btn_redirect.Name = "btn_redirect";
            this.btn_redirect.Size = new System.Drawing.Size(101, 23);
            this.btn_redirect.TabIndex = 5;
            this.btn_redirect.Text = "ajouter un fichier";
            this.btn_redirect.UseVisualStyleBackColor = true;
            this.btn_redirect.Click += new System.EventHandler(this.btn_redirect_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(15, 29);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(82, 23);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "Rafraîchir";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // VisualiserResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 594);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_redirect);
            this.Controls.Add(this.lbl_visu);
            this.Controls.Add(this.cbZones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "VisualiserResponsable";
            this.Text = "VisualiserResponsable";
            this.Load += new System.EventHandler(this.VisualiserResponsable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbZones;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Produits;
        private System.Windows.Forms.ColumnHeader Quantités;
        private System.Windows.Forms.ColumnHeader Zones;
        private System.Windows.Forms.Label lbl_visu;
        private System.Windows.Forms.Button btn_redirect;
        private System.Windows.Forms.Button btn_refresh;
    }
}