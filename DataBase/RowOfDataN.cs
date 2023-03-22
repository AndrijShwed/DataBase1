using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class RowOfDataN
    {
        public object name { get; set; }

        public RowOfDataN() { }

        public RowOfDataN(object _Ім_я)
        {
            name = _Ім_я;
        }

        public void DataChange(object _Ім_я)
        {
            name = _Ім_я;

        }
    }
}
