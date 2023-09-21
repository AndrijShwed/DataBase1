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
    public partial class ХудобаТаПтицяПошук : Form
    {
        public ХудобаТаПтицяПошук()
        {
            InitializeComponent();
            HeaderOfTheTable();


            textBoxПрізвище.Text = "Прізвище";
            textBoxПрізвище.ForeColor = Color.Gray;

            textBoxІм_я.Text = "Ім'я";
            textBoxІм_я.ForeColor = Color.Gray;

            textBoxПобатькові.Text = "Побатькові";
            textBoxПобатькові.ForeColor = Color.Gray;

            textBoxНаселенийПункт.Text = "Населений пункт";
            textBoxНаселенийПункт.ForeColor = Color.Gray;

            textBoxКількістьКорів.Text = "Кількість корів";
            textBoxКількістьКорів.ForeColor = Color.Gray;

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


            var column0 = new DataGridViewColumn();
            column0.HeaderText = "Номер";
            column0.Width = 55;
            column0.Name = "anymalsid";
            column0.Frozen = true;
            column0.CellTemplate = new DataGridViewTextBoxCell();

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
            column5.HeaderText = "Населений пункт";
            column5.Width = 110;
            column5.Name = "village";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "ВРХ";
            column6.Width = 98;
            column6.Name = "anymals";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Корови";
            column7.Width = 98;
            column7.Name = "covs";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Свині";
            column8.Width = 98;
            column8.Name = "pigs";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Вівці";
            column9.Width = 98;
            column9.Name = "sheeps";
            column9.Frozen = true;
            column9.CellTemplate = new DataGridViewTextBoxCell();

            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Кози";
            column10.Width = 98;
            column10.Name = "goats";
            column10.Frozen = true;
            column10.CellTemplate = new DataGridViewTextBoxCell();

            var column11 = new DataGridViewColumn();
            column11.HeaderText = "Коні";
            column11.Width = 98;
            column11.Name = "horses";
            column11.Frozen = true;
            column11.CellTemplate = new DataGridViewTextBoxCell();

            var column12 = new DataGridViewColumn();
            column12.HeaderText = "Птиця";
            column12.Width =98;
            column12.Name = "birds";
            column12.Frozen = true;
            column12.CellTemplate = new DataGridViewTextBoxCell();

            var column13 = new DataGridViewColumn();
            column13.HeaderText = "Кролі";
            column13.Width = 98;
            column13.Name = "rabbits";
            column13.Frozen = true;
            column13.CellTemplate = new DataGridViewTextBoxCell();

            var column14 = new DataGridViewColumn();
            column14.HeaderText = "Бджоли";
            column14.Width = 98;
            column14.Name = "bees";
            column14.Frozen = true;
            column14.CellTemplate = new DataGridViewTextBoxCell();

            var column15 = new DataGridViewColumn();
            column15.HeaderText = "Видалити";
            column15.Width = 98;
            column15.Name = "Видалити";
            column15.Name = "Видалити";
            column15.Frozen = true;
            column15.CellTemplate = new DataGridViewTextBoxCell();

            dataGridViewВікноПошуку.Columns.Add(column0);
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
        private void вихідЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ХудобаТаПтиця form = new ХудобаТаПтиця();
            this.Hide();
            form.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }
    }
}
