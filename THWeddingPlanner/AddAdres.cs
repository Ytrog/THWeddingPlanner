using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THWeddingPlanner
{
    public partial class AddAdres : Form
    {
        public AddAdres()
        {
            InitializeComponent();
        }

        private void txtHuisnummer_Validating(object sender, CancelEventArgs e)
        {
            string huisnummerString = txtHuisnummer.Text;
            int huisnummer;

            if (!int.TryParse(huisnummerString, out huisnummer))
            {
                e.Cancel = true;
                tipError.Show("Voer alleen nummers in", txtHuisnummer, 0, -34, 4000);
                return;
            }
        }
    }
}
