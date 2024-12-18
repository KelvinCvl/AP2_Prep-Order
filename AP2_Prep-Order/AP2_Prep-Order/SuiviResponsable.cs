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
    public partial class SuiviResponsable : Form
    {
        public SuiviResponsable()
        {
            InitializeComponent();
        }

        private void SuiviResponsable_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("1 SEC");
            comboBox1.Items.Add("2 DPH");
            comboBox1.Items.Add("3 Liquide");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "1 SEC")
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("ShowCommandeParZone", Bdd.db_connect))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idZoneSelected", 1);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lv_commandes.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["idCommande"].ToString());
                                item.SubItems.Add(reader["jourPreparation"].ToString());
                                item.SubItems.Add(reader["idResponsableCommande"].ToString());
                                item.SubItems.Add(reader["Etat"].ToString());
                                lv_commandes.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la récupération des commandes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBox1.SelectedItem == "2 DPH")
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("ShowCommandeParZone", Bdd.db_connect))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idZoneSelected", 2);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lv_commandes.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["idCommande"].ToString());
                                item.SubItems.Add(reader["jourPreparation"].ToString());
                                item.SubItems.Add(reader["idResponsableCommande"].ToString());
                                item.SubItems.Add(reader["Etat"].ToString());
                                lv_commandes.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la récupération des commandes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBox1.SelectedItem == "3 Liquide")
            {
                try
                {
                    using (SqlCommand command = new SqlCommand("ShowCommandeParZone", Bdd.db_connect))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idZoneSelected", 3);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lv_commandes.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["idCommande"].ToString());
                                item.SubItems.Add(reader["jourPreparation"].ToString());
                                item.SubItems.Add(reader["idResponsableCommande"].ToString());
                                item.SubItems.Add(reader["Etat"].ToString());
                                lv_commandes.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la récupération des commandes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
