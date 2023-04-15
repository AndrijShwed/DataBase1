using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBase
{
    public partial class ПоКількостіКімнат : Form
    {

        private User user;
        List<RowCountOfRooms> _dataBer = new List<RowCountOfRooms>();
        List<RowCountOfRooms> _dataZab = new List<RowCountOfRooms>();
        List<RowCountOfRooms> _dataRog = new List<RowCountOfRooms>();
        List<RowCountOfRooms> _dataZhur = new List<RowCountOfRooms>();
        List<RowCountOfRooms> _dataZag = new List<RowCountOfRooms>();

        public ПоКількостіКімнат()
        {
            InitializeComponent();
            HeaderOfTheTableBer();
            HeaderOfTheTableZab();
            HeaderOfTheTableRog();
            HeaderOfTheTableZhur();
            HeaderOfTheTableZag();
        }
       
        }

        private void HeaderOfTheTableZab()
        {
            this.dataGridViewZabTab.DefaultCellStyle.Font = new Font("TimeNewRoman", 12);
            this.dataGridViewZabTab.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewZabTab.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewZabTab.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Italic);
            this.dataGridViewZabTab.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewZabTab.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            this.dataGridViewZabTab.EnableHeadersVisualStyles = false;
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер";
            column1.Width = 100;
            column1.Name = "id";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер";
            column1.Width = 100;
            column1.Name = "id";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Рік";
            column2.Width = 100;
            column2.Name = "year";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Одно кімн.";
            column3.Width = 150;
            column3.Name = "one";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Дво кімн.";
            column4.Width = 150;
            column4.Name = "two";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Три кімн.";
            column5.Width = 150;
            column5.Name = "three";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Чотири кімн.";
            column6.Width = 150;
            column6.Name = "four";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "П'ять кімн.";
            column7.Width = 150;
            column7.Name = "five";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Шість кімн.";
            column8.Width = 150;
            column8.Name = "six";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Більше шести кімн.";
            column9.Width = 150;
            column9.Name = "more";
            column9.Frozen = true;
            column9.CellTemplate = new DataGridViewTextBoxCell();

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Загальна";
            column10.Width = 150;
            column10.Name = "total";
            column10.Frozen = true;
            column10.CellTemplate = new DataGridViewTextBoxCell();



            dataGridViewRogTab.Columns.Add(column1);
            dataGridViewRogTab.Columns.Add(column2);
            dataGridViewRogTab.Columns.Add(column3);
            dataGridViewRogTab.Columns.Add(column4);
            dataGridViewRogTab.Columns.Add(column5);
            dataGridViewRogTab.Columns.Add(column6);
            dataGridViewRogTab.Columns.Add(column7);
            dataGridViewRogTab.Columns.Add(column8);
            dataGridViewRogTab.Columns.Add(column9);
            dataGridViewRogTab.Columns.Add(column10);



            dataGridViewRogTab.AllowUserToAddRows = false;
            dataGridViewRogTab.ReadOnly = true;
        }


        private void домогосподарстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Домогосподарства form = new Домогосподарства();
            this.Hide();
            form.Show();
        }

        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void вихідToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Домогосподарства form = new Домогосподарства();
            this.Hide();
            form.Show();
        }
        private void AddDataGridBer(RowCountOfRooms row)
        {
            dataGridViewBerTab.Rows.Add(row.id, row.year, row.one_rooms, row.two_rooms,
                row.three_rooms, row.four_rooms, row.five_rooms, row.six_rooms,
                row.more_rooms, row.total);
        }
        private void AddDataGridZab(RowCountOfRooms row)
        {
            dataGridViewZabTab.Rows.Add(row.id, row.year, row.one_rooms, row.two_rooms,
                row.three_rooms, row.four_rooms, row.five_rooms, row.six_rooms,
                row.more_rooms, row.total);
        }
        private void AddDataGridRog(RowCountOfRooms row)
        {
            dataGridViewRogTab.Rows.Add(row.id, row.year, row.one_rooms, row.two_rooms,
                row.three_rooms, row.four_rooms, row.five_rooms, row.six_rooms,
                row.more_rooms, row.total);
        }
        private void AddDataGridZhur(RowCountOfRooms row)
        {
            dataGridViewZhurTab.Rows.Add(row.id, row.year, row.one_rooms, row.two_rooms,
                row.three_rooms, row.four_rooms, row.five_rooms, row.six_rooms,
                row.more_rooms, row.total);
        }
        private void AddDataGridZag(RowCountOfRooms row)
        {
            dataGridViewZagTab.Rows.Add(row.id, row.year, row.one_rooms, row.two_rooms,
                row.three_rooms, row.four_rooms, row.five_rooms, row.six_rooms,
                row.more_rooms, row.total);
        }


        private void Оновити_дані_Click(object sender, EventArgs e)
        {
            dataGridViewBerTab.DataSource = null;
            dataGridViewZabTab.DataSource = null;
            dataGridViewRogTab.DataSource = null;
            dataGridViewZhurTab.DataSource = null;
            dataGridViewZagTab.DataSource = null;
            dataGridViewBerTab.Rows.Clear();
            dataGridViewZabTab.Rows.Clear();
            dataGridViewRogTab.Rows.Clear();
            dataGridViewZhurTab.Rows.Clear();
            dataGridViewZagTab.Rows.Clear();
            _dataBer.Clear();
            _dataZab.Clear();
            _dataRog.Clear();
            _dataZhur.Clear();
            _dataZag.Clear();

            user = new User();

            int yearNow = Convert.ToInt32(DateTime.Now.Year);


            ConnectionClass _manager = new ConnectionClass();
            _manager.openConnection();
            MySqlCommand _commandBer = new MySqlCommand("SELECT * FROM sql8597722.ber_rooms", _manager.getConnection());
            MySqlCommand _commandZab = new MySqlCommand("SELECT * FROM sql8597722.zab_rooms", _manager.getConnection());
            MySqlCommand _commandRog = new MySqlCommand("SELECT * FROM sql8597722.rog_rooms", _manager.getConnection());
            MySqlCommand _commandZhur = new MySqlCommand("SELECT * FROM sql8597722.zhur_rooms", _manager.getConnection());
            MySqlCommand _commandZag = new MySqlCommand("SELECT * FROM sql8597722.zag_rooms", _manager.getConnection());
            MySqlDataReader _reader;

            _reader = _commandBer.ExecuteReader();
           
            try
            {


                while (_reader.Read())
                {
                    RowCountOfRooms row = new RowCountOfRooms(_reader["id"], _reader["year"], _reader["one_rooms"],
                        _reader["two_rooms"], _reader["three_rooms"], _reader["four_rooms"],
                        _reader["five_rooms"], _reader["six_rooms"], _reader["more_rooms"], _reader["total"]);
                    _dataBer.Add(row);
                }

                for (int i = 0; i < _dataBer.Count; i++)
                {
                    AddDataGridBer(_dataBer[i]);
                }
            }
            catch
            {
                MessageBox.Show("Помилка роботи з базою даних !");
            }
            _reader.Close();
            _reader = _commandZab.ExecuteReader();

            try
            {


                while (_reader.Read())
                {
                    RowCountOfRooms row = new RowCountOfRooms(_reader["id"], _reader["year"], _reader["one_rooms"],
                        _reader["two_rooms"], _reader["three_rooms"], _reader["four_rooms"],
                        _reader["five_rooms"], _reader["six_rooms"], _reader["more_rooms"], _reader["total"]);
                    _dataZab.Add(row);
                }

                for (int i = 0; i < _dataZab.Count; i++)
                {
                    AddDataGridZab(_dataZab[i]);
                }
            }
            catch
            {
                MessageBox.Show("Помилка роботи з базою даних !");
            }
            _reader.Close ();
            _reader = _commandRog.ExecuteReader();

            try
            {


                while (_reader.Read())
                {
                    RowCountOfRooms row = new RowCountOfRooms(_reader["id"], _reader["year"], _reader["one_rooms"],
                        _reader["two_rooms"], _reader["three_rooms"], _reader["four_rooms"],
                        _reader["five_rooms"], _reader["six_rooms"], _reader["more_rooms"], _reader["total"]);
                    _dataRog.Add(row);
                }

                for (int i = 0; i < _dataRog.Count; i++)
                {
                    AddDataGridRog(_dataRog[i]);
                }
            }
            catch
            {
                MessageBox.Show("Помилка роботи з базою даних !");
            }
            _reader.Close();
            _reader = _commandZhur.ExecuteReader();
            try
            {


                while (_reader.Read())
                {
                    RowCountOfRooms row = new RowCountOfRooms(_reader["id"], _reader["year"], _reader["one_rooms"],
                        _reader["two_rooms"], _reader["three_rooms"], _reader["four_rooms"],
                        _reader["five_rooms"], _reader["six_rooms"], _reader["more_rooms"], _reader["total"]);
                    _dataZhur.Add(row);
                }

                for (int i = 0; i < _dataZhur.Count; i++)
                {
                    AddDataGridZhur(_dataZhur[i]);
                }
            }
            catch
            {
                MessageBox.Show("Помилка роботи з базою даних !");
            }
            _reader.Close ();
            _reader = _commandZag.ExecuteReader();
            try
            {


                while (_reader.Read())
                {
                    RowCountOfRooms row = new RowCountOfRooms(_reader["id"], _reader["year"], _reader["one_rooms"],
                        _reader["two_rooms"], _reader["three_rooms"], _reader["four_rooms"],
                        _reader["five_rooms"], _reader["six_rooms"], _reader["more_rooms"], _reader["total"]);
                    _dataZag.Add(row);
                }

                for (int i = 0; i < _dataZag.Count; i++)
                {
                    AddDataGridZag(_dataZag[i]);
                }
            }
            catch
            {
                MessageBox.Show("Помилка роботи з базою даних !");
            }
            finally
            {
                _manager.closeConnection();
            }

            this.dataGridViewBerTab.Rows.Add();
            this.dataGridViewRogTab.Rows.Add();
            this.dataGridViewZabTab.Rows.Add();
            this.dataGridViewZhurTab.Rows.Add();
            this.dataGridViewZagTab.Rows.Add();



            string CountRooms(string _village, int _c)
            {
                string village = _village;
                int z = _c;
                string count = "SELECT COUNT(*) FROM houses WHERE village = '" + village + "' AND total_of_rooms = '" + z + "'";
                return count;
            }

            string CountRoomsMore(string _village)
            {
                string village = _village;
                int k = 6;
                string count = "SELECT COUNT(*) FROM houses WHERE village = '" + village + "' AND total_of_rooms > '"+ k +"'";
                return count;
            }
            string Select(string _table)
            {
                string table = _table;
                string countRow = "SELECT COUNT(*) FROM `"+table+"` WHERE year = '" + yearNow + "'";
                return countRow;
            }

            string AddYear(string _table, int one, int two, int three, int four, int five, int six, int more, int total) 
            {
                string table = _table;
               
                string addYear = "INSERT INTO `sql8597722`.`"+table+"` (`year`, `one_rooms`," +
                        " `two_rooms`, `three_rooms`, `four_rooms`, `five_rooms`," +
                        " `six_rooms`, `more_rooms`, `total`) VALUES('" + yearNow + "','" + one + "', '" + two + "'," +
                        " '" + three + "', '" + four + "', '" + five + "', '" + six + "', " +
                        "'" + more + "', '"+ total +"')";
                return addYear;
            }

            string Update(string _table, int one, int two, int three, int four, int five, int six, int more, int total) 
            { 
                string table = _table;
                string addYear = "UPDATE `sql8597722`.`"+table+"` SET `one_rooms` = '" + one + "'," +
                       "`two_rooms`= '" + two + "', `three_rooms` = '" + three + "'," +
                       " `four_rooms`='" + four + "', `five_rooms` = '" + five + "', " +
                       "`six_rooms`= '" + six + "', `more_rooms` = '" + more + "', `total` = '" + total +"'";
                return addYear;
            }

            MySqlCommand search;
            _manager.openConnection();
            int[] ber = new int[7];
            int c;

            int totalBer = 0;
           
            dataGridViewBerTab.Rows[_dataBer.Count].Cells[1].Value = Convert.ToInt32(DateTime.Now.Year.ToString());
            for (int i = 0; i < 6; i++)
            {
                c = i + 1;
                search = new MySqlCommand(CountRooms("Бережниця", c), _manager.getConnection());

                try
                {
                    ber[i] = Convert.ToInt32(search.ExecuteScalar());
                }
                catch
                {
                    MessageBox.Show("Помилка !");
                }
                dataGridViewBerTab.Rows[_dataBer.Count].Cells[i + 2].Value = ber[i];
                totalBer += ber[i];
            }
            search = new MySqlCommand(CountRoomsMore("Бережниця"), _manager.getConnection());
            ber[6] = Convert.ToInt32(search.ExecuteScalar());
            dataGridViewBerTab.Rows[_dataBer.Count].Cells[8].Value = ber[6];
            dataGridViewBerTab.Rows[_dataBer.Count].Cells[9].Value = totalBer;
            try
            {
              
                MySqlCommand isYear = new MySqlCommand(Select("ber_rooms"), _manager.getConnection());
                int yes = Convert.ToInt32(isYear.ExecuteScalar());

                if (yes == 0)
                {
                    MySqlCommand add = new MySqlCommand(AddYear("ber_rooms", ber[0], ber[1], ber[2], ber[3], ber[4], ber[5], ber[6], totalBer), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                else
                {

                    MySqlCommand add = new MySqlCommand(Update("ber_rooms", ber[0], ber[1], ber[2], ber[3], ber[4], ber[5], ber[6], totalBer), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                _manager.closeConnection();
            }
            catch
            {
                MessageBox.Show("Помилка !!!");
            }

            _manager.openConnection();
            int totalZab = 0;
            int[] zab = new int[7];
            dataGridViewZabTab.Rows[_dataZab.Count].Cells[1].Value = Convert.ToInt32(DateTime.Now.Year.ToString());
            for (int i = 0; i < 6; i++)
            {
                c = i + 1;
                search = new MySqlCommand(CountRooms("Заболотівці", c), _manager.getConnection());

                try
                {
                    zab[i] = Convert.ToInt32(search.ExecuteScalar());
                }
                catch
                {
                    MessageBox.Show("Помилка !");
                }
                dataGridViewZabTab.Rows[_dataZab.Count].Cells[i + 2].Value = zab[i];
                totalZab  +=  zab[i];
            }
            search = new MySqlCommand(CountRoomsMore("Заболотівці"), _manager.getConnection());
            zab[6] = Convert.ToInt32(search.ExecuteScalar());
            dataGridViewZabTab.Rows[_dataZab.Count].Cells[8].Value = zab[6];
            dataGridViewZabTab.Rows[_dataZab.Count].Cells[9].Value = totalZab;
            try
            {
               
                MySqlCommand isYear = new MySqlCommand(Select("zab_rooms"), _manager.getConnection());
                int yes = Convert.ToInt32(isYear.ExecuteScalar());

                if (yes == 0)
                {
                    MySqlCommand add = new MySqlCommand(AddYear("zab_rooms", zab[0], zab[1], zab[2], zab[3], zab[4], zab[5], zab[6], totalZab), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                else
                {

                    MySqlCommand add = new MySqlCommand(Update("zab_rooms", zab[0], zab[1], zab[2], zab[3], zab[4], zab[5], zab[6], totalZab), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                _manager.closeConnection();
            }
            catch
            {
                MessageBox.Show("Помилка !!!");
            }
            _manager.openConnection();
            int totalRog = 0;
            int[] rog = new int[7];
            dataGridViewRogTab.Rows[_dataRog.Count].Cells[1].Value = Convert.ToInt32(DateTime.Now.Year.ToString());
            for (int i = 0; i < 6; i++)
            {
                c = i + 1;
                search = new MySqlCommand(CountRooms("Рогізно", c), _manager.getConnection());

                try
                {
                    rog[i] = Convert.ToInt32(search.ExecuteScalar());
                }
                catch
                {
                    MessageBox.Show("Помилка !");
                }
                dataGridViewRogTab.Rows[_dataRog.Count].Cells[i + 2].Value = rog[i];
                totalRog += rog[i];
            }
            search = new MySqlCommand(CountRoomsMore("Рогізно"), _manager.getConnection());
            rog[6] = Convert.ToInt32(search.ExecuteScalar());
            dataGridViewRogTab.Rows[_dataRog.Count].Cells[8].Value = rog[6];
            dataGridViewRogTab.Rows[_dataRog.Count].Cells[9].Value = totalRog;
            try
            {
                MySqlCommand isYear = new MySqlCommand(Select("rog_rooms"), _manager.getConnection());
                int yes = Convert.ToInt32(isYear.ExecuteScalar());

                if (yes == 0)
                {
                    MySqlCommand add = new MySqlCommand(AddYear("rog_rooms", rog[0], rog[1], rog[2], rog[3], rog[4], rog[5], rog[6], totalRog), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                else
                {

                    MySqlCommand add = new MySqlCommand(Update("rog_rooms", rog[0], rog[1], rog[2], rog[3], rog[4], rog[5], rog[6], totalRog), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                _manager.closeConnection();
            }
            catch
            {
                MessageBox.Show("Помилка !!!");
            }
            _manager.openConnection();
            int totalZhur = 0;
            int[] zhur = new int[7];
            dataGridViewZhurTab.Rows[_dataZhur.Count].Cells[1].Value = Convert.ToInt32(DateTime.Now.Year.ToString());
            for (int i = 0; i < 6; i++)
            {
                c = i + 1;
                search = new MySqlCommand(CountRooms("Журавків", c), _manager.getConnection());

                try
                {
                    zhur[i] = Convert.ToInt32(search.ExecuteScalar());
                }
                catch
                {
                    MessageBox.Show("Помилка !");
                }
                dataGridViewZhurTab.Rows[_dataZhur.Count].Cells[i + 2].Value = zhur[i];
                totalZhur += zhur[i];
            }
            search = new MySqlCommand(CountRoomsMore("Журавків"), _manager.getConnection());
            zhur[6] = Convert.ToInt32(search.ExecuteScalar());
            dataGridViewZhurTab.Rows[_dataZhur.Count].Cells[8].Value = zhur[6];
            dataGridViewZhurTab.Rows[_dataZhur.Count].Cells[9].Value = totalZhur;
            try
            {
               
                MySqlCommand isYear = new MySqlCommand(Select("zhur_rooms"), _manager.getConnection());
                int yes = Convert.ToInt32(isYear.ExecuteScalar());

                if (yes == 0)
                {
                    MySqlCommand add = new MySqlCommand(AddYear("zhur_rooms", zhur[0], zhur[1], zhur[2], zhur[3], zhur[4], zhur[5], zhur[6], totalZhur), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                else
                {

                    MySqlCommand add = new MySqlCommand(Update("zhur_rooms", zhur[0], zhur[1], zhur[2], zhur[3], zhur[4], zhur[5], zhur[6], totalZhur), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                _manager.closeConnection();
            }
            catch
            {
                MessageBox.Show("Помилка !!!");
            }
            _manager.openConnection();
            int totalZag = 0;
            int[] zag = new int[7];
            dataGridViewZagTab.Rows[_dataZag.Count].Cells[1].Value = Convert.ToInt32(DateTime.Now.Year.ToString());
            for (int i = 0; i < 6; i++)
            {
                c = i + 1;
                search = new MySqlCommand(CountRooms("Загурщина", c), _manager.getConnection());

                try
                {
                    zag[i] = Convert.ToInt32(search.ExecuteScalar());
                }
                catch
                {
                    MessageBox.Show("Помилка !");
                }
                dataGridViewZagTab.Rows[_dataZag.Count].Cells[i + 2].Value = zag[i];
                totalZag += zag[i];
            }
            search = new MySqlCommand(CountRoomsMore("Загурщина"), _manager.getConnection());
            zag[6] = Convert.ToInt32(search.ExecuteScalar());
            dataGridViewZagTab.Rows[_dataZag.Count].Cells[8].Value = zag[6];
            dataGridViewZagTab.Rows[_dataZag.Count].Cells[9].Value = totalZag;
            try
            {
               
                MySqlCommand isYear = new MySqlCommand(Select("zag_rooms"), _manager.getConnection());
                int yes = Convert.ToInt32(isYear.ExecuteScalar());

                if (yes == 0)
                {
                    MySqlCommand add = new MySqlCommand(AddYear("zag_rooms", zag[0], zag[1], zag[2], zag[3], zag[4], zag[5], zag[6], totalZag), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                else
                {

                    MySqlCommand add = new MySqlCommand(Update("zag_rooms", zag[0], zag[1], zag [2], zag[3], zag[4], zag[5], zag[6], totalZag), _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                _manager.closeConnection();
            }
            catch
            {
                MessageBox.Show("Помилка !!!");
            }

        }


    }
}
