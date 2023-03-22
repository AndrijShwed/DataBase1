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
    public partial class Домогосподарства : Form
    {
        private List<RowOfDataL> _dataL = new List<RowOfDataL>();
      
        private User user;
        bool mess;

        public Домогосподарства()
        {
            InitializeComponent();
            comboBoxVillage.Text = "Виберіть населений пункт";
            comboBoxVillage.Items.Add("Бережниця");
            comboBoxVillage.Items.Add("Заболотівці");
            comboBoxVillage.Items.Add("Рогізно");
            comboBoxVillage.Items.Add("Журавків");
            comboBoxVillage.Items.Add("Загурщина");
            HeaderOfTheTable();
        }
        private void HeaderOfTheTable()
        {
            this.dataGridViewДомогосподарства.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            this.dataGridViewДомогосподарства.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewДомогосподарства.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            this.dataGridViewДомогосподарства.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewДомогосподарства.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;

            this.dataGridViewДомогосподарства.EnableHeadersVisualStyles = false;

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер";
            column1.Width = 55;
            column1.Name = "idhouses";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Населений пункт";
            column2.Width = 150;
            column2.Name = "village";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Вулиця";
            column3.Width = 180;
            column3.Name = "street";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Номер будинку";
            column4.Width = 120;
            column4.Name = "numb_of_house";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Прізвище";
            column5.Width = 180;
            column5.Name = "lastname";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Ім_я";
            column6.Width = 180;
            column6.Name = "name";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Побатькові";
            column7.Width = 180;
            column7.Name = "surname";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Загальна площа";
            column8.Width = 120;
            column8.Name = "totalArea";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Житлова площа";
            column9.Width = 120;
            column9.Name = "livingArea";
            column9.Frozen = true;
            column9.CellTemplate = new DataGridViewTextBoxCell();

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Кількість кімнат";
            column10.Width = 120;
            column10.Name = "total_of_rooms";
            column10.Frozen = true;
            column10.CellTemplate = new DataGridViewTextBoxCell();


            dataGridViewДомогосподарства.Columns.Add(column1);
            dataGridViewДомогосподарства.Columns.Add(column2);
            dataGridViewДомогосподарства.Columns.Add(column3);
            dataGridViewДомогосподарства.Columns.Add(column4);
            dataGridViewДомогосподарства.Columns.Add(column5);
            dataGridViewДомогосподарства.Columns.Add(column6);
            dataGridViewДомогосподарства.Columns.Add(column7);
            dataGridViewДомогосподарства.Columns.Add(column8);
            dataGridViewДомогосподарства.Columns.Add(column9);
            dataGridViewДомогосподарства.Columns.Add(column10);



            dataGridViewДомогосподарства.AllowUserToAddRows = false;
            dataGridViewДомогосподарства.ReadOnly = true;
        }

        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void comboBoxVillage_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxStreets.Items.Clear();

            string village = comboBoxVillage.Text;
            comboBoxStreets.Text = "Виберіть вулицю";

            switch (village)
            {
                case "Бережниця":
                    comboBoxStreets.Items.Add("Шевченка");
                    comboBoxStreets.Items.Add("Дорошенка");
                    comboBoxStreets.Items.Add("Надбережна");
                    comboBoxStreets.Items.Add("Бандери С.");
                    comboBoxStreets.Items.Add("Рогізнянська");
                    comboBoxStreets.Items.Add("Ів.Франка");
                    comboBoxStreets.Items.Add("Космонавтів");
                    comboBoxStreets.Items.Add("Нова");
                    comboBoxStreets.Items.Add("Молодіжна");
                    comboBoxStreets.Items.Add("Лісна");
                    comboBoxStreets.Items.Add("Садова");
                    comboBoxStreets.Items.Add("Зелена");

                    break;
                case "Рогізно":
                    comboBoxStreets.Items.Add("Шевченка");
                    comboBoxStreets.Items.Add("Ів.Франка");
                    comboBoxStreets.Items.Add("Лесі Українки");
                    comboBoxStreets.Items.Add("Зелена");
                    comboBoxStreets.Items.Add("Садова");
                    comboBoxStreets.Items.Add("Вузька");
                    break;
                case "Заболотівці":
                    comboBoxStreets.Items.Add("Миру");
                    comboBoxStreets.Items.Add("Шевченка");
                    comboBoxStreets.Items.Add("Космонавтів");
                    comboBoxStreets.Items.Add("Героїв України");
                    break;
                case "Журавків":
                    comboBoxStreets.Items.Add("Шевченка");
                    comboBoxStreets.Items.Add("Довбуша");
                    comboBoxStreets.Items.Add("Миру");
                    comboBoxStreets.Items.Add("Б.Хмельницького");
                    comboBoxStreets.Items.Add("Чорновола В.");
                    comboBoxStreets.Items.Add("Лісна");
                    break;
                case "Загурщина":
                    comboBoxStreets.Items.Add("Шевченка");
                    comboBoxStreets.Items.Add("Зелена");
                    comboBoxStreets.Items.Add("Нова");
                    break;
                default:
                    return;

                   

            }
            
        }

        private void Знайти_власника_Click(object sender, EventArgs e)
        {
            comboBoxLastname.Items.Clear();
            comboBoxName.Items.Clear();
            comboBoxSurname.Items.Clear();

            comboBoxLastname.Text = "Виберіть прізвище";
            string Lastname = comboBoxLastname.Text;
            comboBoxName.Text = "Виберіть ім_я";
            string Name = comboBoxName.Text;
            comboBoxSurname.Text = "Виберіть побатькові";
            string Surname = comboBoxSurname.Text;
            
          
            string village = Convert.ToString(comboBoxVillage.Text).ToLower();
            string street = Convert.ToString(comboBoxStreets.Text).ToLower();
            string numb_of_house = Convert.ToString(comboBoxNumb.Text);
            SQLCommand c = new SQLCommand();
            c.com = "SELECT lastname,name,surname FROM people WHERE  LOWER(village) LIKE '" +
                village + "' AND LOWER(street) LIKE '" + street + "' AND numb_of_house = '" +
                numb_of_house + "'";

           
            ConnectionClass _manager = new ConnectionClass();
            MySqlDataReader _reader;
           
            _manager.openConnection();

            MySqlCommand _command = new MySqlCommand(c.com, _manager.getConnection());
           
            _reader = _command.ExecuteReader();
           


            while (_reader.Read())
            {
                RowOfDataL row = new RowOfDataL(_reader["lastname"], _reader["name"], _reader["surname"]);
                _dataL.Add(row);
            }
            for (int i = 0; i < _dataL.Count; i++)
            {
                comboBoxLastname.Items.Add(_dataL[i].lastname);
                comboBoxName.Items.Add(_dataL[i].name);
                comboBoxSurname.Items.Add(_dataL[i].surname);
                mess = true;

            }
            comboBoxLastname.Items.Clear();
            comboBoxName.Items.Clear();
            comboBoxSurname.Items.Clear();

            if (mess == false)
            {
                MessageBox.Show("Запис не знайдено !");
            }
        }
    }
}
