using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THWeddingPlanner.Data;

namespace THWeddingPlanner
{
    public partial class AddGast : Form
    {
        public AddGast()
        {
            InitializeComponent();
        }

        public AddGast(WeddingPlan.GastRow newRow): this()
        {
            Gast = newRow;
        }

        public THWeddingPlanner.Data.WeddingPlan.GastRow Gast { get; private set; }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            AddAdres addressForm = new AddAdres();
            addressForm.ShowDialog(this);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Gast.Achternaam = "";
            Gast.AdresId = -1;
            Gast.Bijzonderheden = "";
            Gast.DieetAllergie = "";
            Gast.IsKind = false;
            Gast.TierId = -1;
            Gast.Voornaam = "";
        }
    }
}
