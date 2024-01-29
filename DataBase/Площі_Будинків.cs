using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        List<VillageStreet> data = new List<VillageStreet>();

        public Площі_Будинків()
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

            this.dataGridViewArea.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            this.dataGridViewArea.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewArea.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            this.dataGridViewArea.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewArea.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            this.dataGridViewArea.EnableHeadersVisualStyles = false;

            //var column1 = new DataGridViewColumn();
            //column1.HeaderText = "Номер";
            //column1.Width = 70;
            //column1.Name = "id";
            //column1.Frozen = true;
            //column1.CellTemplate = new DataGridViewTextBoxCell();

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Рік";
            column1.Width = 70;
            column1.Name = "year";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            List<DataGridViewColumn> col = new List<DataGridViewColumn>();
            int k = 3;
            for (int i = 0; i < data.Count; i++)
            {
               
                var columnk = new DataGridViewColumn();
                columnk.HeaderText = data[i].village.ToString()+" заг.пл.";
                columnk.Width = 118;
                columnk.Frozen = true;
                columnk.CellTemplate = new DataGridViewTextBoxCell();
                col.Add(columnk);
                k++;
                columnk = new DataGridViewColumn();
                columnk.HeaderText = data[i].village.ToString() + " житл.пл.";
                columnk.Width = 118;
                columnk.Frozen = true;
                columnk.CellTemplate = new DataGridViewTextBoxCell();
                col.Add(columnk);
                k++;
            }
            
            var column13 = new DataGridViewColumn();
            column13.HeaderText = "Всього заг. пл.";
            column13.Width = 110;
            column13.Name = "all";
            column13.Frozen = true;
            column13.CellTemplate = new DataGridViewTextBoxCell();

            var column14= new DataGridViewColumn();
            column14.HeaderText = "Всього житл. пл.";
            column14.Width = 110;
            column14.Name = "all";
            column14.Frozen = true;
            column14.CellTemplate = new DataGridViewTextBoxCell();


            dataGridViewArea.Columns.Add(column1);
           
            for (int i = 0; i < col.Count; i++)
            {
                dataGridViewArea.Columns.Add(col[i]);
            }

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
            dataGridViewArea.Rows.Add(row.id, row.village, row.total, row.living);
        }

        private void Оновити_Click(object sender, EventArgs e)
        {
            dataGridViewArea.DataSource = null;
            dataGridViewArea.Rows.Clear();
            _data.Clear();

            user = new User();

            int yearNow = Convert.ToInt32(DateTime.Now.Year);


            ConnectionClass _manager = new ConnectionClass();
            _manager.openConnection();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM areas", _manager.getConnection());
            MySqlDataReader _reader;
           
            _reader = _command.ExecuteReader();

            try
            {
                while (_reader.Read())
                {
                    RowOfVillageArea row = new RowOfVillageArea(_reader["id"], _reader["village"], _reader["total"],
                        _reader["living"]);
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
            List<String> count = new List<String>();

            for (int i = 0; i < data.Count; i++)
            {
                string count_total = "SELECT SUM(totalArea) FROM houses WHERE village = '"+data[i].village.ToString()+"'";
                count.Add(count_total);
                string count_living = "SELECT SUM(livingArea) FROM houses WHERE village = '"+data[i].village.ToString()+"'";
                count.Add(count_living);
            }

            decimal total = 0;
            decimal living = 0;
            List<Decimal> tot = new List<Decimal>();
            List<Decimal> liv = new List<Decimal>();
            for (int i = 0; i < count.Count; i+=2)
            {
                MySqlCommand search_total = new MySqlCommand(count[i], _manager.getConnection());
                MySqlCommand search_living = new MySqlCommand(count[i + 1], _manager.getConnection());
                try
                {
                    total = Convert.ToDecimal(search_total.ExecuteScalar());
                    living = Convert.ToDecimal(search_living.ExecuteScalar());
                    tot.Add(total);
                    liv.Add(living);
                }
                catch
                {
                    MessageBox.Show("Помилка роботи з базою даних1 !");
                }
            }

            decimal all_total = 0;
            decimal all_living = 0;

            for (int i = 0; i < tot.Count ; i++)
            {
                all_total += tot[i];
                all_living += liv[i];
            }

          
            List<String> t = new List<String>();
            List<String> l = new List<String>();
            for (int i = 0; i < tot.Count; i++)
            {
                string to = (Convert.ToString(tot[i])).Replace(',', '.');
                t.Add(to);
                string li = (Convert.ToString(liv[i])).Replace(',', '.');
                l.Add(li);  
            }
           
            string a_t = (Convert.ToString(all_total)).Replace(',', '.');
            string a_l = (Convert.ToString(all_living)).Replace(',', '.');

            int r = 0;

            dataGridViewArea.Rows[r].Cells[0].Value = Convert.ToInt32(DateTime.Now.Year.ToString());
            int k = 0;
            for (int i = 0; i< t.Count; i++)
            {
                dataGridViewArea.Rows[r].Cells[k+1].Value = t[i].ToString();
                dataGridViewArea.Rows[r].Cells[k+2].Value = l[i].ToString();
                k += 2;
            }
           
            dataGridViewArea.Rows[r].Cells[k+1].Value = all_total;
            dataGridViewArea.Rows[r].Cells[k+2].Value = all_living;
           

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Домогосподарства form = new Домогосподарства();
            this.Hide();
            form.Show();
        }
    }
}
