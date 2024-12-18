using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2_Prep_Order
{
    public partial class ConnexionCariste : Form
    {
        public ConnexionCariste()
        {
            InitializeComponent();
        }

        private void ConnexionCariste_Load(object sender, EventArgs e)
        {

        }

        private void demandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPalettesManquantes Palettes = new FormPalettesManquantes();
            Palettes.MdiParent = this;
            Palettes.Show();
        }

        private void ConnexionCariste_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void confirmationDeStockageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConfirmationStockage Confirmation = new ConfirmationStockage();
            Confirmation.MdiParent = this;
            Confirmation.Show();
        }

        private void gestionDuStockageEnHauteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionHauteur Gestion = new GestionHauteur();
            Gestion.MdiParent = this;
            Gestion.Show();
        }
    }
}


