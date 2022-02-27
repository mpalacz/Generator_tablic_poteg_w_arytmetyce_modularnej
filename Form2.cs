using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_tablic_poteg_w_arytmetyce_modularnej
{
    public partial class frmOutput : Form
    {
        public frmOutput()
        {
            InitializeComponent();
            frmInput frmInput = new frmInput();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
