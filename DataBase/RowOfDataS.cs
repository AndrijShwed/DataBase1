using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class RowOfDataS
    {
        public object surname { get; set; }

        public RowOfDataS() { }

        public RowOfDataS(object _Побатькові)
        {
            surname = _Побатькові;
        }

        public void DataChange(object _Побатькові)
        {
            surname = _Побатькові;

        }
    }
}
