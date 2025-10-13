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
            // Fermer toutes les autres pages ouvertes dans le MDI container
            foreach (Form childForm in ConnexionCariste.ActiveForm.MdiChildren)
            {
                childForm.Close();
            }

            FormPalettesManquantes Palettes = new FormPalettesManquantes();
            Palettes.MdiParent = this;

            // Configurer la nouvelle page pour occuper tout l'espace
            Palettes.FormBorderStyle = FormBorderStyle.None;
            Palettes.Dock = DockStyle.Fill;

            Palettes.Show();
        }

        private void confirmationDeStockageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Fermer toutes les autres pages ouvertes dans le MDI container
            foreach (Form childForm in ConnexionCariste.ActiveForm.MdiChildren)
            {
                childForm.Close();
            }

            ConfirmationStockage Gestion = new ConfirmationStockage();
            Gestion.MdiParent = ConnexionCariste.ActiveForm;

            // Configurer la nouvelle page pour occuper tout l'espace
            Gestion.FormBorderStyle = FormBorderStyle.None;
            Gestion.Dock = DockStyle.Fill;

            Gestion.Show();
        }

        private void gestionDuStockageEnHauteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Fermer toutes les autres pages ouvertes dans le MDI container
            foreach (Form childForm in ConnexionCariste.ActiveForm.MdiChildren)
            {
                childForm.Close();
            }

            GestionStockHauteur Confirmation = new GestionStockHauteur();
            Confirmation.MdiParent = this;

            // Configurer la nouvelle page pour occuper tout l'espace
            Confirmation.FormBorderStyle = FormBorderStyle.None;
            Confirmation.Dock = DockStyle.Fill;

            Confirmation.Show();
        }

        private void ConnexionCariste_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}


