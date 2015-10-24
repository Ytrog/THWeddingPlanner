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
    public partial class ManageTiers : Form
    {
        public ManageTiers()
        {
            InitializeComponent();
            dgvTiers.AutoGenerateColumns = false;
            dgvTiers.DataSource = Data.DatasetFactory.WeddingPlan.Tier;
        }

        private void dgvTiers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Commit();
        }

        private void Commit()
        {
            Data.DatasetFactory.WeddingPlan.Tier.AcceptChanges();
        }

        private void dgvTiers_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Commit();
        }

        private void ManageTiers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Commit();
        }
    }
}
