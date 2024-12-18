using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_Prep_Order
{
    public partial class Assigner : Form
    {
        public Assigner()
        {
            InitializeComponent();
        }

        private string idPrepa;
        private int idSousCom;

        private void Assigner_Load(object sender, EventArgs e)
        {
            lv_preparateurs.Items.Clear();
            lv_preparateurs.FullRowSelect = true;
            lv_preparateurs.MultiSelect = false;

            lv_sqousCommande.Items.Clear();
            lv_sqousCommande.FullRowSelect = true;
            lv_sqousCommande.MultiSelect = false;

            try
            {
                using (SqlCommand command = new SqlCommand("ShowPreparateurs", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["login"].ToString());
                            item.SubItems.Add(reader["idZone"].ToString());
                            lv_preparateurs.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des comptes préparateurs : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lv_preparateurs_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lv_sqousCommande.Items.Clear();
            if (e.IsSelected)
            {
                ListViewItem selectedItem = e.Item;
                idPrepa = selectedItem.SubItems[0].Text;

                try
                {
                    using (SqlCommand command = new SqlCommand("ShowSousCommandeZoneNonAssigne", Bdd.db_connect))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idZone", int.Parse(selectedItem.SubItems[1].Text));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["idSousCommande"].ToString());
                                item.SubItems.Add(reader["idCommande"].ToString());
                                lv_sqousCommande.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement de la liste de sous commande : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            if (lv_sqousCommande.SelectedItems != null && lv_preparateurs.SelectedItems != null)
            {

                try
                {
                    using (SqlCommand command = new SqlCommand("LierPreparateurCommande", Bdd.db_connect))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@loginPreparateur", idPrepa);
                        command.Parameters.AddWithValue("@idSousCommande", idSousCom);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Ajout de la liaison avec succès","Reussite",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement de la liste de sous commande : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lv_sqousCommande_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem selectedItem = e.Item;
                idSousCom = int.Parse(selectedItem.SubItems[0].Text);
            }
                
        }
    }
}
