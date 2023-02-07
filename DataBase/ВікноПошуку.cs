using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;


namespace DataBase
{
    public partial class ВікноПошуку : Form
    {
        private List<RowOfData> _data = new List<RowOfData>();
        private User user;

        public ВікноПошуку()
        {
            InitializeComponent();
            HeaderOfTheTable();


            textBoxПрізвище.Text = "Прізвище";
            textBoxПрізвище.ForeColor = Color.Gray;

            textBoxІм_я.Text = "Ім'я";
            textBoxІм_я.ForeColor = Color.Gray;

            textBoxПобатькові.Text = "Побатькові";
            textBoxПобатькові.ForeColor = Color.Gray;

            textBoxСтать.Text = "Стать";
            textBoxСтать.ForeColor = Color.Gray;

            textBoxНаселенийПункт.Text = "Населений пункт";
            textBoxНаселенийПункт.ForeColor = Color.Gray;

            textBoxДатаНародженняВІД.Text = "Дата народження від:";
            textBoxДатаНародженняВІД.ForeColor = Color.Gray;

            textBoxДатаНародженняДО.Text = "Дата народження до:";
            textBoxДатаНародженняДО.ForeColor = Color.Gray;

            textBoxВулиця.Text = "Вулиця";
            textBoxВулиця.ForeColor = Color.Gray;

            textBoxНомерБудинку.Text = "Номер будинку";
            textBoxНомерБудинку.ForeColor = Color.Gray;

            textBoxFileName.Text = "Назва файлу";
            textBoxFileName.ForeColor = Color.Gray;

            textBoxСтатус.Text = "Статус";
            textBoxСтатус.ForeColor = Color.Gray;

            textBoxCount.Text = "0";

        }

        private void HeaderOfTheTable()
        {
            this.dataGridViewВікноПошуку.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            this.dataGridViewВікноПошуку.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewВікноПошуку.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            this.dataGridViewВікноПошуку.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewВікноПошуку.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            this.dataGridViewВікноПошуку.EnableHeadersVisualStyles = false;


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

            dataGridViewВікноПошуку.Columns.Add(column1);
            dataGridViewВікноПошуку.Columns.Add(column2);
            dataGridViewВікноПошуку.Columns.Add(column3);
            dataGridViewВікноПошуку.Columns.Add(column4);
            dataGridViewВікноПошуку.Columns.Add(column5);
            dataGridViewВікноПошуку.Columns.Add(column6);
            dataGridViewВікноПошуку.Columns.Add(column7);
            dataGridViewВікноПошуку.Columns.Add(column8);
            dataGridViewВікноПошуку.Columns.Add(column9);
            dataGridViewВікноПошуку.Columns.Add(column10);
            dataGridViewВікноПошуку.Columns.Add(column11);
            dataGridViewВікноПошуку.Columns.Add(column12);
            dataGridViewВікноПошуку.Columns.Add(column13);
            dataGridViewВікноПошуку.Columns.Add(column14);
           

            dataGridViewВікноПошуку.AllowUserToAddRows = false;
            dataGridViewВікноПошуку.ReadOnly = true;
        }

        private void ВікноПошуку_Shown(object sender, EventArgs e)
        {
            HeaderOfTheTable();
            user = new User();
        }

        private void вихідУВікноЗміниДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = new User();

            if (user.userName == "A")
            {
                ЗмінаДаних form = new ЗмінаДаних();
                this.Hide();
                form.Show();

            }
            else
                MessageBox.Show("У вас немає доступу до зміни даних в таблиці !");
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

        private void textBoxСтать_Enter(object sender, EventArgs e)
        {
            if (textBoxСтать.Text == "Стать")
            {
                textBoxСтать.Text = "";
                textBoxСтать.ForeColor = Color.Black;
            }
        }

        private void textBoxСтать_Leave(object sender, EventArgs e)
        {
            if (textBoxСтать.Text == "")
            {
                textBoxСтать.Text = "Стать";
                textBoxСтать.ForeColor = Color.Gray;
            }
        }

        private void textBoxДатаНародженняВІД_Enter(object sender, EventArgs e)
        {

            if (textBoxДатаНародженняВІД.Text == "Дата народження від:")
            {
                textBoxДатаНародженняВІД.Text = "";
                textBoxДатаНародженняВІД.ForeColor = Color.Black;
            }
        }

