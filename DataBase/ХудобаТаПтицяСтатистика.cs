using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DataBase
{
    public partial class ХудобаТаПтицяСтатистика : Form
    {

        private List<RowOfDataAnymals> _dataBer = new List<RowOfDataAnymals>();
        private List<RowOfDataAnymals> _dataZab = new List<RowOfDataAnymals>();
        private List<RowOfDataAnymals> _dataRog = new List<RowOfDataAnymals>();
        private List<RowOfDataAnymals> _dataZhur = new List<RowOfDataAnymals>();
        private List<RowOfDataAnymals> _dataZag = new List<RowOfDataAnymals>();
        private User user;
        DataGridView dataGridView;

        public ХудобаТаПтицяСтатистика()
        {
            InitializeComponent();
            HeaderOfTheTable(dataGridViewBer);
            HeaderOfTheTable(dataGridViewZab);
            HeaderOfTheTable(dataGridViewRog);
            HeaderOfTheTable(dataGridViewZhur);
            HeaderOfTheTable(dataGridViewZag);
        }

        private void HeaderOfTheTable(DataGridView _dataGridView)
        {
            this.dataGridView = _dataGridView;
            this.dataGridView.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            this.dataGridView.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
            this.dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            this.dataGridView.EnableHeadersVisualStyles = false;

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "ВРХ";
            column1.Width = 100;
            column1.Name = "anymals";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Корови";
            column2.Width = 100;
            column2.Name = "covs";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Свині";
            column3.Width = 100;
            column3.Name = "pigs";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Вівці";
            column4.Width = 100;
            column4.Name = "sheeps";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Кози";
            column5.Width = 100;
            column5.Name = "goats";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Коні";
            column6.Width = 100;
            column6.Name = "horses";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Птиця";
            column7.Width = 100;
            column7.Name = "birds";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Кролі";
            column8.Width = 100;
            column8.Name = "rabbits";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Бджоли";
            column9.Width = 100;
            column9.Name = "bees";
            column9.Frozen = true;
            column9.CellTemplate = new DataGridViewTextBoxCell();


            dataGridView.Columns.Add(column1);
            dataGridView.Columns.Add(column2);
            dataGridView.Columns.Add(column3);
            dataGridView.Columns.Add(column4);
            dataGridView.Columns.Add(column5);
            dataGridView.Columns.Add(column6);
            dataGridView.Columns.Add(column7);
            dataGridView.Columns.Add(column8);
            dataGridView.Columns.Add(column9);
           
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;

           
        }

        private void вийтиЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ХудобаТаПтицяДодати form = new ХудобаТаПтицяДодати();
            this.Hide();
            form.Show();
        }

        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ХудобаТаПтицяПошук form = new ХудобаТаПтицяПошук();
            this.Hide();
            form.Show();
        }

        private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }
    }
}
