using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_Prep_Order
{
    public partial class ImporterResponsable : Form
    {
        public ImporterResponsable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Fichiers CSV (*.csv)|*.csv",
                Title = "Sélectionnez un fichier CSV"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ConnexionResponsable.csvFilePath = openFileDialog.FileName;
                    lbl_error.Visible = false;
                    lbl_working.Visible = true;
                }
                catch (Exception ex)
                {
                    lbl_error.Visible = true;
                    lbl_working.Visible = false;
                }
                
            }
        }

        private void ImporterResponsable_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Size = new System.Drawing.Size(MaximumSize.Width, MaximumSize.Height);
            lbl_error.Visible = false;
            lbl_working.Visible = false;
        }
    }
}
