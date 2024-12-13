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
            try
            {
                Bdd.db_connect.Open();
                MessageBox.Show("Connexion réussie à la base de données.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }

        private void préparateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatutPrep statutPrep = new StatutPrep();
            statutPrep.MdiParent = this;
            statutPrep.Show();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PalettesManquantes palettesmanquantes = new PalettesManquantes();
            palettesmanquantes.MdiParent = this;
            palettesmanquantes.Show();
        }
    }
}
