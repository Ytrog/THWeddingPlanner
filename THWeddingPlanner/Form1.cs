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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbGasten_Click(object sender, EventArgs e)
        {
            Gasten gastenForm = new Gasten();
            gastenForm.ShowDialog(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Persistence.PersistenceManagerFactory.Instance.Save(Data.DatasetFactory.WeddingPlan);
        }
    }
}
