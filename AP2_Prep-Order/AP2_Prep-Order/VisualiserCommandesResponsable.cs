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
    public partial class VisualiserCommandesResponsable : Form
    {
        public VisualiserCommandesResponsable()
        {
            InitializeComponent();
        }

        private void VisualiserCommandesResponsable_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(MaximumSize.Width, MaximumSize.Height);
        }
    }
}
