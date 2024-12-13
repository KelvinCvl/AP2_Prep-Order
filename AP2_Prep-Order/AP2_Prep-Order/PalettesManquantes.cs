using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AP2_Prep_Order
{
    public partial class PalettesManquantes : Form
    {
        public PalettesManquantes()
        {
            InitializeComponent();
        }

        private void PalettesManquantes_Load(object sender, EventArgs e)
        {
            cb_zone.Items.Add("Sec");
            cb_zone.Items.Add("DPH");
            cb_zone.Items.Add("Liquide");
        }

        private void cb_zone_SelectedIndexChanged(object sender, EventArgs e)
        {
            int zone;
            switch (cb_zone.SelectedItem.ToString())
            {
                case "Sec":
                    zone = 1;
                    break;
                case "DPH":
                    zone = 2;
                    break;
                case "Liquide":
                    zone = 3;
                    break;
                default:
                    MessageBox.Show("Zone inconnue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            GetPalettesVide(zone);
        }

        private void GetPalettesVide(int zone)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("PalettesVide", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ZoneNum", zone);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listView1.Items.Clear(); 

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["allee"].ToString());
                            item.SubItems.Add(reader["etage"].ToString());
                            item.SubItems.Add(reader["emplacement"].ToString());
                            item.SubItems.Add(reader["idArticlePalette"].ToString());
                            item.SubItems.Add(reader["nombrePlein"].ToString());
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des palettes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
