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
            weddingPlanData = DatasetFactory.WeddingPlan;
        }

        private void tsbAddGast_Click(object sender, EventArgs e)
        {
            AddGast addGastForm = new AddGast(weddingPlanData.Gast.NewGastRow());
            if ((addGastForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK))
            {
                DatasetFactory.WeddingPlan.Gast.AddGastRow(addGastForm.Gast); // TODO nettere oplossing
            }
        }
    }
}
