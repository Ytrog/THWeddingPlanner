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
            Gast.AdresId = GetAdresId(); 
            Gast.Bijzonderheden = txtBijzonderheden.Text;
            Gast.DieetAllergie = txtDieet.Text;
            Gast.IsKind = cbKind.Checked;
            Gast.TierId = GetTierId();
            Gast.Voornaam = txtVoornaam.Text;
        }

        private int GetTierId()
        {
            return GetIdFromComboBox<THWeddingPlanner.Data.WeddingPlan.TierRow>(cmbTier);
        }

        private int GetAdresId()
        {
            //var item = cmbAdres.SelectedItem as RowDecorator<THWeddingPlanner.Data.WeddingPlan.AdresRow>;
            //if (item == null)
            //{
            //    return -1;
            //}

            //return item.Row.Id;

            return GetIdFromComboBox<THWeddingPlanner.Data.WeddingPlan.AdresRow>(cmbAdres);
        }

        private int GetIdFromComboBox<T>(ComboBox box) where T:DataRow
        {
            var item = box.SelectedItem as RowDecorator<T>;
            if (item == null)
            {
                return -1;
            }

            dynamic row = item.Row;

            return row.Id;
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
