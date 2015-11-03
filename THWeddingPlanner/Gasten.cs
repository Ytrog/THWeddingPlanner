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
    public partial class Gasten : Form
    {
        public Gasten()
        {
            InitializeComponent();
            //weddingPlanData = DatasetFactory.WeddingPlan;
            dgvGasten.AutoGenerateColumns = false;
            ReloadDataSource();
        }

        private void tsbAddGast_Click(object sender, EventArgs e)
        {
            AddGast addGastForm = new AddGast(Data.DatasetFactory.WeddingPlan.Gast.NewGastRow());
            if ((addGastForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK))
            {
                DatasetFactory.WeddingPlan.Gast.AddGastRow(addGastForm.Gast); // TODO nettere oplossing
                DatasetFactory.WeddingPlan.Gast.AcceptChanges();
                ReloadDataSource();
            }
        }

        private void ReloadDataSource()
        {
            dgvGasten.DataSource = null;
            dgvGasten.DataSource = DatasetFactory.WeddingPlan.Gast;
            dgvGasten.Refresh();
        }
    }
}
