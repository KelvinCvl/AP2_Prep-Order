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
    public partial class ConfirmationStockage : Form
    {
        public ConfirmationStockage()
        {
            InitializeComponent();
        }

        private void ConfirmationStockage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_plein.Enabled = true;
        }

        private void cb_palette_vide_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_vide.Enabled = true;
        }

    }
}
