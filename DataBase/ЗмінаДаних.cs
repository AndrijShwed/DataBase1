using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace DataBase
{
    public partial class ЗмінаДаних : Form
    {
        private List<RowOfData> _data = new List<RowOfData>();
        private User user;

        public ЗмінаДаних()
        {
            InitializeComponent();

            textBoxПрізвище.Text = "Прізвище";
            textBoxПрізвище.ForeColor = Color.Gray;

            textBoxІм_я.Text = "Ім'я";
            textBoxІм_я.ForeColor = Color.Gray;

            textBoxПобатькові.Text = "Побатькові";
            textBoxПобатькові.ForeColor = Color.Gray;

            textBoxНаселенийПункт.Text = "Населений пункт";
            textBoxНаселенийПункт.ForeColor = Color.Gray;

            textBoxНомер.Text = "Номер";
            textBoxНомер.ForeColor = Color.Gray;
        }

        private void HeaderOfTheTable()
        {
            this.dataGridViewЗберегтиЗміни.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            this.dataGridViewЗберегтиЗміни.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewЗберегтиЗміни.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            this.dataGridViewЗберегтиЗміни.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewЗберегтиЗміни.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
           
            this.dataGridViewЗберегтиЗміни.EnableHeadersVisualStyles = false;

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер";
            column1.Width = 55;
            column1.Name = "people_id";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Прізвище";
            column2.Width = 120;
            column2.Name = "lastname";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Ім'я";
            column3.Width = 100;
            column3.Name = "name";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Побатькові";
            column4.Width = 120;
            column4.Name = "surname";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Стать";
            column5.Width = 60;
            column5.Name = "sex";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Дата народження";
            column6.Width = 120;
            column6.Name = "date_of_birth";
            column6.Frozen = true;
            column6.DefaultCellStyle.Format = "d";
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Село";
            column7.Width = 100;
            column7.Name = "village";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Вулиця";
            column8.Width = 120;
            column8.Name = "street";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Номер будинку";
            column9.Width = 100;
            column9.Name = "numb_of_house";
            column9.Frozen = true;
            column9.CellTemplate = new DataGridViewTextBoxCell();

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Паспорт";
            column10.Width = 100;
            column10.Name = "passport";
            column10.Frozen = true;
            column10.CellTemplate = new DataGridViewTextBoxCell();

            var column11 = new DataGridViewColumn();
            column11.HeaderText = "Ідент. код";
            column11.Width = 100;
            column11.Name = "id_kod";
            column11.Frozen = true;
            column11.CellTemplate = new DataGridViewTextBoxCell();

            var column12 = new DataGridViewColumn();
            column12.HeaderText = "Номер телефону";
            column12.Width = 120;
            column12.Name = "phone_numb";
            column12.Frozen = true;
            column12.CellTemplate = new DataGridViewTextBoxCell();

            var column13 = new DataGridViewColumn();
            column13.HeaderText = "Статус";
            column13.Width = 100;
            column13.Name = "status";
            column13.Frozen = true;
            column13.CellTemplate = new DataGridViewTextBoxCell();

            var column14 = new DataGridViewColumn();
            column14.HeaderText = "Ел. пошта";
            column14.Width = 120;
            column14.Name = "email";
            column14.Frozen = true;
            column14.CellTemplate = new DataGridViewTextBoxCell();

            dataGridViewЗберегтиЗміни.Columns.Add(column1);
            dataGridViewЗберегтиЗміни.Columns.Add(column2);
            dataGridViewЗберегтиЗміни.Columns.Add(column3);
            dataGridViewЗберегтиЗміни.Columns.Add(column4);
            dataGridViewЗберегтиЗміни.Columns.Add(column5);
            dataGridViewЗберегтиЗміни.Columns.Add(column6);
            dataGridViewЗберегтиЗміни.Columns.Add(column7);
            dataGridViewЗберегтиЗміни.Columns.Add(column8);
            dataGridViewЗберегтиЗміни.Columns.Add(column9);
            dataGridViewЗберегтиЗміни.Columns.Add(column10);
            dataGridViewЗберегтиЗміни.Columns.Add(column11);
            dataGridViewЗберегтиЗміни.Columns.Add(column12);
            dataGridViewЗберегтиЗміни.Columns.Add(column13);
            dataGridViewЗберегтиЗміни.Columns.Add(column14);

            dataGridViewЗберегтиЗміни.AllowUserToAddRows = false;
            dataGridViewЗберегтиЗміни.ReadOnly = true;
        }

        private void ЗмінаДаних_Shown(object sender, EventArgs e)
        {
            HeaderOfTheTable();
            dataGridViewЗберегтиЗміни.Columns[0].ReadOnly = true;
            user = new User();

        }

        private void AddDataGrid(RowOfData row)
        {
            dataGridViewЗберегтиЗміни.Rows.Add(row.people_id, row.lastname, row.name, row.surname, row.sex,
                row.date_of_birth, row.village, row.street, row.numb_of_house, row.passport,
                row.id_kod, row.phone_numb, row.status, row.email);
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            dataGridViewЗберегтиЗміни.DataSource = null;
            dataGridViewЗберегтиЗміни.Rows.Clear();

            _data.Clear();

            bool mess = false;
            string choice;
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" && textBoxНомер.Text == "Номер" &&
                   textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт")
            {
                MessageBox.Show("Жодне поле пошуку не заповнено !");
                return;
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text == "Ім'я" && textBoxНомер.Text == "Номер" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт")
            {
                choice = "По прізвищу";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text != "Ім'я" && textBoxНомер.Text == "Номер" &&
               textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт")
            {
                choice = "По імені";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" && textBoxНомер.Text == "Номер" &&
               textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт")
            {
                choice = "По побатькові";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" && textBoxНомер.Text == "Номер" &&
               textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт")
            {
                choice = "По населеному пункту";
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text != "Ім'я" && textBoxНомер.Text == "Номер" &&
               textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт")
            {
                choice = "По прізвищу і імені";
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text == "Ім'я" && textBoxНомер.Text == "Номер" &&
               textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт")
            {
                choice = "По прізвищу і побатькові";
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text == "Ім'я" && textBoxНомер.Text == "Номер" &&
               textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт")
            {
                choice = "По прізвищу і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text != "Ім'я" && textBoxНомер.Text == "Номер" &&
               textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт")
            {
                choice = "По імені і побатькові";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text != "Ім'я" && textBoxНомер.Text == "Номер" &&
              textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт")
            {
                choice = "По імені і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" && textBoxНомер.Text == "Номер" &&
              textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт")
            {
                choice = "По побатькові і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text != "Ім'я" && textBoxНомер.Text == "Номер" &&
              textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт")
            {
                choice = "По прізвищу імені і побатькові";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text != "Ім'я" && textBoxНомер.Text == "Номер" &&
              textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт")
            {
                choice = "По імені побатькові і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text == "Ім'я" && textBoxНомер.Text == "Номер" &&
              textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт")
            {
                choice = "По прізвищу побатькові і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text != "Ім'я" && textBoxНомер.Text == "Номер" &&
              textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт")
            {
                choice = "По прізвищу імені і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" && textBoxНомер.Text != "Номер" &&
              textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт")
            {
                choice = "По номеру";
            }
            else
                choice = "По всіх параметрах";


            ConnectionClass _manager = new ConnectionClass();
            MySqlDataReader _reader;

            SQLCommand c = new SQLCommand();

            string lastname = Convert.ToString(textBoxПрізвище.Text);
            string name = Convert.ToString(textBoxІм_я.Text);
            string surname = Convert.ToString(textBoxПобатькові.Text);
            string village = Convert.ToString(textBoxНаселенийПункт.Text);
            string people_id = Convert.ToString(textBoxНомер.Text);

            switch (choice)
            {

                case "По прізвищу":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%'";
                    }
                    break;
                case "По прізвищу і імені":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND name LIKE '%" + name + "%'";
                    }
                    break;
                case "По прізвищу і побатькові":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND surname LIKE '%" + surname + "%'";
                    }
                    break;
                case "По прізвищу і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND village LIKE '%" + village + "%'";
                    }
                    break;
                case "По імені":
                    {
                        c.com = "SELECT * FROM people WHERE name LIKE '%" + name + "%'";
                    }
                    break;
                case "По імені і побатькові":
                    {
                        c.com = "SELECT * FROM people WHERE name LIKE '%" + name + "%' AND surname LIKE '%" + surname + "%'";
                    }
                    break;
                case "По імені і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE name LIKE '%" + name + "%' AND village LIKE '%" + village + "%'";
                    }
                    break;
                case "По побатькові і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE suname LIKE '%" + surname + "%' AND village LIKE '%" + village + "%'";
                    }
                    break;
                case "По прізвищу імені і побатькові":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND name LIKE '%" + name + "%' AND surname LIKE '%" + surname + "%'";
                    }
                    break;
                case "По імені побатькові і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE name LIKE '%" + name + "%' AND surname LIKE '%" + surname + "%' AND village LIKE '%" + village + "%'";
                    }
                    break;
                case "По прізвищу побатькові і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND surname LIKE '%" + surname + "%' AND village LIKE '%" + village + "%'";
                    }
                    break;
                case "По прізвищу імені і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND name LIKE '%" + name + "%' AND village LIKE '%" + village + "%'";
                    }
                    break;
                case "По побатькові":
                    {
                        c.com = "SELECT * FROM people WHERE surname LIKE '%" + surname + "%'";
                    }
                    break;
                case "По населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE village LIKE '%" + village + "%'";
                    }
                    break;
                case "По номеру":
                    {
                        c.com = "SELECT * FROM people WHERE people_id = '" + people_id +"'";
                    }
                    break;
                default:
                    break;
            }
            try
            {
                _manager.openConnection();

                MySqlCommand _command = new MySqlCommand(c.com, _manager.getConnection());
                _reader = _command.ExecuteReader();


                while (_reader.Read())
                {
                    RowOfData row = new RowOfData(_reader["people_id"], _reader["lastname"], _reader["name"],
                        _reader["surname"], _reader["sex"], _reader["date_of_birth"], _reader["village"],
                        _reader["street"], _reader["numb_of_house"], _reader["passport"], _reader["id_kod"],
                        _reader["phone_numb"], _reader["status"], _reader["email"]);
                    _data.Add(row);
                }

                dataGridViewЗберегтиЗміни.ReadOnly = false;

                for (int i = 0; i < _data.Count; i++)
                {
                    if (_data[i].date_of_birth.ToString() == "")
                    {
                        _data[i].date_of_birth = "дд.мм.рррр";
                    }
                    AddDataGrid(_data[i]);
                    mess = true;
                }

                if (mess == false)
                {
                    MessageBox.Show("Запис не знайдено !");
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
        }

        

        private void textBoxПрізвище_Enter(object sender, EventArgs e)
        {
            if (textBoxПрізвище.Text == "Прізвище")
            {
                textBoxПрізвище.Text = "";
                textBoxПрізвище.ForeColor = Color.Black;
            }
        }

        private void textBoxПрізвище_Leave(object sender, EventArgs e)
        {
            if (textBoxПрізвище.Text == "")
            {
                textBoxПрізвище.Text = "Прізвище";
                textBoxПрізвище.ForeColor = Color.Gray;
            }
        }

        private void textBoxІм_я_Enter(object sender, EventArgs e)
        {
            if (textBoxІм_я.Text == "Ім'я")
            {
                textBoxІм_я.Text = "";
                textBoxІм_я.ForeColor = Color.Black;
            }
        }

        private void textBoxІм_я_Leave(object sender, EventArgs e)
        {
            if (textBoxІм_я.Text == "")
            {
                textBoxІм_я.Text = "Ім'я";
                textBoxІм_я.ForeColor = Color.Gray;
            }
        }

        private void textBoxПобатькові_Enter(object sender, EventArgs e)
        {
            if (textBoxПобатькові.Text == "Побатькові")
            {
                textBoxПобатькові.Text = "";
                textBoxПобатькові.ForeColor = Color.Black;
            }
        }

        private void textBoxПобатькові_Leave(object sender, EventArgs e)
        {
            if (textBoxПобатькові.Text == "")
            {
                textBoxПобатькові.Text = "Побатькові";
                textBoxПобатькові.ForeColor = Color.Gray;
            }
        }

        private void textBoxНаселенийПункт_Enter(object sender, EventArgs e)
        {
            if (textBoxНаселенийПункт.Text == "Населений пункт")
            {
                textBoxНаселенийПункт.Text = "";
                textBoxНаселенийПункт.ForeColor = Color.Black;
            }
        }

        private void textBoxНаселенийПункт_Leave(object sender, EventArgs e)
        {
            if (textBoxНаселенийПункт.Text == "")
            {
                textBoxНаселенийПункт.Text = "Населений пункт";
                textBoxНаселенийПункт.ForeColor = Color.Gray;
            }
        }

        private void buttonЗберегтиЗміни_Click_1(object sender, EventArgs e)
        {
            if (user.userName == "A")
            {

                if (dataGridViewЗберегтиЗміни.SelectedRows.Count == 0)
                {

                    int a = dataGridViewЗберегтиЗміни.RowCount;
                    bool changed = false;

                    for (int i = 0; i < a; i++)
                    {

                        if (Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[0].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[0].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[0].Cells[3].Value) != "" &&
                            Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[0].Cells[4].Value) != "")

                        {

                            string people_id = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[0].Value);
                            string lastname = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[1].Value);
                            string name = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[2].Value);
                            string surname = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[3].Value);
                            string sex = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[4].Value);
                            string date_of_birth = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[5].Value);
                            string village = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[6].Value);
                            string street = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[7].Value);
                            string numb_of_house = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[8].Value);
                            string passport = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[9].Value);
                            string id_kod = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[10].Value);
                            string phone_numb = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[11].Value);
                            string status = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[12].Value);
                            string email = Convert.ToString(this.dataGridViewЗберегтиЗміни.Rows[i].Cells[13].Value);


                            if (date_of_birth != "дд.мм.рррр")
                            {

                                try
                                {
                                    string s1 = date_of_birth.Substring(0, 2);
                                    string s2 = date_of_birth.Substring(3, 2);
                                    string s3 = date_of_birth.Substring(6, 4);
                                    date_of_birth = s3 + '/' + s2 + '/' + s1;
                                    DateTime date_of_birth1 = Convert.ToDateTime(date_of_birth);

                                }
                                catch
                                {
                                    MessageBox.Show("Помилка введення дати ! Дату потрібно вводити у форматі - дд.мм.рррр ");
                                    break;
                                }


                                if (Convert.ToDateTime(date_of_birth) > DateTime.Now)
                                {
                                    MessageBox.Show("Дата народження не може бути новішою за поточну дату !" +
                                        " У рядку з номером: " + people_id);

                                }
                                else
                                {
                                    ConnectionClass _manager = new ConnectionClass();

                                    string _commandString = "UPDATE people SET lastname = '" + lastname + "', " +
                                        "name = '" + name + "', " +
                                        "surname = '" + surname + "', " +
                                        "sex = '" + sex + "', " +
                                        "date_of_birth = '" + date_of_birth + "', " +
                                        "village = '" + village + "', " +
                                        "street = '" + street + "', " +
                                        "numb_of_house = '" + numb_of_house + "', " +
                                        "passport = '" + passport + "', " +
                                        "id_kod = '" + id_kod + "', " +
                                        "phone_numb = '" + phone_numb + "', " +
                                        "status = '" + status + "', " +
                                        "email = '" + email + "' " +
                                        "WHERE people_id = " + people_id;
                                    MySqlCommand _command = new MySqlCommand(_commandString, _manager.getConnection());

                                    try
                                    {
                                        _manager.openConnection();
                                        _command.ExecuteNonQuery();
                                        changed = true;

                                    }
                                    catch
                                    {
                                        MessageBox.Show("Помилка роботи з базою даних !");
                                        break;
                                    }
                                    finally
                                    {
                                        _manager.closeConnection();

                                    }
                                }
                            }
                            else
                            {

                                ConnectionClass _manager = new ConnectionClass();

                                string _commandString = "UPDATE people SET lastname = '" + lastname + "', " +
                                    "name = '" + name + "', " +
                                    "surname = '" + surname + "', " +
                                    "sex = '" + sex + "', " +
                                    "village = '" + village + "', " +
                                    "street = '" + street + "', " +
                                    "numb_of_house = '" + numb_of_house + "', " +
                                    "passport = '" + passport + "', " +
                                    "id_kod = '" + id_kod + "', " +
                                    "phone_numb = '" + phone_numb + "', " +
                                    "status = '" + status + "', " +
                                    "email = '" + email + "' " +
                                    "WHERE people_id = " + people_id;
                                MySqlCommand _command = new MySqlCommand(_commandString, _manager.getConnection());

                                try
                                {
                                    _manager.openConnection();
                                    _command.ExecuteNonQuery();
                                    changed = true;
                                }
                                catch
                                {
                                    MessageBox.Show("Помилка роботи з базою даних1 !");
                                    break;
                                }
                                finally
                                {
                                    _manager.closeConnection();

                                }
                            }

                        }
                        else
                            MessageBox.Show("Не всі поля заповнені ! Заповніть прізвище, ім'я, побатькові і стать");

                    }
                    if (changed)
                    {
                        MessageBox.Show("Дані змінено !");
                        dataGridViewЗберегтиЗміни.ReadOnly = true;
                    }
                }
                else
                {
                    ConnectionClass _manager = new ConnectionClass();

                    bool changed = true;


                    for (int i = 0; i < dataGridViewЗберегтиЗміни.SelectedRows.Count; i++)
                    {



                        if (Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[3].Value) != "" &&
                            Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[4].Value) != "")

                        {
                            string people_id = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[0].Value);
                            string lastname = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[1].Value);
                            string name = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[2].Value);
                            string surname = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[3].Value);
                            string sex = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[4].Value);
                            string date_of_birth = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[5].Value);
                            string village = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[6].Value);
                            string street = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[7].Value);
                            string numb_of_house = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[8].Value);
                            string passport = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[9].Value);
                            string id_kod = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[10].Value);
                            string phone_numb = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[11].Value);
                            string status = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[12].Value);
                            string email = Convert.ToString(this.dataGridViewЗберегтиЗміни.SelectedRows[i].Cells[13].Value);

                            if (date_of_birth != "дд.мм.рррр")
                            {

                                try
                                {
                                    string s1 = date_of_birth.Substring(0, 2);
                                    string s2 = date_of_birth.Substring(3, 2);
                                    string s3 = date_of_birth.Substring(6, 4);
                                    date_of_birth = s3 + '/' + s2 + '/' + s1;
                                    DateTime date_of_birth1 = Convert.ToDateTime(date_of_birth);

                                }
                                catch
                                {
                                    MessageBox.Show("Помилка введення дати ! Дату потрібно вводити у форматі - дд.мм.рррр ");
                                    break;
                                }

                                if (Convert.ToDateTime(date_of_birth) > DateTime.Now)
                                {
                                    MessageBox.Show("Дата народження не може бути новішою за поточну дату !" +
                                        " У рядку з номером: " + people_id);

                                }
                                else
                                {

                                    string _commandString = "UPDATE people SET lastname = '" + lastname + "', " +
                                   "name = '" + name + "', " +
                                   "surname = '" + surname + "', " +
                                   "sex = '" + sex + "', " +
                                   "date_of_birth = '" + date_of_birth + "', " +
                                   "village = '" + village + "', " +
                                   "street = '" + street + "', " +
                                   "numb_of_house = '" + numb_of_house + "', " +
                                   "passport = '" + passport + "', " +
                                   "id_kod = '" + id_kod + "', " +
                                   "phone_numb = '" + phone_numb + "', " +
                                   "status = '" + status + "', " +
                                   "email = '" + email + "' " +
                                   "WHERE people_id = " + people_id;

                                    MySqlCommand _command = new MySqlCommand(_commandString, _manager.getConnection());

                                    try
                                    {
                                        _manager.openConnection();
                                        _command.ExecuteNonQuery();

                                        dataGridViewЗберегтиЗміни.ReadOnly = true;

                                        if (_command.ExecuteNonQuery() != 1)
                                            changed = false;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Помилка роботи з базою даних !");
                                    }
                                }
                            }
                            else
                            {

                                string _commandString = "UPDATE people SET lastname = '" + lastname + "', " +
                                    "name = '" + name + "', " +
                                    "surname = '" + surname + "', " +
                                    "sex = '" + sex + "', " +
                                    "village = '" + village + "', " +
                                    "street = '" + street + "', " +
                                    "numb_of_house = '" + numb_of_house + "', " +
                                    "passport = '" + passport + "', " +
                                    "id_kod = '" + id_kod + "', " +
                                    "phone_numb = '" + phone_numb + "', " +
                                    "status = '" + status + "', " +
                                    "email = '" + email + "' " +
                                    "WHERE people_id = " + people_id;
                                MySqlCommand _command = new MySqlCommand(_commandString, _manager.getConnection());

                                try
                                {
                                    _manager.openConnection();
                                    _command.ExecuteNonQuery();
                                    changed = true;
                                }
                                catch
                                {
                                    MessageBox.Show("Помилка роботи з базою даних1 !");
                                    break;
                                }
                                finally
                                {
                                    _manager.closeConnection();

                                }
                            }
                        }
                        else
                            MessageBox.Show("Не всі поля заповнені !");
                    }
                    if (changed)
                        MessageBox.Show("Дані змінено !");
                    else
                        MessageBox.Show("Не всі дані змінено !");

                    dataGridViewЗберегтиЗміни.ReadOnly = true;
                    _manager.closeConnection();
                }
            }

            else
                MessageBox.Show("У вас немає доступу до зміни даних в таблиці !");

        }
       
        private void НаселенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void textBoxНомер_Enter(object sender, EventArgs e)
        {
            if (textBoxНомер.Text == "Номер")
            {
                textBoxНомер.Text = "";
                textBoxНомер.ForeColor = Color.Black;
            }
        }

        private void textBoxНомер_Leave(object sender, EventArgs e)
        {
            if (textBoxНомер.Text == "")
            {
                textBoxНомер.Text = "Номер";
                textBoxНомер.ForeColor = Color.Gray;
            }
        }

        private void ГоловнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void вихідЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void вихідУВікноВходуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Авторизація form = new Авторизація();
            this.Hide();
            form.Show();
        }

        private void вихідУВікноРеєстраціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Реєстрація form = new Реєстрація();
            this.Hide();
            form.Show();
        }

        private void вибраніToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (dataGridViewЗберегтиЗміни.SelectedRows.Count != 0)
            {

                ConnectionClass _manager = new ConnectionClass();
                bool add = false;

                foreach (DataGridViewRow row in dataGridViewЗберегтиЗміни.SelectedRows)
                {
                    int index = row.Index;

                    int people_id = Convert.ToInt32(dataGridViewЗберегтиЗміни.Rows[index].Cells[0].Value);
                    string _commandstring = "DELETE FROM people WHERE people_id = " + people_id;
                    MySqlCommand _command = new MySqlCommand(_commandstring, _manager.getConnection());

                    try
                    {
                        _manager.openConnection();
                        _command.ExecuteNonQuery();
                        dataGridViewЗберегтиЗміни.Rows.RemoveAt(index);
                        add = true;
                    }
                    catch
                    {
                        MessageBox.Show("Помилка роботи з базою даних !");
                    }
                    finally
                    {
                        _manager.closeConnection();
                    }
                }
                if (add)
                {
                    MessageBox.Show("Дані видалено !");
                }
            }
            else
            {
                MessageBox.Show("Елемент для видалення не вибрано !");
            }

        }

        private void переглядДанихToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ВивідДаних form = new ВивідДаних();
            this.Hide();
            form.Show();
        }

        private void ButtonПовернутись_Click(object sender, EventArgs e)
        {
            Населення form = new Населення();
            this.Hide();
            form.Show();
        }

        private void НаселенняToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Населення form = new Населення();
            this.Hide();
            form.Show();
        }

        private void НаГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }
    }
}
