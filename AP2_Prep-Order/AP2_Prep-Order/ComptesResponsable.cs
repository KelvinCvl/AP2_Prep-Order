using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AP2_Prep_Order
{
    public partial class ComptesResponsable : Form
    {
        public ComptesResponsable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbt_cariste.Checked == false && rdbt_prepa.Checked == false)
            {
                MessageBox.Show("Merci de choisir un role", "Erreur de syntaxe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tb_login.Text == "")
                {
                    MessageBox.Show("Merci de choisir un login","Erreur de syntaxe",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (tb_mdp.Text == "")
                    {
                        MessageBox.Show("Merci de choisir un mot de passe", "Erreur de syntaxe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (tb_zone.Text == "")
                        {
                            MessageBox.Show("Merci de choisir une zone", "Erreur de syntaxe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (tb_zone.Text != "1" && tb_zone.Text != "2" && tb_zone.Text != "3")
                            {
                                MessageBox.Show("Erreur, merci de choisir une zone coreecte (1 2 3)", "Erreur de syntaxe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                int table;

                                if (rdbt_cariste.Checked) { table = 1; }
                                else { table = 0; }

                                try
                                {
                                    using (SqlCommand command = new SqlCommand("AjoutUtilisateur", Bdd.db_connect))
                                    {
                                        command.CommandType = CommandType.StoredProcedure;
                                        command.Parameters.AddWithValue("@login", tb_login.Text);
                                        command.Parameters.AddWithValue("@mdp", tb_mdp.Text);
                                        command.Parameters.AddWithValue("@idZone", tb_zone.Text);
                                        command.Parameters.AddWithValue("@role", table);

                                        command.ExecuteNonQuery();

                                        MessageBox.Show("Utilisateur ajouté !", "Reussite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString(), "Erreur");
                                }
                            }
                        }
                    }
                }
            }
            RefreshUserLV();
        }

        private void ComptesResponsable_Load(object sender, EventArgs e)
        {
            rdbt_cariste.Checked = true;
            RefreshUserLV();
            lvComptes.FullRowSelect = true;
            lvComptes.HideSelection = false;
        }

        private void RefreshUserLV()
        {
            lvComptes.Items.Clear();
            try
            {
                using (SqlCommand command = new SqlCommand("ShowUtilisateur", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@role", 1);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string laZone;
                            int laZoneId = int.Parse(reader["idZone"].ToString());
                            if (laZoneId == 1)
                            {
                                laZone = "1 Sec";
                            }
                            else if (laZoneId == 2)
                            {
                                laZone = "2 DPH";
                            }
                            else
                            {
                                laZone = "3 Liquide";
                            }

                            ListViewItem item = new ListViewItem("Cariste");
                            item.SubItems.Add(reader["numcariste"].ToString());
                            item.SubItems.Add(reader["login"].ToString());
                            item.SubItems.Add(laZone);
                            lvComptes.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des comptes utlisateurs (Cariste) : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                using (SqlCommand command = new SqlCommand("ShowUtilisateur", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@role", 0);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string laZone;
                            int laZoneId = int.Parse(reader["idZone"].ToString());
                            if(laZoneId == 1)
                            {
                                laZone = "1 Sec";
                            }else if(laZoneId == 2)
                            {
                                laZone = "2 DPH";
                            }
                            else
                            {
                                laZone = "3 Liquide";
                            }

                            ListViewItem item = new ListViewItem("Preparateur");
                            item.SubItems.Add(reader["numpreparateur"].ToString());
                            item.SubItems.Add(reader["login"].ToString());
                            item.SubItems.Add(laZone);
                            lvComptes.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des comptes utlisateurs (Préparateur) : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int idSelected;
        private string roleSelected;

        private void lvComptes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Vérifier si un élément est sélectionné
            if (e.IsSelected)
            {
                ListViewItem selectedItem = e.Item;

                roleSelected = selectedItem.SubItems[0].Text;
                idSelected = int.Parse(selectedItem.SubItems[1].Text);
                string login = selectedItem.SubItems[2].Text;
                string zone = selectedItem.SubItems[3].Text;

                tb_change_login.Text = login;
                tb_change_zone.Text = zone.Substring(0, 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lvComptes.SelectedItems != null)
            {
                if(tb_change_login.Text != "" && tb_change_zone.Text != "")
                {
                    if (tb_change_zone.Text != "1" && tb_change_zone.Text != "2" && tb_change_zone.Text != "3")
                    {
                        MessageBox.Show("Erreur, merci de choisir une zone coreecte (1 2 3)","Erreur de syntaxe",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int role;
                        if (roleSelected == "Cariste")
                        {
                            role = 1;
                        }
                        else
                        {
                            role = 0;
                        }
                        if (tb_change_mdp.Text != "")
                        {
                            try
                            {
                                using (SqlCommand command = new SqlCommand("EditUtilisateur", Bdd.db_connect))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@role", role);
                                    command.Parameters.AddWithValue("@id", idSelected);
                                    command.Parameters.AddWithValue("@action", "modif");
                                    command.Parameters.AddWithValue("@login", tb_change_login.Text);
                                    command.Parameters.AddWithValue("@mdp", tb_change_mdp.Text);
                                    command.Parameters.AddWithValue("@zone", int.Parse(tb_change_zone.Text));

                                    command.ExecuteNonQuery();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Erreur");
                            }
                        }
                        else
                        {
                            try
                            {
                                using (SqlCommand command = new SqlCommand("EditUtilisateur", Bdd.db_connect))
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@role", role);
                                    command.Parameters.AddWithValue("@id", idSelected);
                                    command.Parameters.AddWithValue("@action", "modif");
                                    command.Parameters.AddWithValue("@login", tb_change_login.Text);
                                    command.Parameters.AddWithValue("@mdp", "null");
                                    command.Parameters.AddWithValue("@zone", int.Parse(tb_change_zone.Text));

                                    command.ExecuteNonQuery();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Erreur");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Merci de choisir au moin un login et une zone","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            RefreshUserLV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int role;
            if (roleSelected == "Cariste")
            {
                role = 1;
            }
            else
            {
                role = 0;
            }
            try
            {
                using (SqlCommand command = new SqlCommand("EditUtilisateur", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@id", idSelected);
                    command.Parameters.AddWithValue("@action", "delete");
                    command.Parameters.AddWithValue("@login", "null");
                    command.Parameters.AddWithValue("@mdp", "null");
                    command.Parameters.AddWithValue("@zone", 1);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur");
            }
            RefreshUserLV();
        }
    }
}
