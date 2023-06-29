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
            column4.Width = 110;
            column4.Name = "surname";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Стать";
            column5.Width = 50;
            column5.Name = "sex";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Дата народження";
            column6.Width = 110;
            column6.Name = "date_of_birth";
            column6.Frozen = true;
            column6.DefaultCellStyle.Format = "d";
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Село";
            column7.Width = 90;
            column7.Name = "village";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Вулиця";
            column8.Width = 110;
            column8.Name = "street";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Номер будинку";
            column9.Width = 90;
            column9.Name = "numb_of_house";
            column9.Frozen = true;
            column9.CellTemplate = new DataGridViewTextBoxCell();

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Паспорт";
            column10.Width = 90;
            column10.Name = "passport";
            column10.Frozen = true;
            column10.CellTemplate = new DataGridViewTextBoxCell();

            var column11 = new DataGridViewColumn();
            column11.HeaderText = "Ідент. код";
            column11.Width = 90;
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
            column13.Width = 90;
            column13.Name = "status";
            column13.Frozen = true;
            column13.CellTemplate = new DataGridViewTextBoxCell();

            var column14 = new DataGridViewColumn();
            column14.HeaderText = "Ел. пошта";
            column14.Width = 110;
            column14.Name = "email";
            column14.Frozen = true;
            column14.CellTemplate = new DataGridViewTextBoxCell();

            var column15= new DataGridViewColumn();
            column15.HeaderText = "Видалити";
            column15.Width = 110;
            column15.Name = "Видалити";
            column15.Name = "Видалити";
            column15.Frozen = true;
            column15.CellTemplate = new DataGridViewTextBoxCell();

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
            dataGridViewВікноПошуку.Columns.Add(column15);
           

            dataGridViewВікноПошуку.AllowUserToAddRows = false;
            dataGridViewВікноПошуку.ReadOnly = true;
        }

        private void ВікноПошуку_Shown(object sender, EventArgs e)
        {
            HeaderOfTheTable();
            user = new User();
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
            if (textBoxПрізвище.Text == "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text != "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По статусу і населеному пункту";
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
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text == "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По прізвищу і побатькові";
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
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text != "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text == "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                textBoxДатаНародженняВІД.Text == "Дата народження від:" &&
                textBoxДатаНародженняДО.Text == "Дата народження до:"
                )
            {
                choice = "По прізвищу побатькові і населеному пункту";
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
            if (textBoxПрізвище.Text != "Прізвище" && textBoxІм_я.Text == "Ім'я" &&
                textBoxПобатькові.Text == "Побатькові" && textBoxНаселенийПункт.Text != "Населений пункт" &&
                textBoxСтать.Text != "Стать" && textBoxВулиця.Text == "Вулиця" &&
                textBoxНомерБудинку.Text == "Номер будинку" && textBoxСтатус.Text == "Статус" &&
                (textBoxДатаНародженняВІД.Text != "Дата народження від:" ||
                textBoxДатаНародженняДО.Text != "Дата народження до:")
                )
            {
                choice = "По прізвищу, населеному пункту, статі, даті народження від і до:";
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
           
            string lastname = Convert.ToString(textBoxПрізвище.Text).ToLower();
            string name = Convert.ToString(textBoxІм_я.Text).ToLower();
            string surname = Convert.ToString(textBoxПобатькові.Text).ToLower();
            string sex = Convert.ToString(textBoxСтать.Text).ToLower();
            string village = Convert.ToString(textBoxНаселенийПункт.Text).ToLower();
            string street = Convert.ToString(textBoxВулиця.Text).ToLower();
            string numb_of_house = Convert.ToString(textBoxНомерБудинку.Text);
            string status = Convert.ToString(textBoxСтатус.Text).ToLower();
           

            switch (choice)
            {
              
                case "По прізвищу":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(lastname) LIKE '" + lastname + "%'";
                    }
                    break;
                case "По імені":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(name) LIKE '" + name + "%'";
                    }
                    break;
                case "По побатькові":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(surname) LIKE '" + surname + "%'";
                    }
                    break;
                case "По населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(village) LIKE '" + village + "%'";
                    }
                    break;
                case "По статі":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(sex) LIKE '" + sex + "%'";
                    }
                    break;
                case "По статусу":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(status) LIKE '%" + status + "%'";
                    }
                    break;
                case "По статусу і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(status) LIKE '%" + status + "%' AND LOWER(village) LIKE '" + village + "%'";
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
                case "По прізвищу, населеному пункту, статі, даті народження від і до:":
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

                        c.com = "SELECT * FROM people WHERE date_of_birth between '" + date_start + "' AND '" + date_end + "' AND LOWER(sex) LIKE '" + sex + "%'" +
                            "AND LOWER(lastname) LIKE '" + lastname + "%' AND LOWER(village) LIKE '" + village + "%'";
                    }
                    break;
                case "По прізвищу і імені":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(lastname) LIKE '" + lastname + "%' AND LOWER(name) LIKE '" + name + "%'";
                    }
                    break;
                case "По прізвищу і побатькові":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(lastname) LIKE '" + lastname + "%' AND LOWER(surname) LIKE '" + surname + "%'";
                    }
                    break;
                case "По прізвищу і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(lastname) LIKE '" + lastname + "%' AND LOWER(village) LIKE '" + village + "%'";
                    }
                    break;
                case "По імені і побатькові":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(name) LIKE '" + name + "%' AND LOWER(surname) LIKE '" + surname + "%'";
                    }
                    break;
                case "По імені і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(name) LIKE '" + name + "%' AND LOWER(village) LIKE '" + village + "%'";
                    }
                    break;
                case "По прізвищу імені і побатькові":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(lastname) LIKE '" + lastname + "%' AND LOWER(name) LIKE '" + name + "%' AND LOWER(surname) LIKE '" + surname + "%'";
                    }
                    break;
                case "По прізвищу імені і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(lastname) LIKE '" + lastname + "%' AND LOWER(name) LIKE '" + name + "%' AND LOWER(village) LIKE '" + village + "%'";
                    }
                    break;
                case "По прізвищу побатькові і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(lastname) LIKE '" + lastname + "%' AND LOWER(surname) LIKE '" + surname + "%' AND LOWER(village) LIKE '" + village + "%'";
                    }
                    break;
                case "По статі і населеному пункту":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(sex) LIKE '" + sex + "%' AND LOWER(village) LIKE '" + village + "%'";
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
                        c.com = "SELECT * FROM people WHERE LOWER(sex) LIKE '" + sex + "%' AND date_of_birth between '" + date_start + "' AND '" + date_end + "'";
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
                        c.com = "SELECT * FROM people WHERE LOWER(village)LIKE '" + village + "%' AND date_of_birth between '" + date_start + "' AND '" + date_end + "'";
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
                        c.com = "SELECT * FROM people WHERE LOWER(sex) LIKE '" + sex + "%' AND LOWER(village) LIKE '" + village + "%' AND date_of_birth between '" + date_start + "' AND '" + date_end + "'";
                    }
                    break;
                case "По населеному пункту і вулиці":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(village) LIKE '" + village + "%' AND LOWER(street) LIKE '" + street + "%'";
                    }
                    break;
                case "По населеному пункту, вулиці і номеру будинку":
                    {
                        c.com = "SELECT * FROM people WHERE LOWER(village) LIKE '" + village + "%' AND LOWER(street) LIKE '" + street + "%' AND numb_of_house = '" + numb_of_house + "'";
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
                    dataGridViewВікноПошуку.Rows[i].Cells[14].Value = "Видалити";
                    dataGridViewВікноПошуку.Rows[i].Cells[14].Style.BackColor = Color.DarkRed;
                    dataGridViewВікноПошуку.Rows[i].Cells[14].Style.ForeColor = Color.White;
                    dataGridViewВікноПошуку.Rows[i].Cells[14].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                   

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

        private void Редагувати_Click(object sender, EventArgs e)
        {
            dataGridViewВікноПошуку.ReadOnly = false;
            dataGridViewВікноПошуку.Columns[0].ReadOnly = true;
        }

        private void Зберегти_зміни_Click(object sender, EventArgs e)
        {
            user = new User();

            if (user.userName == "A")
            {

                if (dataGridViewВікноПошуку.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не вибрано рядки для збереження внесених змін. Виберіть рядки !");

                }
                else
                {
                    ConnectionClass _manager = new ConnectionClass();

                    bool changed = true;


                    for (int i = 0; i < dataGridViewВікноПошуку.SelectedRows.Count; i++)
                    {



                        if (Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[1].Value) != "" &&
                            Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[3].Value) != "" &&
                            Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[4].Value) != "")

                        {
                            string people_id = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[0].Value);
                            string lastname = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[1].Value);
                            string name = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[2].Value);
                            string surname = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[3].Value);
                            string sex = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[4].Value);
                            string date_of_birth = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[5].Value);
                            string village = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[6].Value);
                            string street = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[7].Value);
                            string numb_of_house = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[8].Value);
                            string passport = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[9].Value);
                            string id_kod = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[10].Value);
                            string phone_numb = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[11].Value);
                            string status = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[12].Value);
                            string email = Convert.ToString(this.dataGridViewВікноПошуку.SelectedRows[i].Cells[13].Value);

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

                                        dataGridViewВікноПошуку.ReadOnly = true;

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

                    dataGridViewВікноПошуку.ReadOnly = true;
                    _manager.closeConnection();
                }
            }

            else
                MessageBox.Show("У вас немає доступу до зміни даних в таблиці !");

        }

        private void dataGridViewВікноПошуку_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            user = new User();

            if (user.userName == "A")
            {

                if (e.ColumnIndex == 14)
                {
                    DataGridViewRow row = dataGridViewВікноПошуку.Rows[e.RowIndex];


                    if (MessageBox.Show(string.Format("Ви дійсно бажаєте видалити цей рядок ?", row.Cells["people_id"].Value), "Погоджуюсь",
                       MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ConnectionClass _manager = new ConnectionClass();
                        _manager.openConnection();

                        string com = "DELETE FROM people WHERE people_id = '" + row.Cells["people_id"].Value + "'";

                        MySqlCommand dell = new MySqlCommand(com, _manager.getConnection());


                        if (dell.ExecuteNonQuery() == 1)
                        {
                            dataGridViewВікноПошуку.Rows.RemoveAt(row.Index);
                            MessageBox.Show("Дані успішно видалено ");
                            _manager.closeConnection();
                        }
                        else
                        {
                            MessageBox.Show("Помилка роботи з базою даних !!!");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("У вас немає доступу до видалення даних з таблиці !");
            }

        }

    }
}
