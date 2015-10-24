using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THWeddingPlanner.Data;

namespace THWeddingPlanner.Persistence
{
    interface IPersistenceManager
    {
        void Save(WeddingPlan weddingPlan);
        void Save(WeddingPlan weddingPlan, string path);
        WeddingPlan Load();
        WeddingPlan Load(string path);

    }
}
