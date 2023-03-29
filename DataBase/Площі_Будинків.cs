using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Площі_Будинків : Form
    {
        private User user;
        List<RowOfVillageArea> _data = new List<RowOfVillageArea>();

        public Площі_Будинків()
        {
            InitializeComponent();
            HeaderOfTheTable();

        }
        private void HeaderOfTheTable()
        {
            this.dataGridViewArea.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            this.dataGridViewArea.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewArea.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            this.dataGridViewArea.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewArea.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            this.dataGridViewArea.EnableHeadersVisualStyles = false;

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер";
            column1.Width = 70;
            column1.Name = "id";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Рік";
            column2.Width = 70;
            column2.Name = "year";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Бережниця заг. пл.";
            column3.Width = 110;
            column3.Name = "berezhnytsya";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Бережниця житл. пл.";
            column4.Width = 110;
            column4.Name = "berezhnytsya";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Заболотівці заг. пл.";
            column5.Width = 110;
            column5.Name = "zabolotivtsi";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Заболотівці житл. пл.";
            column6.Width = 110;
            column6.Name = "zabolotivtsi";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Рогізно заг. пл.";
            column7.Width = 110;
            column7.Name = "rogizno";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Рогізно житл. пл.";
            column8.Width = 110;
            column8.Name = "rogizno";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Журавків заг. пл.";
            column9.Width = 110;
            column9.Name = "zhuravkiv";
            column9.Frozen = true;
            column9.CellTemplate = new DataGridViewTextBoxCell();

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Журавків житл. пл.";
            column10.Width = 110;
            column10.Name = "zhuravkiv";
            column10.Frozen = true;
            column10.CellTemplate = new DataGridViewTextBoxCell();

            var column11 = new DataGridViewColumn();
            column11.HeaderText = "Загурщина заг. пл.";
            column11.Width = 110;
            column11.Name = "zagurzchyna";
            column11.Frozen = true;
            column11.DefaultCellStyle.Format = "d";
            column11.CellTemplate = new DataGridViewTextBoxCell();

            var column12 = new DataGridViewColumn();
            column12.HeaderText = "Загурщина житл. пл.";
            column12.Width = 110;
            column12.Name = "zagurzchyna";
            column12.Frozen = true;
            column12.DefaultCellStyle.Format = "d";
            column12.CellTemplate = new DataGridViewTextBoxCell();

            var column13 = new DataGridViewColumn();
            column13.HeaderText = "Всього заг. пл.";
            column13.Width = 110;
            column13.Name = "all";
            column13.Frozen = true;
            column13.DefaultCellStyle.Format = "d";
            column13.CellTemplate = new DataGridViewTextBoxCell();

            var column14= new DataGridViewColumn();
            column14.HeaderText = "Всього заг. пл.";
            column14.Width = 110;
            column14.Name = "all";
            column14.Frozen = true;
            column14.DefaultCellStyle.Format = "d";
            column14.CellTemplate = new DataGridViewTextBoxCell();


            dataGridViewArea.Columns.Add(column1);
            dataGridViewArea.Columns.Add(column2);
            dataGridViewArea.Columns.Add(column3);
            dataGridViewArea.Columns.Add(column4);
            dataGridViewArea.Columns.Add(column5);
            dataGridViewArea.Columns.Add(column6);
            dataGridViewArea.Columns.Add(column7);
            dataGridViewArea.Columns.Add(column8);
            dataGridViewArea.Columns.Add(column9);
            dataGridViewArea.Columns.Add(column10);
            dataGridViewArea.Columns.Add(column11);
            dataGridViewArea.Columns.Add(column12);
            dataGridViewArea.Columns.Add(column13);
            dataGridViewArea.Columns.Add(column14);


            dataGridViewArea.AllowUserToAddRows = false;
            dataGridViewArea.ReadOnly = true;
        }
        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void домогосподарстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Домогосподарства form = new Домогосподарства();
            this.Hide();
            form.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AddDataGrid(RowOfVillageArea row)
        {
            dataGridViewArea.Rows.Add(row.id, row.year, row.berezhnytsya_total, row.berezhnytsya_living,
                row.zabolotivtsi_total, row.zabolotivtsi_living, row.rogizno_total, row.rogizno_living,
                row.zhuravkiv_total, row.zhuravkiv_living, row.zagurzchyna_total, row.zagurzchyna_living,
                row.all_total, row.all_living);
        }

        private void Оновити_Click(object sender, EventArgs e)
        {
            dataGridViewArea.DataSource = null;
            dataGridViewArea.Rows.Clear();
            _data.Clear();

            user = new User();

            int yearNow = Convert.ToInt32(DateTime.Now.Year);


            ConnectionClass _manager = new ConnectionClass();
           
            MySqlCommand _command = new MySqlCommand("SELECT * FROM areas_of_houses", _manager.getConnection());
            MySqlDataReader _reader;
            _manager.openConnection();
            _reader = _command.ExecuteReader();

            try
            {


                while (_reader.Read())
                {
                    RowOfVillageArea row = new RowOfVillageArea(_reader["id"], _reader["year"], _reader["berezhnytsya_total"],
                        _reader["berezhnytsya_living"], _reader["zabolotivtsi_total"], _reader["zabolotivtsi_living"],
                        _reader["rogizno_total"], _reader["rogizno_living"], _reader["zhuravkiv_total"], _reader["zhuravkiv_living"], 
                        _reader["zagurzchyna_total"], _reader["zagurzchyna_living"], _reader["all_total"], _reader["all_living"]);
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


            this.dataGridViewArea.Rows.Add();

            string count_ber_total = "SELECT totalArea FROM houses WHERE village = 'Бережниця'";
            string count_ber_living = "SELECT livingArea FROM houses WHERE village = 'Бережниця'";
            string count_zab_total = "SELECT totalArea FROM houses WHERE village = 'Заболотівці'";
            string count_zab_living = "SELECT livingArea FROM houses WHERE village = 'Заболотівці'";
            string count_rog_total = "SELECT totalArea FROM houses WHERE village = 'Рогізно'";
            string count_rog_living = "SELECT livingArea FROM houses WHERE village = 'Рогізно'";
            string count_zhur_total = "SELECT totalArea FROM houses WHERE village = 'Журавків'";
            string count_zhur_living = "SELECT livingArea FROM houses WHERE village = 'Журавків'";
            string count_zag_total = "SELECT totalArea FROM houses WHERE village = 'Загурщина'";
            string count_zag_living = "SELECT livingArea FROM houses WHERE village = 'Загурщина'";

            MySqlCommand search_ber_total = new MySqlCommand(count_ber_total, _manager.getConnection());
            MySqlCommand search_ber_living = new MySqlCommand(count_ber_living, _manager.getConnection());

            MySqlCommand search_zab_total = new MySqlCommand(count_zab_total, _manager.getConnection());
            MySqlCommand search_zab_living = new MySqlCommand(count_zab_living, _manager.getConnection());

            MySqlCommand search_rog_total = new MySqlCommand(count_rog_total, _manager.getConnection());
            MySqlCommand search_rog_living = new MySqlCommand(count_rog_living, _manager.getConnection());

            MySqlCommand search_zhur_total = new MySqlCommand(count_zhur_total, _manager.getConnection());
            MySqlCommand search_zhur_living = new MySqlCommand(count_zhur_living, _manager.getConnection());

            MySqlCommand search_zag_total = new MySqlCommand(count_zag_total, _manager.getConnection());
            MySqlCommand search_zag_living = new MySqlCommand(count_zag_living, _manager.getConnection());

            int countRows = _data.Count;

            if (countRows == 0)
            {
                countRows = 1;
            }

            int ber_total = Convert.ToInt32(search_ber_total.ExecuteScalar());
            int ber_living = Convert.ToInt32(search_ber_living.ExecuteScalar());
            int zab_total = Convert.ToInt32(search_zab_total.ExecuteScalar());
            int zab_living = Convert.ToInt32(search_zab_living.ExecuteScalar());
            int rog_total = Convert.ToInt32(search_rog_total.ExecuteScalar());
            int rog_living = Convert.ToInt32(search_rog_living.ExecuteScalar());
            int zhur_total = Convert.ToInt32(search_zhur_total.ExecuteScalar());
            int zhur_living = Convert.ToInt32(search_zhur_living.ExecuteScalar());
            int zag_total = Convert.ToInt32(search_zag_total.ExecuteScalar());
            int zag_living = Convert.ToInt32(search_zag_living.ExecuteScalar());
            int all_total = ber_total + zab_total + rog_total + zhur_total + zag_total;
            int all_living = ber_living + zab_living + rog_living + zhur_living + zag_living;
            string id = Convert.ToString(this.dataGridViewArea.Rows[countRows - 1].Cells[0].Value);

            dataGridViewArea.Rows[_data.Count].Cells[1].Value = Convert.ToInt32(DateTime.Now.Year.ToString());
            dataGridViewArea.Rows[_data.Count].Cells[2].Value = ber_total;
            dataGridViewArea.Rows[_data.Count].Cells[3].Value = ber_living;
            dataGridViewArea.Rows[_data.Count].Cells[4].Value = zab_total;
            dataGridViewArea.Rows[_data.Count].Cells[5].Value = zab_living;
            dataGridViewArea.Rows[_data.Count].Cells[6].Value = rog_total;
            dataGridViewArea.Rows[_data.Count].Cells[7].Value = rog_living;
            dataGridViewArea.Rows[_data.Count].Cells[7].Value = zhur_total;
            dataGridViewArea.Rows[_data.Count].Cells[7].Value = zhur_living;
            dataGridViewArea.Rows[_data.Count].Cells[7].Value = zag_total;
            dataGridViewArea.Rows[_data.Count].Cells[7].Value = zag_living;
            dataGridViewArea.Rows[_data.Count].Cells[7].Value = all_total;
            dataGridViewArea.Rows[_data.Count].Cells[7].Value = all_living;

            try
            {
                string count = "SELECT COUNT(*) FROM areas_of_houses WHERE year = '" + yearNow + "'";
                MySqlCommand isYear = new MySqlCommand(count, _manager.getConnection());
                int yes = Convert.ToInt32(isYear.ExecuteScalar());
                //int yes = 0;
                if (yes == 0)
                {

                    string addYear = "INSERT INTO `sql8597722`.`areas_of_houses` (`year`, `berezhnytsya_total`, `berezhnytsya_living`," +
                        "zabolotivtsi_total`, `zabolotivtsi_living`,`rogizno_total`, `rogizno_living`, `zhuravkiv_total`," +
                        "`zhuravkiv_living`, `zagurzchyna_total`,`zagurzchyna_living`,`all_total`, `all_living`)" +
                        " VALUES('" + yearNow + "', '" + ber_total + "', '" + ber_living + "', '" + zab_total + "', '" + zab_living + "'," +
                        " '" + rog_total + "', '" + rog_living + "', '" + zhur_total + "', '" + zhur_living + "', '" + zag_total + "'," +
                        " '" + zag_living + "', '" + all_total + "', '" + all_living + "')";
                       
                    MySqlCommand add = new MySqlCommand(addYear, _manager.getConnection());
                    add.ExecuteNonQuery();
                }
                else
                {

                    string addYear = "UPDATE `sql8597722`.`areas_of_houses` SET `berezhnytsya_total` = '" + ber_total + "'," +
                        "`berezhnytsya_living`= '"+ber_living+"', `zabolotivtsi_total` = '" + zab_total + "'," +
                        " `zabolotivtsi_living`='"+zab_living+"', `rogizno_total` = '" + rog_total + "', " +
                        "`rogizno_living`= '"+rog_living+"', `zhuravkiv_total` = '" + zhur_total + "', " +
                        "`zhuravkiv_living`= '"+zhur_living+"', `zagurzchyna_total` = '" + zag_total + "', " +
                        "`zagurzchyna_living`= '"+zag_living+"',`all_total` = '" + all_total + "', " +
                        "`all_living` = '"+all_living+"' WHERE(`id` = '" + id + "')";

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
    }
}
