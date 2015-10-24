using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THWeddingPlanner.Persistence
{
    class FileManager : IPersistenceManager
    {
        private const string _path = @"C:\test\weddingplanner";
        public void Save(Data.WeddingPlan weddingPlan)
        {
            Save(weddingPlan, _path);
        }

        public void Save(Data.WeddingPlan weddingPlan, string path)
        {
            weddingPlan.WriteXml(path, System.Data.XmlWriteMode.WriteSchema);
        }

        public Data.WeddingPlan Load()
        {
            return Load(_path);
        }

        public Data.WeddingPlan Load(string path)
        {
            var plan = new Data.WeddingPlan();
            plan.ReadXml(path, System.Data.XmlReadMode.Auto);
            return plan;
        }
    }
}
