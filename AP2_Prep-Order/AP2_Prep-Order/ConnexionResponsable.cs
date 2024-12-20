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
            foreach (Form childForm in ConnexionResponsable.ActiveForm.MdiChildren)
            {
                childForm.Close();
            }

            ImporterResponsable laPageAssigner = new ImporterResponsable();
            laPageAssigner.MdiParent = ConnexionResponsable.ActiveForm;

            laPageAssigner.FormBorderStyle = FormBorderStyle.None;
            laPageAssigner.Dock = DockStyle.Fill;

            laPageAssigner.Show();
        }

        private void visualiserLesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in ConnexionResponsable.ActiveForm.MdiChildren)
            {
                childForm.Close();
            }

            VisualiserCommandesResponsable laPageAssigner = new VisualiserCommandesResponsable();
            laPageAssigner.MdiParent = ConnexionResponsable.ActiveForm;

            laPageAssigner.FormBorderStyle = FormBorderStyle.None;
            laPageAssigner.Dock = DockStyle.Fill;

            laPageAssigner.Show();
        }

        private void assignerDesPréparateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in ConnexionResponsable.ActiveForm.MdiChildren)
            {
                childForm.Close();
            }

            Assigner laPageAssigner = new Assigner();
            laPageAssigner.MdiParent = ConnexionResponsable.ActiveForm;

            laPageAssigner.FormBorderStyle = FormBorderStyle.None;
            laPageAssigner.Dock = DockStyle.Fill;

            laPageAssigner.Show();
        }

        private void suiviDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in ConnexionResponsable.ActiveForm.MdiChildren)
            {
                childForm.Close();
            }

            SuiviResponsable laPageAssigner = new SuiviResponsable();
            laPageAssigner.MdiParent = ConnexionResponsable.ActiveForm;

            laPageAssigner.FormBorderStyle = FormBorderStyle.None;
            laPageAssigner.Dock = DockStyle.Fill;

            laPageAssigner.Show();
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
            foreach (Form childForm in ConnexionResponsable.ActiveForm.MdiChildren)
            {
                childForm.Close();
            }

            ComptesResponsable laPageAssigner = new ComptesResponsable();
            laPageAssigner.MdiParent = ConnexionResponsable.ActiveForm;

            laPageAssigner.FormBorderStyle = FormBorderStyle.None;
            laPageAssigner.Dock = DockStyle.Fill;

            laPageAssigner.Show();
        }

        private void ConnexionResponsable_Load(object sender, EventArgs e)
        {

        }
    }
}
