namespace AP2_Prep_Order
{
    partial class Assigner
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
            this.lv_preparateurs = new System.Windows.Forms.ListView();
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_sqousCommande = new System.Windows.Forms.ListView();
            this.idSous = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idcommande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_link = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_preparateurs
            // 
            this.lv_preparateurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.login,
            this.zone});
            this.lv_preparateurs.HideSelection = false;
            this.lv_preparateurs.Location = new System.Drawing.Point(12, 12);
            this.lv_preparateurs.Name = "lv_preparateurs";
            this.lv_preparateurs.Size = new System.Drawing.Size(249, 209);
            this.lv_preparateurs.TabIndex = 0;
            this.lv_preparateurs.UseCompatibleStateImageBehavior = false;
            this.lv_preparateurs.View = System.Windows.Forms.View.Details;
            this.lv_preparateurs.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_preparateurs_ItemSelectionChanged);
            // 
            // login
            // 
            this.login.Text = "login";
            this.login.Width = 120;
            // 
            // zone
            // 
            this.zone.Text = "zone";
            this.zone.Width = 120;
            // 
            // lv_sqousCommande
            // 
            this.lv_sqousCommande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idSous,
            this.idcommande});
            this.lv_sqousCommande.HideSelection = false;
            this.lv_sqousCommande.Location = new System.Drawing.Point(267, 12);
            this.lv_sqousCommande.Name = "lv_sqousCommande";
            this.lv_sqousCommande.Size = new System.Drawing.Size(249, 209);
            this.lv_sqousCommande.TabIndex = 1;
            this.lv_sqousCommande.UseCompatibleStateImageBehavior = false;
            this.lv_sqousCommande.View = System.Windows.Forms.View.Details;
            this.lv_sqousCommande.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_sqousCommande_ItemSelectionChanged);
            // 
            // idSous
            // 
            this.idSous.Text = "id Sous Commande";
            this.idSous.Width = 120;
            // 
            // idcommande
            // 
            this.idcommande.Text = "id Commande";
            this.idcommande.Width = 120;
            // 
            // btn_link
            // 
            this.btn_link.Location = new System.Drawing.Point(522, 12);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(121, 48);
            this.btn_link.TabIndex = 2;
            this.btn_link.Text = "Lier le préparateur à cette commande";
            this.btn_link.UseVisualStyleBackColor = true;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // Assigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_link);
            this.Controls.Add(this.lv_sqousCommande);
            this.Controls.Add(this.lv_preparateurs);
            this.Name = "Assigner";
            this.Text = "Assigner";
            this.Load += new System.EventHandler(this.Assigner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_preparateurs;
        private System.Windows.Forms.ColumnHeader login;
        private System.Windows.Forms.ColumnHeader zone;
        private System.Windows.Forms.ListView lv_sqousCommande;
        private System.Windows.Forms.ColumnHeader idSous;
        private System.Windows.Forms.ColumnHeader idcommande;
        private System.Windows.Forms.Button btn_link;
    }
}