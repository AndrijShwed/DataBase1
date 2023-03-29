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
    internal class RowOfVillageArea
    {
        public object id { get; set; }
        public object year { get; set; }
        public object berezhnytsya_total { get; set; }
        public object berezhnytsya_living { get; set; }
        public object zabolotivtsi_total { get; set; }
        public object zabolotivtsi_living { get; set; }
        public object rogizno_total { get; set; }
        public object rogizno_living { get; set; }
        public object zhuravkiv_total { get; set; }
        public object zhuravkiv_living { get; set; }
        public object zagurzchyna_total { get; set; }
        public object zagurzchyna_living { get; set; }
        public object all_total { get; set; }
        public object all_living { get; set; }

        public RowOfVillageArea() { }

        public RowOfVillageArea(object _id, object _year, object _berezhnytsya_total, object _berezhnytsya_living, 
            object _zabolotivtsi_total, object _zabolotivtsi_living, object _rogizno_total, object _rogizno_living,
           object _zhuravkiv_total, object _zhuravkiv_living, object _zagurzchyna_total, object _zagurzchyna_living,
           object _all_total, object _all_living)
        {
            id = _id;
            year = _year;
            berezhnytsya_total = _berezhnytsya_total;
            berezhnytsya_living = _berezhnytsya_living;
            zabolotivtsi_total = _zabolotivtsi_total;
            zabolotivtsi_living = _zabolotivtsi_living;
            rogizno_total = _rogizno_total;
            rogizno_living = _rogizno_living;
            zhuravkiv_total = _zhuravkiv_total;
            zhuravkiv_living = _zhuravkiv_living;
            zagurzchyna_total = _zagurzchyna_total;
            zagurzchyna_living = _zagurzchyna_living;
            all_total = _all_total;
            all_living = _all_living;
        }

        public void DataChange(object _id, object _year, object _berezhnytsya_total, object _berezhnytsya_living,
            object _zabolotivtsi_total, object _zabolotivtsi_living, object _rogizno_total, object _rogizno_living,
           object _zhuravkiv_total, object _zhuravkiv_living, object _zagurzchyna_total, object _zagurzchyna_living,
           object _all_total, object _all_living)
        {
            id = _id;
            year = _year;
            berezhnytsya_total = _berezhnytsya_total;
            berezhnytsya_living = _berezhnytsya_living;
            zabolotivtsi_total = _zabolotivtsi_total;
            zabolotivtsi_living = _zabolotivtsi_living;
            rogizno_total = _rogizno_total;
            rogizno_living = _rogizno_living;
            zhuravkiv_total = _zhuravkiv_total;
            zhuravkiv_living = _zhuravkiv_living;
            zagurzchyna_total = _zagurzchyna_total;
            zagurzchyna_living = _zagurzchyna_living;
            all_total = _all_total;
            all_living = _all_living;
        }


    }
}
