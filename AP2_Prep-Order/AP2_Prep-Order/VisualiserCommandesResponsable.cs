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
    public partial class VisualiserCommandesResponsable : Form
    {
        public VisualiserCommandesResponsable()
        {
            InitializeComponent();
        }

        private void VisualiserCommandesResponsable_Load(object sender, EventArgs e)
        {
            lv_commande.FullRowSelect = true;
            lv_commande.MultiSelect = false;
            lv_commande.Items.Clear();

            lv_sous_commande.FullRowSelect = true;
            lv_sous_commande.MultiSelect = false;
            lv_sous_commande.Items.Clear();

            lv_commander.FullRowSelect = true;
            lv_commander.MultiSelect = false;
            lv_commander.Items.Clear();

            try
            {
                using (SqlCommand command = new SqlCommand("ShowCommande", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["idCommande"].ToString());
                            item.SubItems.Add(reader["jourPreparation"].ToString());
                            item.SubItems.Add(reader["login"].ToString());
                            lv_commande.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des comptes utlisateurs (Cariste) : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int idCommandeSelected;
        private int idSousCommandeSelected;

        private void lv_sous_commande_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lv_commander.Items.Clear();
            if (e.IsSelected)
            {
                ListViewItem selectedItem = e.Item;
                idCommandeSelected = int.Parse(selectedItem.SubItems[0].Text);

                try
                {
                    using (SqlCommand command = new SqlCommand("ShowCommander", Bdd.db_connect))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idSousCommandeSelected", idCommandeSelected);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["libelleArticle"].ToString());
                                item.SubItems.Add(reader["qteCommande"].ToString());
                                lv_commander.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement de la liste commander : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                idSousCommandeSelected = -1;
            }
        }

        private void lv_commande_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            idSousCommandeSelected = -1;
            lv_sous_commande.Items.Clear();
            if (e.IsSelected)
            {
                ListViewItem selectedItem = e.Item;
                idCommandeSelected = int.Parse(selectedItem.SubItems[0].Text);

                try
                {
                    using (SqlCommand command = new SqlCommand("ShowSousCommande", Bdd.db_connect))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idCommandeSelected", idCommandeSelected);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["idSousCommande"].ToString());
                                item.SubItems.Add(reader["nom"].ToString());
                                lv_sous_commande.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement de la liste des sous commandes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                idCommandeSelected = -1;
            }
        }
    }
}
