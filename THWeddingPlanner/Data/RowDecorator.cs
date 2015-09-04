using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THWeddingPlanner.Data
{
    class RowDecorator<T> where T : System.Data.DataRow
    {
        private Func<T, string> _formatter;
        public RowDecorator(T row, Func<T,string> formatter)
        {
            if (row == null)
            {
                throw new ArgumentNullException("row");
            }
            if (formatter == null)
            {
                throw new ArgumentNullException("formatter");
            }
            Row = row;
            _formatter = formatter;
        }

        public T Row { get; private set; }

        public override string ToString()
        {
            return _formatter(Row);
        }
    }
}
