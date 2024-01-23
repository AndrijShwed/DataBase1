using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase
{
    internal class RowOfVillage
    {
        public object id { get; set; }
        public object year { get; set; }
        public object  berezhnytsya { get; set; }
        public object zabolotivtsi { get; set; }
        public object rogizno { get; set; }
        public object zhuravkiv { get; set; }
        public object zagurzchyna { get; set; }
        public object all { get; set; }
       
        public RowOfVillage() { }

        public RowOfVillage(object _id, object _year, object _berezhnytsya, object _zabolotivtsi, object _rogizno,
           object _zhuravkiv, object _zagurzchyna, object _all)
        {
            id = _id;
            year = _year;
            berezhnytsya = _berezhnytsya;
            zabolotivtsi = _zabolotivtsi;
            rogizno = _rogizno;
            zhuravkiv = _zhuravkiv;
            zagurzchyna = _zagurzchyna;
            all = _all;
        }

        public void DataChange(object _id, object _year, object _berezhnytsya, object _zabolotivtsi, object _rogizno, object _zhuravkiv,
            object _zagurzchyna, object _all)
        {
            id = _id;
            year = _year;
            berezhnytsya = _berezhnytsya;
            zabolotivtsi = _zabolotivtsi;
            rogizno = _rogizno;
            zhuravkiv = _zhuravkiv;
            zagurzchyna = _zagurzchyna;
            all = _all;

        }



    }
}
