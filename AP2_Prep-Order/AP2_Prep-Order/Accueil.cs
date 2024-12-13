using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AP2_Prep_Order
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            //panel 

            panel_btn_start.Visible = true;
            panel_btn_start.Enabled = true;

            panel_btn_connect.Visible = false;
            panel_btn_connect.Enabled = false;
            panel_error.Visible = false;
            panel_error.Enabled = false;
            panel_connect.Visible = false;
            panel_connect.Enabled = false;
            lbl_err.Visible = false;

            //pitcure box

            pb_bdd_wait.Enabled = true;
            pb_bdd_wait.Visible = true;
            pb_bdd_wait.Location = new Point(14, 12);

            pb_bdd_disconnect.Enabled = false;
            pb_bdd_disconnect.Visible = false;
            pb_bdd_disconnect.Location = new Point(14, 12);
            pb_bdd_connected.Enabled = false;
            pb_bdd_connected.Visible = false;
            pb_bdd_connected.Location = new Point(14, 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_btn_start.Visible = false;
            panel_btn_start.Enabled = false;
            try
            {
                Bdd.db_connect.Open();
                pb_bdd_wait.Visible = false;
                pb_bdd_wait.Enabled = false;

                pb_bdd_connected.Visible = true;
                pb_bdd_connected.Enabled = true;

                panel_btn_connect.Visible = true;
                panel_btn_connect.Enabled = true;
            }
            catch (Exception ex)
            {
                textBox1.Text = "Erreur de connexion : " + ex.Message;

                pb_bdd_wait.Visible = false;
                pb_bdd_wait.Enabled = false;

                pb_bdd_disconnect.Visible = true;
                pb_bdd_disconnect.Enabled = true;

                panel_error.Visible = true;
                panel_error.Enabled = true;
            }
        }

        private bool ConnexionCompte(string login, string mdp, string role)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("Connection", Bdd.db_connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@mdp", mdp);
                    command.Parameters.AddWithValue("@table", role);

                    // DECLARE @id EN OUTPUT
                    SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
                    idParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(idParam);

                    command.ExecuteNonQuery();

                    int id = (int)idParam.Value;

                    if (id != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        string LeRole = "";

        private void btn_connect_cariste_Click(object sender, EventArgs e)
        {
            LeRole = "Cariste";
            lbl_connect.Text = "Connexion Cariste";
            panel_btn_connect.Enabled = false;
            panel_btn_connect.Visible = false;

            panel_connect.Visible = true;
            panel_connect.Enabled = true;
        }

        private void btn_connect_prep_Click(object sender, EventArgs e)
        {
            LeRole = "Preparateur";
            lbl_connect.Text = "Connexion Preparateur";
            panel_btn_connect.Enabled = false;
            panel_btn_connect.Visible = false;

            panel_connect.Visible = true;
            panel_connect.Enabled = true;
        }

        private void btn_connect_resp_Click(object sender, EventArgs e)
        {
            LeRole = "Responsable";
            lbl_connect.Text = "Connexion Responsable";
            panel_btn_connect.Enabled = false;
            panel_btn_connect.Visible = false;

            panel_connect.Visible = true;
            panel_connect.Enabled = true;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (ConnexionCompte(tb_identifiant.Text, tb_mdp.Text, LeRole))
            {
                lbl_err.Visible = false;
                if (LeRole == "Cariste")
                {
                    FormPalettesManquantes laPagePalettes = new FormPalettesManquantes();
                    laPagePalettes.Show();
                    this.Hide();
                }
                else if (LeRole == "Preparateur")
                {
                    //connexion preparateur
                }
                else
                {
                    ConnexionResponsable laPageConnexionResp = new ConnexionResponsable();
                    laPageConnexionResp.Show();
                    this.Hide();
                }
            }
            else
            {
                lbl_err.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_connect.Visible = false;
            panel_connect.Enabled=false;

            panel_btn_connect.Visible = true;
            panel_btn_connect.Enabled = true;

            lbl_err.Visible=false;
        }
    }
}
