using System;
using System.Collections.Generic;
using System.IO;
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
            string path = Path.Combine(_path, "plan.xml");
            Save(weddingPlan, path);
        }

        public void Save(Data.WeddingPlan weddingPlan, string path)
        {
            weddingPlan.WriteXml(path, System.Data.XmlWriteMode.WriteSchema);
        }

        public Data.WeddingPlan Load()
        {
            string path = Path.Combine(_path, "plan.xml");
            return Load(path);
        }

        public Data.WeddingPlan Load(string path)
        {
            var plan = Data.DatasetFactory.WeddingPlan;
            plan.ReadXml(path, System.Data.XmlReadMode.IgnoreSchema);
            return plan;
        }
    }
}
