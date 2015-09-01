using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THWeddingPlanner.Data
{
    static class DatasetFactory
    {
        private static readonly Data.WeddingPlan _weddingPlan = new WeddingPlan();

        public static WeddingPlan WeddingPlan { get { return _weddingPlan; } }
    }
}
