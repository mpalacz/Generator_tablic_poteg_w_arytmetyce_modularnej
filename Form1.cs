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
    public partial class frmInput : Form
    {
        public int modulo; // value for calculation
        public frmInput()
        {
            InitializeComponent();
        }
        // cancel button funcionality
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        // generate button funcionality
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            modulo = (int)nudModulo.Value; // setting modulo var value based on user's input
            // checking correctness of the inputed value
            if (modulo > 0)
            {
                frmOutput frmOutput = new frmOutput();
                frmOutput.Show();
                Close(); //closing current form
            }
            else
            {
                errorProvider1.SetError(nudModulo, "Podano liczbę mniejszą od 1"); // displaying error to the user
                nudModulo.Value = 1; // setting default value in nudModulo
            }
        }
    }
}
