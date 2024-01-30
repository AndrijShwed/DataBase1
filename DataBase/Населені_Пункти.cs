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

            //bool mess = false;
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
            this.dataGridViewНаселені_Пункти.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                columni.HeaderText = data[i - 3].village.ToString();
                columni.Width = 120;
                columni.Name = data[i - 3].village.ToString();
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
            for (int i = 0; i < col.Count; i++)
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

        private void buttonОновити_Click(object sender, EventArgs e)
        {
            dataGridViewНаселені_Пункти.DataSource = null;
            dataGridViewНаселені_Пункти.Rows.Clear();
            _data.Clear();

            user = new User();

            int yearNow = Convert.ToInt32(DateTime.Now.Year);

            ConnectionClass _manager = new ConnectionClass();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM c_people", _manager.getConnection());
            MySqlDataReader _reader;

            _manager.openConnection();
            _reader = _command.ExecuteReader();

            int r = 0;
            int k = 0;
            this.dataGridViewНаселені_Пункти.Rows.Add();
            try
            {
                while (_reader.Read())
                {
                    RowOfVillage row = new RowOfVillage(_reader["id"], _reader["year"], _reader["village"], _reader["count"]);
                    _data.Add(row);
                }

                int year = Convert.ToInt32(_data[0].year);

                int s = 0;

                for (int i = 0; i < _data.Count; i++)
                {
                    if (year == Convert.ToInt32(_data[i].year))
                    {
                        dataGridViewНаселені_Пункти.Rows[r].Cells[0].Value = r + 1;
                        dataGridViewНаселені_Пункти.Rows[r].Cells[1].Value = year.ToString();
                        dataGridViewНаселені_Пункти.Rows[r].Cells[k + 2].Value = Convert.ToInt32(_data[i].count);
                        s += Convert.ToInt32(_data[i].count);
                        dataGridViewНаселені_Пункти.Rows[r].Cells[data.Count + 2].Value = s;
                        k++;
                    }
                    else
                    {
                        dataGridViewНаселені_Пункти.Rows.Add();
                        r++;
                        s = 0;
                        k = 0;
                        dataGridViewНаселені_Пункти.Rows[r].Cells[k + 2].Value = Convert.ToInt32(_data[i].count);
                        s += Convert.ToInt32(_data[i].count);
                        k = 1;

                        year = Convert.ToInt32(_data[i].year);

                    }

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

            List<string> count_v = new List<string>();
            this.dataGridViewНаселені_Пункти.Rows.Add();

            for (int i = 0; i < data.Count; i++)
            {
                string count1 = "SELECT COUNT(*) FROM people WHERE village = '" + data[i].village.ToString() + "' AND registr = 'так'";
                count_v.Add(count1);
            }


            int all = 0;
            List<int> sum_v = new List<int>();
            for (int i = 0; i < data.Count; i++)
            {
                MySqlCommand search = new MySqlCommand(count_v[i], _manager.getConnection());
                int sum = Convert.ToInt32(search.ExecuteScalar());
                all += sum;
                sum_v.Add(sum);
            }

            dataGridViewНаселені_Пункти.Rows[r + 1].Cells[1].Value = Convert.ToInt32(DateTime.Now.Year.ToString());
            for (int i = 0; i < data.Count; i++)
            {
                dataGridViewНаселені_Пункти.Rows[r + 1].Cells[i + 2].Value = sum_v[i];
            }

            dataGridViewНаселені_Пункти.Rows[r + 1].Cells[7].Value = all;

            try
            {
                string count = "SELECT COUNT(*) FROM c_people WHERE year = '" + yearNow + "'";
                MySqlCommand isYear = new MySqlCommand(count, _manager.getConnection());
                int yes = Convert.ToInt32(isYear.ExecuteScalar());
                //int yes = 0;
                if (yes == 0)
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        string addYear = "INSERT INTO `c_people` (`village`,`year`, `count`)" +
                       " VALUES('" + data[i].village.ToString() + "', '" + yearNow + "', '" + sum_v[i] + "')";
                        MySqlCommand add = new MySqlCommand(addYear, _manager.getConnection());
                        add.ExecuteNonQuery();
                    }

                }
                else
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        string addYear = "UPDATE `c_people` SET `count` = '" + sum_v[i] + "' WHERE(`year` = '" + yearNow + "' " +
                        "AND `village` = '" + _data[i].village.ToString() + "')";

                        MySqlCommand add = new MySqlCommand(addYear, _manager.getConnection());
                        add.ExecuteNonQuery();
                    }


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