        private void textBoxДатаНародженняВІД_Leave(object sender, EventArgs e)
        {
            if (textBoxДатаНародженняВІД.Text == "")
            {
                textBoxДатаНародженняВІД.Text = "Дата народження від:";
                textBoxДатаНародженняВІД.ForeColor = Color.Gray;
            }
        }

        private void textBoxДатаНародженняДО_Enter(object sender, EventArgs e)
        {

            if (textBoxДатаНародженняДО.Text == "Дата народження до:")
            {
                textBoxДатаНародженняДО.Text = "";
                textBoxДатаНародженняДО.ForeColor = Color.Black;
            }
        }

        private void textBoxДатаНародженняДО_Leave(object sender, EventArgs e)
        {
            if (textBoxДатаНародженняДО.Text == "")
            {
                textBoxДатаНародженняДО.Text = "Дата народження до:";
                textBoxДатаНародженняДО.ForeColor = Color.Gray;
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

        private void textBoxВулиця_Enter(object sender, EventArgs e)
        {

            if (textBoxВулиця.Text == "Вулиця")
            {
                textBoxВулиця.Text = "";
                textBoxВулиця.ForeColor = Color.Black;
            }
        }

        private void textBoxВулиця_Leave(object sender, EventArgs e)
        {
            if (textBoxВулиця.Text == "")
            {
                textBoxВулиця.Text = "Вулиця";
                textBoxВулиця.ForeColor = Color.Gray;
            }
        }

        private void textBoxНомерБудинку_Enter(object sender, EventArgs e)
        {
            if (textBoxНомерБудинку.Text == "Номер будинку")
            {
                textBoxНомерБудинку.Text = "";
                textBoxНомерБудинку.ForeColor = Color.Black;
            }
        }

        private void textBoxНомерБудинку_Leave(object sender, EventArgs e)
        {
            if (textBoxНомерБудинку.Text == "")
            {
                textBoxНомерБудинку.Text = "Номер будинку";
                textBoxНомерБудинку.ForeColor = Color.Gray;
            }
        }

        private void buttonОчиститиПоля_Click(object sender, EventArgs e)
        {
            textBoxПрізвище.Text = "Прізвище";
            textBoxПрізвище.ForeColor = Color.Gray;

            textBoxІм_я.Text = "Ім'я";
            textBoxІм_я.ForeColor = Color.Gray;

            textBoxПобатькові.Text = "Побатькові";
            textBoxПобатькові.ForeColor = Color.Gray;

            textBoxСтать.Text = "Стать";
            textBoxСтать.ForeColor = Color.Gray;

            textBoxНаселенийПункт.Text = "Населений пункт";
            textBoxНаселенийПункт.ForeColor = Color.Gray;

            textBoxДатаНародженняВІД.Text = "Дата народження від:";
            textBoxДатаНародженняВІД.ForeColor = Color.Gray;

            textBoxДатаНародженняДО.Text = "Дата народження до:";
            textBoxДатаНародженняДО.ForeColor = Color.Gray;

            textBoxВулиця.Text = "Вулиця";
            textBoxВулиця.ForeColor = Color.Gray;

            textBoxСтатус.Text = "Статус";
            textBoxСтатус.ForeColor = Color.Gray;

            textBoxНомерБудинку.Text = "Номер будинку";
            textBoxНомерБудинку.ForeColor = Color.Gray;

            textBoxFileName.Text = "Назва файлу";
            textBoxFileName.ForeColor = Color.Gray;
        }

        private void AddDataGrid(RowOfData row)
        {
            dataGridViewВікноПошуку.Rows.Add(row.people_id, row.lastname, row.name, row.surname, row.sex,
                row.date_of_birth, row.village, row.street, row.numb_of_house, row.passport,
                row.id_kod, row.phone_numb, row.status, row.email);
        }

        private void button1Пошук_Click(object sender, EventArgs e)
        {
            dataGridViewВікноПошуку.DataSource = null;
            dataGridViewВікноПошуку.Rows.Clear();

            _data.Clear();

            bool mess = false;
            string choice;
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                   textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                   textBoxВулиця.Text == "Вулиця" && textBoxСтать.Text == "Стать" &&
                   textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                   textBoxДатаНародженняДО.Text == "Дата народження до:" &&
                   textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" )
            {
                MessageBox.Show("Жодне поле пошуку не заповнено !");
                return;
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text == "Стать"  && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" && 
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:" 
                )
            {
                choice = "По прізвищу";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text != "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По імені";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По побатькові";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По населеному пункту";
            }
            else
             if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text != "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По статусу";
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text != "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По прізвищу і імені";
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По прізвищу і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text != "Ім'я" &&
                textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По імені і побатькові";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text != "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По імені і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text != "Ім'я" &&
                textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По прізвищу імені і побатькові";
            }
           else
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text != "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По прізвищу імені і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text != "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По статі";
            }
            else
             if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text != "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По статі і населеному пункту";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                (textBoxДатаНародженняВІД.Text != "Дата народження від:" ||
                textBoxДатаНародженняДО.Text != "Дата народження до:")
                )
            {
                choice = "По даті народження від і до:";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text != "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
               ( textBoxДатаНародженняВІД.Text != "Дата народження від:" ||
                textBoxДатаНародженняДО.Text != "Дата народження до:")
                )
            {
                choice = "По статі і даті народження від і до:";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                (textBoxДатаНародженняВІД.Text != "Дата народження від:" ||
                textBoxДатаНародженняДО.Text != "Дата народження до:")
                )
            {
                choice = "По населеному пункту і даті народження від і до:";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text != "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                (textBoxДатаНародженняВІД.Text != "Дата народження від:" ||
                textBoxДатаНародженняДО.Text != "Дата народження до:")
                )
            {
                choice = "По статі, населеному пункту і даті народження від і до:";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text != "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По населеному пункту і вулиці";
            }
            else
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text != "Вулиця" &&
                textBoxНомерБудинку.Text != "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                (textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:")
                )
            {
                choice = "По населеному пункту, вулиці і номеру будинку";
            }
            else
                choice = "По всіх параметрах";

            ConnectionClass _manager = new ConnectionClass();
            MySqlDataReader _reader;

            SQLCommand c = new SQLCommand();
           
            string lastname = Convert.ToString(textBoxПрізвище.Text);
            string name = Convert.ToString(textBoxІм_я.Text);
            string surname = Convert.ToString(textBoxПобатькові.Text);
            string sex = Convert.ToString(textBoxСтать.Text);
            string village = Convert.ToString(textBoxНаселенийПункт.Text);
            string street = Convert.ToString(textBoxВулиця.Text);
            string numb_of_house = Convert.ToString(textBoxНомерБудинку.Text);
            string status = Convert.ToString(textBoxСтатус.Text);
           

            switch (choice)
            {
              
                case "По прізвищу":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%'";
                    }
                    break;
                case "По імені":
                    {
                        c.com = "SELECT * FROM people WHERE name LIKE '%" + name + "%'";
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
                case "По статі":
                    {
                        c.com = "SELECT * FROM people WHERE sex LIKE '%" + sex + "%'";
                    }
                    break;
                case "По статусу":
                    {
                        c.com = "SELECT * FROM people WHERE status LIKE '%" + status + "%'";
                    }
                    break;
                case "По даті народження від і до:":
                    {
                        string date_start = Convert.ToString(textBoxДатаНародженняВІД.Text);
                        string date_end = Convert.ToString(textBoxДатаНародженняДО.Text);
                        if (textBoxДатаНародженняВІД.Text == "Дата народження від:")
                        {
                            date_start = "01/01/1900";
                        }
                        if (textBoxДатаНародженняДО.Text == "Дата народження до:")
                        {
                            date_end = DateTime.Now.ToShortDateString();
                        }
                       

                        try
                        {
                            string s1 = date_start.Substring(0, 2);
                            string s2 = date_start.Substring(3, 2);
                            string s3 = date_start.Substring(6, 4);
                            date_start = s3 + "-" + s2 + "-" + s1;
                            DateTime date_of_birth1 = Convert.ToDateTime(date_start);
                            string s4 = date_end.Substring(0, 2);
                            string s5 = date_end.Substring(3, 2);
                            string s6 = date_end.Substring(6, 4);
                            date_end = s6 + "-" + s5 + "-" + s4;
                            DateTime date_of_birth2 = Convert.ToDateTime(date_end);

                        }
                        catch
                        {
                            MessageBox.Show("Помилка введення дати ! Дату потрібно вводити у форматі - дд.мм.рррр ");
                            break;
                        }

                        c.com = "SELECT * FROM people WHERE date_of_birth between '" + date_start + "' AND '" + date_end + "'";
                    }
                    break;
                case "По прізвищу і імені":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND name LIKE '%" + name + "%'";
                    }
                    break;
                case "По прізвищу і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND village LIKE '%" + village + "%'";
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
                case "По прізвищу імені і побатькові":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND name LIKE '%" + name + "%' AND surname LIKE '%" + surname + "%'";
                    }
                    break;
                case "По прізвищу імені і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE lastname LIKE '%" + lastname + "%' AND name LIKE '%" + name + "%' AND village LIKE '%" + village + "%'";
                    }
                    break;
                case "По статі і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE sex LIKE '%" + sex + "%' AND village LIKE '%" + village + "%'";
                    }
                    break;
                case "По статі і даті народження від і до:":
                    {
                        string date_start = Convert.ToString(textBoxДатаНародженняВІД.Text);
                        string date_end = Convert.ToString(textBoxДатаНародженняДО.Text);
                        if (textBoxДатаНародженняВІД.Text == "Дата народження від:")
                        {
                            date_start = "01/01/1900";
                        }
                        if (textBoxДатаНародженняДО.Text == "Дата народження до:")
                        {
                            date_end = DateTime.Now.ToShortDateString();
                        }
                        try
                        {
                            string s1 = date_start.Substring(0, 2);
                            string s2 = date_start.Substring(3, 2);
                            string s3 = date_start.Substring(6, 4);
                            date_start = s3 + "-" + s2 + "-" + s1;
                            DateTime date_of_birth1 = Convert.ToDateTime(date_start);
                            string s4 = date_end.Substring(0, 2);
                            string s5 = date_end.Substring(3, 2);
                            string s6 = date_end.Substring(6, 4);
                            date_end = s6 + "-" + s5 + "-" + s4;
                            DateTime date_of_birth2 = Convert.ToDateTime(date_end);

                        }
                        catch
                        {
                            MessageBox.Show("Помилка введення дати ! Дату потрібно вводити у форматі - дд.мм.рррр ");
                            break;
                        }
                        c.com = "SELECT * FROM people WHERE sex LIKE '%" + sex + "%' AND date_of_birth between '" + date_start + "' AND '" + date_end + "'";
                    }
                    break;
                case "По населеному пункту і даті народження від і до:":
                    {
                        string date_start = Convert.ToString(textBoxДатаНародженняВІД.Text);
                        string date_end = Convert.ToString(textBoxДатаНародженняДО.Text);
                        if (textBoxДатаНародженняВІД.Text == "Дата народження від:")
                        {
                            date_start = "01/01/1900";
                        }
                        if (textBoxДатаНародженняДО.Text == "Дата народження до:")
                        {
                            date_end = DateTime.Now.ToShortDateString();
                        }
                        try
                        {
                            string s1 = date_start.Substring(0, 2);
                            string s2 = date_start.Substring(3, 2);
                            string s3 = date_start.Substring(6, 4);
                            date_start = s3 + "-" + s2 + "-" + s1;
                            DateTime date_of_birth1 = Convert.ToDateTime(date_start);
                            string s4 = date_end.Substring(0, 2);
                            string s5 = date_end.Substring(3, 2);
                            string s6 = date_end.Substring(6, 4);
                            date_end = s6 + "-" + s5 + "-" + s4;
                            DateTime date_of_birth2 = Convert.ToDateTime(date_end);

                        }
                        catch
                        {
                            MessageBox.Show("Помилка введення дати ! Дату потрібно вводити у форматі - дд.мм.рррр ");
                            break;
                        }
                        c.com = "SELECT * FROM people WHERE village LIKE '%" + village + "%' AND date_of_birth between '" + date_start + "' AND '" + date_end + "'";
                    }
                    break;
                case "По статі, населеному пункту і даті народження від і до:":
                    {
                        string date_start = Convert.ToString(textBoxДатаНародженняВІД.Text);
                        string date_end = Convert.ToString(textBoxДатаНародженняДО.Text);
                        if (textBoxДатаНародженняВІД.Text == "Дата народження від:")
                        {
                            date_start = "01/01/1900";
                        }
                        if (textBoxДатаНародженняДО.Text == "Дата народження до:")
                        {
                            date_end = DateTime.Now.ToShortDateString();
                        }
                        try
                        {
                            string s1 = date_start.Substring(0, 2);
                            string s2 = date_start.Substring(3, 2);
                            string s3 = date_start.Substring(6, 4);
                            date_start = s3 + "-" + s2 + "-" + s1;
                            DateTime date_of_birth1 = Convert.ToDateTime(date_start);
                            string s4 = date_end.Substring(0, 2);
                            string s5 = date_end.Substring(3, 2);
                            string s6 = date_end.Substring(6, 4);
                            date_end = s6 + "-" + s5 + "-" + s4;
                            DateTime date_of_birth2 = Convert.ToDateTime(date_end);

                        }
                        catch
                        {
                            MessageBox.Show("Помилка введення дати ! Дату потрібно вводити у форматі - дд.мм.рррр ");
                            break;
                        }
                        c.com = "SELECT * FROM people WHERE sex LIKE '%" + sex + "%' AND village LIKE '%" + village + "%' AND date_of_birth between '" + date_start + "' AND '" + date_end + "'";
                    }
                    break;
                case "По населеному пункту і вулиці":
                    {
                        c.com = "SELECT * FROM people WHERE village LIKE '%" + village + "%' AND street LIKE '%" + street + "%'";
                    }
                    break;
                case "По населеному пункту, вулиці і номеру будинку":
                    {
                        c.com = "SELECT * FROM people WHERE village LIKE '%" + village + "%' AND street LIKE '%" + street + "%' AND numb_of_house = '" + numb_of_house + "'";
                    }
                    break;

            }
            try
            {
                _manager.openConnection();

                MySqlCommand _command = new MySqlCommand(c.com,_manager.getConnection());
                _reader = _command.ExecuteReader();


                while (_reader.Read())
                {
                    RowOfData row = new RowOfData(_reader["people_id"], _reader["lastname"], _reader["name"],
                        _reader["surname"], _reader["sex"], _reader["date_of_birth"], _reader["village"],
                        _reader["street"], _reader["numb_of_house"], _reader["passport"], _reader["id_kod"],
                        _reader["phone_numb"], _reader["status"], _reader["email"]);
                    _data.Add(row);
                }
                for (int i = 0; i < _data.Count; i++)
                {
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
            textBoxCount.Text = Convert.ToString(_data.Count);
        }

        private void buttonОчиститиТаблицю_Click(object sender, EventArgs e)
        {
            dataGridViewВікноПошуку.Rows.Clear();
            textBoxCount.Text = "0";
        }

        private void textBoxFileName_Enter(object sender, EventArgs e)
        {
            if (textBoxFileName.Text == "Назва файлу")
            {
                textBoxFileName.Text = "";
                textBoxFileName.ForeColor = Color.Black;
            }
        }

        private void textBoxFileName_Leave(object sender, EventArgs e)
        {
            if (textBoxFileName.Text == "")
            {
                textBoxFileName.Text = "Назва файлу";
                textBoxFileName.ForeColor = Color.Gray;
            }
        }

        private void buttonExportInExcel_Click(object sender, EventArgs e)
        {
            string fileName = Convert.ToString(textBoxFileName.Text);

            if (fileName == "")
            {
                MessageBox.Show("Введіть назву файлу ! ");
            }
            else
            {
                string path = "D:\\БазаДаних\\" + fileName + ".xlsx";

                Excel.Application exApp = new Excel.Application();
                Excel.Workbook workbook = exApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                for (int i = 1; i < dataGridViewВікноПошуку.RowCount + 1; i++)
                {
                    for (int j = 1; j < dataGridViewВікноПошуку.ColumnCount + 1; j++)
                    {
                        worksheet.Rows[i].Columns[j] = dataGridViewВікноПошуку.Rows[i - 1].Cells[j - 1].Value;
                    }
                }
                exApp.AlertBeforeOverwriting = false;
                worksheet.SaveAs(path);
                exApp.Quit();
            }

            MessageBox.Show("Файл збережено на диск D в папку БазаДаних");
        }

        private void textBoxСтатус_Enter(object sender, EventArgs e)
        {
            if (textBoxСтатус.Text == "Статус")
            {
                textBoxСтатус.Text = "";
                textBoxСтатус.ForeColor = Color.Black;
            }
        }

        private void textBoxСтатус_Leave(object sender, EventArgs e)
        {
            if (textBoxСтатус.Text == "")
            {
                textBoxСтатус.Text = "Статус";
                textBoxСтатус.ForeColor = Color.Gray;
            }
        }

        private void rjButtonПовернутись_Click(object sender, EventArgs e)
        {
            Населення form = new Населення();
            this.Hide();
            form.Show();
        }

        private void населенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Населення form = new Населення();
            this.Hide();
            form.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void вихідЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
