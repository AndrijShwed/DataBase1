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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase
{
    public partial class Додати : Form
    {
        private List<RowOfData> _data = new List<RowOfData>();
        private User user;
        int rowNumber = 0;

        public Додати()
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
            this.dataGridViewДодати.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            this.dataGridViewДодати.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewДодати.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            this.dataGridViewДодати.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewДодати.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;

            this.dataGridViewДодати.EnableHeadersVisualStyles = false;

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

            dataGridViewДодати.Columns.Add(column1);
            dataGridViewДодати.Columns.Add(column2);
            dataGridViewДодати.Columns.Add(column3);
            dataGridViewДодати.Columns.Add(column4);
            dataGridViewДодати.Columns.Add(column5);
            dataGridViewДодати.Columns.Add(column6);
            dataGridViewДодати.Columns.Add(column7);
            dataGridViewДодати.Columns.Add(column8);
            dataGridViewДодати.Columns.Add(column9);
            dataGridViewДодати.Columns.Add(column10);
            dataGridViewДодати.Columns.Add(column11);
            dataGridViewДодати.Columns.Add(column12);
            dataGridViewДодати.Columns.Add(column13);
            dataGridViewДодати.Columns.Add(column14);


            dataGridViewДодати.AllowUserToAddRows = false;
            dataGridViewДодати.ReadOnly = true;
        }


        private void Редагувати_Shown(object sender, EventArgs e)
        {
            HeaderOfTheTable();
            dataGridViewДодати.Columns[0].ReadOnly = true;
            user = new User();

        }

        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void населенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Населення form = new Населення();
            this.Hide();
            form.Show();
        }

        private void вихідЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonПовернутись_Click_1(object sender, EventArgs e)
        {
            Населення form = new Населення();
            this.Hide();
            form.Show();
        }

        private void buttonДодатиРядок_Click_1(object sender, EventArgs e)
        {
            dataGridViewДодати.DataSource = null;
            dataGridViewДодати.ReadOnly = false;

            this.dataGridViewДодати.Rows.Add();

            dataGridViewДодати.Rows[rowNumber].Cells[0].ReadOnly = true;
            dataGridViewДодати.Rows[rowNumber].Cells[5].Value = "дд.мм.рррр";
            dataGridViewДодати.Rows[rowNumber].Cells[6].Value = comboBoxVillage.Text.ToString();
            dataGridViewДодати.Rows[rowNumber].Cells[7].Value = comboBoxStreets.Text.ToString();

            rowNumber++;

        }

        private void buttonЗберегти_В_Таблицю_Click(object sender, EventArgs e)
        {
            rowNumber = 0;
            bool a = false;
            bool add = false;
            int current = 0;

            ConnectionClass _manager = new ConnectionClass();
            MySqlDataReader _reader;

            int rowCount = dataGridViewДодати.RowCount;

            for (int i = 0; i < rowCount; i++)
            {
                try
                {


                    _manager.openConnection();

                    string lastname = Convert.ToString(this.dataGridViewДодати.Rows[current].Cells[1].Value);
                    string name = Convert.ToString(this.dataGridViewДодати.Rows[current].Cells[2].Value);
                    string surname = Convert.ToString(this.dataGridViewДодати.Rows[current].Cells[3].Value);
                    string sex = Convert.ToString(this.dataGridViewДодати.Rows[current].Cells[4].Value);
                    string date_of_birth = Convert.ToString(this.dataGridViewДодати.Rows[current].Cells[5].Value);
                    string s1 = date_of_birth.Substring(0, 2);
                    string s2 = date_of_birth.Substring(3, 2);
                    string s3 = date_of_birth.Substring(6, 4);

                    if (lastname != "" && name != "" && surname != "" && sex != "" && date_of_birth != "дд.мм.рррр")
                    {
                        date_of_birth = s3 + "-" + s2 + "-" + s1;
                        string equal = "SELECT * FROM people WHERE lastname = '" + lastname + "' AND" +
                           " name = '" + name + "' AND surname = '" + surname + "' AND " +
                             "date_of_birth = '" + date_of_birth + "'";

                        MySqlCommand search = new MySqlCommand(equal, _manager.getConnection());
                        _reader = search.ExecuteReader();
                        a = _reader.HasRows;
                        _reader.Close();

                        if (a)
                        {
                            current++;

                        }
                        else
                        {
                            try
                            {

                                date_of_birth = s3 + '/' + s2 + '/' + s1;
                                DateTime date_of_birth1 = Convert.ToDateTime(date_of_birth);
                                if (date_of_birth1 > DateTime.Now)
                                {
                                    MessageBox.Show("Дата народження не може бути новішою за поточну дату !");
                                }
                                else
                                {

                                    string _commandString = "INSERT INTO `people`(`lastname`,`name`,`surname`,`sex`,`date_of_birth`,`village`,`street`,`numb_of_house`,`passport`,`id_kod`,`phone_numb`,`status`,`email`)" +
                                  "VALUES(@lastname,@name,@surname,@sex,@date_of_birth,@village,@street,@numb_of_house,@passport,@id_kod,@phone_numb,@status,@email)";
                                    MySqlCommand _command = new MySqlCommand(_commandString, _manager.getConnection());



                                    _command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[1].Value;
                                    _command.Parameters.Add("@name", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[2].Value;
                                    _command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[3].Value;
                                    _command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[4].Value;
                                    _command.Parameters.Add("@date_of_birth", MySqlDbType.VarChar).Value = date_of_birth;
                                    _command.Parameters.Add("@village", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[6].Value;
                                    _command.Parameters.Add("@street", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[7].Value;
                                    _command.Parameters.Add("@numb_of_house", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[8].Value;
                                    _command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[9].Value;
                                    _command.Parameters.Add("@id_kod", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[10].Value;
                                    _command.Parameters.Add("@phone_numb", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[11].Value;
                                    _command.Parameters.Add("@status", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[12].Value;
                                    _command.Parameters.Add("@email", MySqlDbType.VarChar).Value = this.dataGridViewДодати.Rows[current].Cells[13].Value;

                                    if (_command.ExecuteNonQuery() == 1)
                                        add = true;

                                    dataGridViewДодати.Rows.RemoveAt(current);

                                }

                            }
                            catch
                            {
                                MessageBox.Show("Помилка введення дати ! Дату потрібно вводити у форматі - дд.мм.рррр ");
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Не всі поля заповнені !");
                        return;
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
                if (add && (i == rowCount - 1))
                {
                    MessageBox.Show("Дані добавлено !");

                }
                else if (!add && (i == rowCount - 1) && !a)

                    MessageBox.Show("Помилка добавлення даних !");

                if (a && dataGridViewДодати.Rows.Count > 0 && (i == rowCount - 1))

                    MessageBox.Show("Такий запис вже існує !");

            }

        }

        private void переглядДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ВивідДаних form = new ВивідДаних();
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
    }
}
