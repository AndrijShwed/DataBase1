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
        public Домогосподарства()
        {
            InitializeComponent();
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

        private void Додати_Click(object sender, EventArgs e)
        {
            ДомогосподарстваДодати form = new ДомогосподарстваДодати();
            this.Hide();
            form.Show();    
        }

        private void Пошук_Click(object sender, EventArgs e)
        {
            Домогосподарства_Пошук form = new Домогосподарства_Пошук();
            this.Hide();
            form.Show();
        }


//        private void comboBoxVillage_SelectedIndexChanged(object sender, EventArgs e)
//        {

//            comboBoxStreets.Items.Clear();

//            string village = comboBoxVillage.Text;
//            comboBoxStreets.Text = "Виберіть вулицю";

//            switch (village)
//            {
//                case "Бережниця":
//                    comboBoxStreets.Items.Add("Шевченка");
//                    comboBoxStreets.Items.Add("Дорошенка");
//                    comboBoxStreets.Items.Add("Надбережна");
//                    comboBoxStreets.Items.Add("Бандери С.");
//                    comboBoxStreets.Items.Add("Рогізнянська");
//                    comboBoxStreets.Items.Add("Ів.Франка");
//                    comboBoxStreets.Items.Add("Космонавтів");
//                    comboBoxStreets.Items.Add("Нова");
//                    comboBoxStreets.Items.Add("Молодіжна");
//                    comboBoxStreets.Items.Add("Лісна");
//                    comboBoxStreets.Items.Add("Садова");
//                    comboBoxStreets.Items.Add("Зелена");

//                    break;
//                case "Рогізно":
//                    comboBoxStreets.Items.Add("Шевченка");
//                    comboBoxStreets.Items.Add("Ів.Франка");
//                    comboBoxStreets.Items.Add("Лесі Українки");
//                    comboBoxStreets.Items.Add("Зелена");
//                    comboBoxStreets.Items.Add("Садова");
//                    comboBoxStreets.Items.Add("Вузька");
//                    break;
//                case "Заболотівці":
//                    comboBoxStreets.Items.Add("Миру");
//                    comboBoxStreets.Items.Add("Шевченка");
//                    comboBoxStreets.Items.Add("Космонавтів");
//                    comboBoxStreets.Items.Add("Героїв України");
//                    break;
//                case "Журавків":
//                    comboBoxStreets.Items.Add("Шевченка");
//                    comboBoxStreets.Items.Add("Довбуша");
//                    comboBoxStreets.Items.Add("Миру");
//                    comboBoxStreets.Items.Add("Б.Хмельницького");
//                    comboBoxStreets.Items.Add("Чорновола В.");
//                    comboBoxStreets.Items.Add("Лісна");
//                    break;
//                case "Загурщина":
//                    comboBoxStreets.Items.Add("Шевченка");
//                    comboBoxStreets.Items.Add("Зелена");
//                    comboBoxStreets.Items.Add("Нова");
//                    break;
//                default:
//                    return;

                   

//            }
            
//        }

//        private void Знайти_власника_Click(object sender, EventArgs e)
//        {
//            comboBoxLastname.Items.Clear();
//            comboBoxName.Items.Clear();
//            comboBoxSurname.Items.Clear();

//            string village = Convert.ToString(comboBoxVillage.Text).ToLower();
//            string street = Convert.ToString(comboBoxStreets.Text).ToLower();
//            string numb_of_house = Convert.ToString(comboBoxNumb.Text);
//            SQLCommand c = new SQLCommand();

//            c.com = "SELECT lastname,name,surname FROM people WHERE  LOWER(village) LIKE '" +
//                village + "' AND LOWER(street) LIKE '" + street + "' AND numb_of_house = '" +
//                numb_of_house + "'";

           
//            ConnectionClass _manager = new ConnectionClass();
//            MySqlDataReader _reader;
           
//            _manager.openConnection();

//            MySqlCommand _command = new MySqlCommand(c.com, _manager.getConnection());
           
//            _reader = _command.ExecuteReader();
           


//            while (_reader.Read())
//            {
//                RowOfDataL row = new RowOfDataL(_reader["lastname"], _reader["name"], _reader["surname"]);
//                _dataL.Add(row);
//            }
//            for (int i = 0; i < _dataL.Count; i++)
//            {
//                comboBoxLastname.Items.Add(_dataL[i].lastname);
//                comboBoxName.Items.Add(_dataL[i].name);
//                comboBoxSurname.Items.Add(_dataL[i].surname);
//                mess = true;

//            }

//           _manager.closeConnection();

//            comboBoxLastname.Text = "Виберіть прізвище";
//            string Lastname = comboBoxLastname.Text;
//            comboBoxName.Text = "Виберіть ім_я";
//            string Name = comboBoxName.Text;
//            comboBoxSurname.Text = "Виберіть побатькові";
//            string Surname = comboBoxSurname.Text;


//            if (mess == false)
//            {
//                MessageBox.Show("Запис не знайдено !");
//            }
//        }


    }
}
