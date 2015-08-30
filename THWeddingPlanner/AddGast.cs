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
    public partial class AddGast : Form
    {
        public AddGast()
        {
            InitializeComponent();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            AddAdres addressForm = new AddAdres();
            addressForm.ShowDialog(this);
        }
    }
}
