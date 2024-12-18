using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AP2_Prep_Order
{
    public partial class VisualiserResponsable : Form
    {
        public VisualiserResponsable()
        {
            InitializeComponent();
        }

        private void VisualiserResponsable_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Size = new System.Drawing.Size(MaximumSize.Width, MaximumSize.Height);

            btn_redirect.Enabled = false;
            btn_redirect.Visible = false;

            LoadForm();
        }

        private void LoadForm()
        {
            

            if (File.Exists(ConnexionResponsable.csvFilePath))
            {
                lbl_visu.Text = "Visualisation du fichier : " + ConnexionResponsable.csvFilePath;

                btn_redirect.Enabled = false;
                btn_redirect.Visible = false;

                cbZones.Enabled = true;
                listView1.Enabled = true;

                cbZones.Items.Clear();

                cbZones.Items.Add("Tout");
                cbZones.Items.Add("Sec");
                cbZones.Items.Add("DPH");
                cbZones.Items.Add("Liquide");

                cbZones.SelectedItem = "Tout";

                LoadCSV();
            }
            else
            {
                lbl_visu.Text = "Aucun fichier chargé";

                btn_redirect.Enabled = true;
                btn_redirect.Visible = true;

                cbZones.Enabled = false;
                listView1.Enabled = false;
            }
        }

        private void LoadCSV()
        {
            try
            {
                var lines = File.ReadAllLines(ConnexionResponsable.csvFilePath);
                listView1.Items.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    var values = lines[i].Split(',');

                    ListViewItem item = new ListViewItem(values[0]);

                    for (int j = 1; j < values.Length; j++)
                    {
                        item.SubItems.Add(values[j]);
                    }

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du fichier CSV : " + ex.Message , "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCsvFilter(string filtre)
        {
            try
            {
                var lines = File.ReadAllLines(ConnexionResponsable.csvFilePath);
                listView1.Items.Clear();

                if (lines.Length == 0)
                {
                    MessageBox.Show("Le fichier CSV est vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    var values = lines[i].Split(',');

                    string zone = values[3];
                    if (filtre == "Tout" || zone.Equals(filtre, StringComparison.OrdinalIgnoreCase))
                    {
                        ListViewItem item = new ListViewItem(values[0]);

                        for (int j = 1; j < values.Length; j++)
                        {
                            item.SubItems.Add(values[j]);
                        }

                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du filtrage du fichier CSV : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_redirect_Click(object sender, EventArgs e)
        {
            ConnexionResponsable.OuvrirImportation();
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void cbZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedZone = cbZones.SelectedItem.ToString();
            LoadCsvFilter(selectedZone);
        }
    }
}
