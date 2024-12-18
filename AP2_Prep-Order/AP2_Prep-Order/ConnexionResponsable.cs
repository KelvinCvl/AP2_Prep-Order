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
    public partial class ConnexionResponsable : Form
    {
        public ConnexionResponsable()
        {
            InitializeComponent();
        }

        public static string csvFilePath = @"";

        private void importerUnFichierCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirImportation();
        }

        public static void OuvrirImportation()
        {
            ImporterResponsable importPage = new ImporterResponsable();
            importPage.MdiParent = ConnexionResponsable.ActiveForm;
            importPage.Show();
        }

        private void visualiserLesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualiserCommandesResponsable visuPageCommande = new VisualiserCommandesResponsable();
            visuPageCommande.MdiParent = VisualiserCommandesResponsable.ActiveForm;
            visuPageCommande.Show();
            visuPageCommande.Size = new System.Drawing.Size(MaximumSize.Width, MaximumSize.Height);
        }

        public static void OuvrirVisualisation()
        {
            VisualiserResponsable visualiser = new VisualiserResponsable();
            visualiser.MdiParent = ConnexionResponsable.ActiveForm;
            visualiser.Show();
        }

        private void assignerDesPréparateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suiviDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuiviResponsable laPageSuivi = new SuiviResponsable();
            laPageSuivi.MdiParent = ConnexionResponsable.ActiveForm;
            laPageSuivi.Show();
        }

        private void ConnexionResponsable_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ConnexionResponsable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComptesResponsable laPageComptes = new ComptesResponsable();
            laPageComptes.MdiParent = this;
            laPageComptes.Show();
        }
    }
}
