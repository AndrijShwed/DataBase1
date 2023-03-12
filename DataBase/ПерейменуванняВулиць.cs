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
    public partial class ПерейменуванняВулиць : Form
    {
        private User user;

        public ПерейменуванняВулиць()
        {
            InitializeComponent();
        }

        private void населенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Населення form = new Населення();
            this.Hide();
            form.Show();
        }

        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void ЗамінитиІЗберегти_Click(object sender, EventArgs e)
        {
            user = new User();

            if (user.userName == "A")
            {


                string OldName = Convert.ToString(СтараНазва.Text);
                string NewName = Convert.ToString(НоваНазва.Text);

                if (СтараНазва.Text == "" || НоваНазва.Text == "")
                {
                    MessageBox.Show("Не заповнено назву вулиці !");

                }
                else
                {

                    ConnectionClass _manager = new ConnectionClass();

                    string _commandString = "UPDATE people SET street = '" + NewName + "'" +
                        " WHERE street = '" + OldName + "'";

                    MySqlCommand _command = new MySqlCommand(_commandString, _manager.getConnection());

                    try
                    {
                        _manager.openConnection();
                        _command.ExecuteNonQuery();



                        if (_command.ExecuteNonQuery() != 1)

                            MessageBox.Show("Назву вулиці замінено успішно !");

                    }
                    catch
                    {
                        MessageBox.Show("Помилка роботи з базою даних !");
                    }
                }
            }
            else
                MessageBox.Show("У вас немає доступу до зміни даних в таблиці !");
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
