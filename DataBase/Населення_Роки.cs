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
    public partial class Населення_Роки : Form
    {
        public Населення_Роки()
        {
            InitializeComponent();
            HeaderOfTheTable();
        }

        private void HeaderOfTheTable()
        {
            this.dataGridViewКількістьНаселення.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            this.dataGridViewКількістьНаселення.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridViewКількістьНаселення.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            this.dataGridViewКількістьНаселення.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewКількістьНаселення.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            this.dataGridViewКількістьНаселення.EnableHeadersVisualStyles = false;


            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Рік";
            column1.Width = 55;
            column1.Name = "year";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Бережниця";
            column2.Width = 120;
            column2.Name = "berezhnytsya";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Заболотівці";
            column3.Width = 100;
            column3.Name = "zabolotivtsi";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Рогізно";
            column4.Width = 120;
            column4.Name = "rogizno";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Журавків";
            column5.Width = 60;
            column5.Name = "zhuravkiv";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Загурщина";
            column6.Width = 120;
            column6.Name = "zagurzchyna";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();

           

            dataGridViewКількістьНаселення.Columns.Add(column1);
            dataGridViewКількістьНаселення.Columns.Add(column2);
            dataGridViewКількістьНаселення.Columns.Add(column3);
            dataGridViewКількістьНаселення.Columns.Add(column4);
            dataGridViewКількістьНаселення.Columns.Add(column5);
            dataGridViewКількістьНаселення.Columns.Add(column6);


            dataGridViewКількістьНаселення.AllowUserToAddRows = false;
            dataGridViewКількістьНаселення.ReadOnly = true;
        }


        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }
    }
}
