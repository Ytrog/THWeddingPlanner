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
            FillAddressDropDown();
        }

        public THWeddingPlanner.Data.WeddingPlan.GastRow Gast { get; private set; }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            AddAdres addressForm = new AddAdres();
            addressForm.ShowDialog(this);
            FillAddressDropDown();
            FillTierDropDown();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Gast.Achternaam = txtAchternaam.Text;
            Gast.AdresId = -1; // TODO real vals
            Gast.Bijzonderheden = "";
            Gast.DieetAllergie = "";
            Gast.IsKind = false;
            Gast.TierId = -1;
            Gast.Voornaam = "";
        }

        private void FillAddressDropDown()
        {
            cmbAdres.Items.Clear();
            foreach (var a in DatasetFactory.WeddingPlan.Adres)
            {
                cmbAdres.Items.Add(new RowDecorator<THWeddingPlanner.Data.WeddingPlan.AdresRow>(a, x => string.Format("{0} {1}{2} ,{3}", x.Straatnaam, x.Huisnummer, x.Toevoeging, x.Plaats)));
            }
            
        }

        private void btnManageTiers_Click(object sender, EventArgs e)
        {
            ManageTiers tiersDialog = new ManageTiers();
            tiersDialog.ShowDialog(this);
            FillTierDropDown();
        }

        private void FillTierDropDown()
        {
            cmbTier.Items.Clear();
            foreach (var t in DatasetFactory.WeddingPlan.Tier)
            {
                cmbTier.Items.Add(new RowDecorator<THWeddingPlanner.Data.WeddingPlan.TierRow>(t, x => string.Format("{0}", x.Naam)));
            }
        }
    }
}
