using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class RowOfDataL
    {
       
        public object lastname { get; set; }
       
        public RowOfDataL() { }

        public RowOfDataL(object _Прізвище)
        { 
            lastname = _Прізвище;
        }

        public void DataChange(object _Прізвище)
        {
            lastname = _Прізвище;
            
        }

    }
}
