using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace DataBase
{
    public partial class Населені_Пункти : Form
    {
        private User user;
        List<RowOfVillage> _data = new List<RowOfVillage>();
        List<VillageStreet> data = new List<VillageStreet>();

        public Населені_Пункти()
        {
            InitializeComponent();
            HeaderOfTheTable();
           
        }
        private void HeaderOfTheTable()
        {

            bool mess = false;
            data.Clear();

            ConnectionClass _manager = new ConnectionClass();
            MySqlDataReader _reader;
            _manager.openConnection();

            string reader = "SELECT DISTINCT village FROM villagestreet";
            MySqlCommand _search = new MySqlCommand(reader, _manager.getConnection());
            _reader = _search.ExecuteReader();

            while (_reader.Read())
            {
                VillageStreet row = new VillageStreet(_reader["village"]);
                data.Add(row);

            }
            _reader.Close();
            _manager.closeConnection();

            this.dataGridViewНаселені_Пункти.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            this.dataGridViewНаселені_Пункти.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewНаселені_Пункти.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            this.dataGridViewНаселені_Пункти.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewНаселені_Пункти.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            this.dataGridViewНаселені_Пункти.EnableHeadersVisualStyles = false;

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер";
            column1.Width = 120;
            column1.Name = "id";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Рік";
            column2.Width = 120;
            column2.Name = "year";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            List<DataGridViewColumn> col = new List<DataGridViewColumn>();

            for (int i = 3; i < data.Count + 3; i++)
            {
                var columni = new DataGridViewColumn();
                columni.HeaderText = data[i-3].village.ToString();
                columni.Width = 120;
                columni.Name = data[i-3].village.ToString();
                columni.Frozen = true;
                columni.CellTemplate = new DataGridViewTextBoxCell();
                col.Add(columni);
            }
            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Всього";
            column8.Width = 120;
            column8.Name = "all";
            column8.Frozen = true;
            column8.DefaultCellStyle.Format = "d";
            column8.CellTemplate = new DataGridViewTextBoxCell();


            dataGridViewНаселені_Пункти.Columns.Add(column1);
            dataGridViewНаселені_Пункти.Columns.Add(column2);
            for(int i = 0; i < col.Count; i++)
            {
                dataGridViewНаселені_Пункти.Columns.Add(col[i]);
            }
            dataGridViewНаселені_Пункти.Columns.Add(column8);


            dataGridViewНаселені_Пункти.AllowUserToAddRows = false;
            dataGridViewНаселені_Пункти.ReadOnly = true;
        }
        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Close();
            form.Show();
        }

        private void ButtonПовернутись_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Close();
            form.Show();
        }
        private void AddDataGrid(RowOfVillage row)
        {
            dataGridViewНаселені_Пункти.Rows.Add(row.id, row.year, row.berezhnytsya, row.zabolotivtsi, row.rogizno, row.zhuravkiv,
                row.zagurzchyna, row.all);
        }

        private void buttonОновити_Click(object sender, EventArgs e)
        {
            dataGridViewНаселені_Пункти.DataSource = null;
            dataGridViewНаселені_Пункти.Rows.Clear();
            _data.Clear();

            user = new User();

            int yearNow = Convert.ToInt32(DateTime.Now.Year);

           
            ConnectionClass _manager = new ConnectionClass();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM count_peoples", _manager.getConnection());
            MySqlDataReader _reader;

            _manager.openConnection();
            _reader = _command.ExecuteReader();

            try
            {


                while (_reader.Read())
                {
                    RowOfVillage row = new RowOfVillage(_reader["id"], _reader["year"], _reader["berezhnytsya"], _reader["zabolotivtsi"],
                        _reader["rogizno"], _reader["zhuravkiv"], _reader["zagurzchyna"], _reader["all"]);
                    _data.Add(row);
                }

                for (int i = 0; i < _data.Count; i++)
                {
                    AddDataGrid(_data[i]);
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


            _manager.openConnection();


            this.dataGridViewНаселені_Пункти.Rows.Add();

            string count_ber = "SELECT COUNT(*) FROM people WHERE village = 'Бережниця'";
            string count_zab = "SELECT COUNT(*) FROM people WHERE village = 'Заболотівці'";
            string count_rog = "SELECT COUNT(*) FROM people WHERE village = 'Рогізно'";
            string count_zhur = "SELECT COUNT(*) FROM people WHERE village = 'Журавків'";
            string count_zag = "SELECT COUNT(*) FROM people WHERE village = 'Загурщина'";
            MySqlCommand search_ber = new MySqlCommand(count_ber, _manager.getConnection());

            MySqlCommand search_zab = new MySqlCommand(count_zab, _manager.getConnection());

            MySqlCommand search_rog = new MySqlCommand(count_rog, _manager.getConnection());

            MySqlCommand search_zhur = new MySqlCommand(count_zhur, _manager.getConnection());

            MySqlCommand search_zag = new MySqlCommand(count_zag, _manager.getConnection());

            int countRows = _data.Count;

            if (countRows == 0)
            {
                countRows = 1;
            }

            int ber = Convert.ToInt32(search_ber.ExecuteScalar());
            int zab = Convert.ToInt32(search_zab.ExecuteScalar());
            int rog = Convert.ToInt32(search_rog.ExecuteScalar());
            int zhur = Convert.ToInt32(search_zhur.ExecuteScalar());
            int zag = Convert.ToInt32(search_zag.ExecuteScalar());
            int all = ber + zab + rog + zhur + zag;
            string id = Convert.ToString(this.dataGridViewНаселені_Пункти.Rows[countRows - 1].Cells[0].Value);

            dataGridViewНаселені_Пункти.Rows[_data.Count].Cells[1].Value = Convert.ToInt32(DateTime.Now.Year.ToString());
            dataGridViewНаселені_Пункти.Rows[_data.Count].Cells[2].Value = ber;
            dataGridViewНаселені_Пункти.Rows[_data.Count].Cells[3].Value = zab;
            dataGridViewНаселені_Пункти.Rows[_data.Count].Cells[4].Value = rog;
            dataGridViewНаселені_Пункти.Rows[_data.Count].Cells[5].Value = zhur;
            dataGridViewНаселені_Пункти.Rows[_data.Count].Cells[6].Value = zag;
            dataGridViewНаселені_Пункти.Rows[_data.Count].Cells[7].Value = all;

            try
            {
                string count = "SELECT COUNT(*) FROM count_peoples WHERE year = '" + yearNow + "'";
                MySqlCommand isYear = new MySqlCommand(count, _manager.getConnection());
                int yes = Convert.ToInt32(isYear.ExecuteScalar());
                //int yes = 0;
                if (yes == 0)
                {

                    string addYear = "INSERT INTO `count_peoples` (`year`, `berezhnytsya`, `zabolotivtsi`, `rogizno`, `zhuravkiv`, `zagurzchyna`, `all`)" +
                        " VALUES('" + yearNow + "', '" + ber + "', '" + zab + "', '" + rog + "', '" + zhur + "', '" + zag + "', '" + all + "')";
                    MySqlCommand add = new MySqlCommand(addYear, _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                else
                {

                    string addYear = "UPDATE `count_peoples` SET `berezhnytsya` = '" + ber + "', `zabolotivtsi` = '" + zab + "'," +
                        " `rogizno` = '" + rog + "', `zhuravkiv` = '" + zhur + "', `zagurzchyna` = '" + zag + "', `all` = '" + all + "' WHERE(`id` = '" + id + "')";

                    MySqlCommand add = new MySqlCommand(addYear, _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                _manager.closeConnection();
            }
            catch
            {
                MessageBox.Show("Помилка !!!");
            }

        }

        private void buttonВихідЗПрограми_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
