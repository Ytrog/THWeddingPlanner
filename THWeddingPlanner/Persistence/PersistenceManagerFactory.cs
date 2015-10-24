using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THWeddingPlanner.Persistence
{
    class PersistenceManagerFactory
    {
        private static readonly IPersistenceManager _manager = new FileManager();

        public static IPersistenceManager Instance { get { return _manager; } }
    }
}
