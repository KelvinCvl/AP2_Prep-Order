using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_Prep_Order
{
    public partial class GestionHauteur : Form
    {
        public GestionHauteur()
        {
            InitializeComponent();
        }

        private void GestionHauteur_Load(object sender, EventArgs e)
        {
            cb_zone.Items.Add("Sec");
            cb_zone.Items.Add("DPH");
            cb_zone.Items.Add("Liquide");
        }

        private void cb_zone_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_remplie.Items.Clear();
            cb_vide.Items.Clear();
            cb_vide_fill();
            cb_remplie_fill();
        }

        // remplir une palette 
        public void cb_vide_fill() 
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
            cb_vide_fill(zone, Bdd.id);

        }

        private void cb_vide_fill(int zone, int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("PalettesVide", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ZoneNum", zone);
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            cb_vide.Items.Add(reader["emplacement"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des palettes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_vide_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_vide.Enabled = true;
        }

        private void btn_vide_Click(object sender, EventArgs e)
        {
            if (cb_vide.SelectedItem != null)
            {
                PaletteRemplir(cb_vide.SelectedItem.ToString());
                cb_vide.Items.Clear();
                cb_vide.SelectedIndex = -1; 
            }
            btn_vide.Enabled = false;
        }

        private void PaletteRemplir(string id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("PaletteRemplir", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("emplacement", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des palettes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_vide.Enabled = false;  
            cb_vide.Items.Clear();
        }

        // vider une palette
        public void cb_remplie_fill()
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
            cb_remplie_fill(zone, Bdd.id);
        }

        private void cb_remplie_fill(int zone, int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("PalettesRemplie", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ZoneNum", zone);
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            cb_remplie.Items.Add(reader["emplacement"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des palettes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_remplie_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_remplie.Enabled = true;
        }

        private void btn_remplie_Click(object sender, EventArgs e)
        {
            if (cb_remplie.SelectedItem != null)
            {
                PaletteVider(cb_remplie.SelectedItem.ToString());
                cb_remplie.Items.Clear();
                cb_remplie.SelectedIndex = -1;
            }
            btn_remplie.Enabled = false;
        }

        private void PaletteVider(string id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("PaletteVider", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("emplacement", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des palettes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_remplie.Enabled = false;
            cb_remplie.Items.Clear();
        }

    }
}