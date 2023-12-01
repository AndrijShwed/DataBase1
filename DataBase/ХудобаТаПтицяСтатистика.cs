using MySqlConnector;
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
        private List<RowOfDataAnymals> _dataAll = new List<RowOfDataAnymals>();
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
            HeaderOfTheTable(dataGridViewAll);
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
            column1.Width = 110;
            column1.Name = "anymals";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Корови";
            column2.Width = 110;
            column2.Name = "covs";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Свині";
            column3.Width = 110;
            column3.Name = "pigs";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Вівці";
            column4.Width = 110;
            column4.Name = "sheeps";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Кози";
            column5.Width = 110;
            column5.Name = "goats";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Коні";
            column6.Width = 110;
            column6.Name = "horses";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Птиця";
            column7.Width = 110;
            column7.Name = "birds";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Кролі";
            column8.Width = 110;
            column8.Name = "rabbits";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            var column9 = new DataGridViewColumn();
            column9.HeaderText = "Бджоли";
            column9.Width = 110;
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

        private void ОновитиДані_Click(object sender, EventArgs e)
        {
            StatisticFill(dataGridViewBer, "Бережниця");
            StatisticFill(dataGridViewZab, "Заболотівці");
            StatisticFill(dataGridViewRog, "Рогізно");
            StatisticFill(dataGridViewZhur, "Журавків");
            StatisticFill(dataGridViewZag, "Загурщина");
            StatisticFillAll(dataGridViewAll);
        }

        private void StatisticFill(DataGridView _dataGridView, string _village)
        {
            string village = _village;
            dataGridView = _dataGridView;
            dataGridView.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            dataGridView.DefaultCellStyle.BackColor = Color.Beige;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.DataSource = null;
            dataGridView.Rows.Add();
           
            string a = "SELECT SUM(anymals) FROM anymals WHERE village = '" + village +"'";
            string c = "SELECT SUM(covs) FROM anymals WHERE village = '" + village +"'";
            string p = "SELECT SUM(pigs) FROM anymals WHERE village = '" + village +"'";
            string s = "SELECT SUM(sheeps) FROM anymals WHERE village = '" + village +"'";
            string g = "SELECT SUM(goats) FROM anymals WHERE village = '" + village +"'";
            string h = "SELECT SUM(horses) FROM anymals WHERE village = '" + village +"'";
            string b = "SELECT SUM(birds) FROM anymals WHERE village = '" + village +"'";
            string r = "SELECT SUM(rabbits) FROM anymals WHERE village = '" + village +"'";
            string be = "SELECT SUM(beeses) FROM anymals WHERE village = '" + village +"'";

            ConnectionClass _manager = new ConnectionClass();
            _manager.openConnection();

            MySqlCommand _commandA = new MySqlCommand(a, _manager.getConnection());
            MySqlCommand _commandC = new MySqlCommand(c, _manager.getConnection());
            MySqlCommand _commandP = new MySqlCommand(p, _manager.getConnection());
            MySqlCommand _commandS = new MySqlCommand(s, _manager.getConnection());
            MySqlCommand _commandG = new MySqlCommand(g, _manager.getConnection());
            MySqlCommand _commandH= new MySqlCommand(h, _manager.getConnection());
            MySqlCommand _commandB = new MySqlCommand(b, _manager.getConnection());
            MySqlCommand _commandR = new MySqlCommand(r, _manager.getConnection());
            MySqlCommand _commandBE = new MySqlCommand(be, _manager.getConnection());

            int anymalsCount = 0;
            int covsCount = 0;
            int pigsCount = 0;
            int sheepsCount = 0;
            int goatsCount = 0;
            int horsesCount = 0;
            int birdsCount = 0;
            int rabbitsCount = 0;
            int beesesCount = 0;

            if (_commandA.ExecuteScalar() != DBNull.Value)
                anymalsCount = Convert.ToInt32(_commandA.ExecuteScalar());
            if (_commandC.ExecuteScalar() != DBNull.Value)
                 covsCount = Convert.ToInt32(_commandC.ExecuteScalar());
            if (_commandP.ExecuteScalar() != DBNull.Value)
                 pigsCount = Convert.ToInt32(_commandP.ExecuteScalar());
            if (_commandS.ExecuteScalar() != DBNull.Value)
                 sheepsCount = Convert.ToInt32(_commandS.ExecuteScalar());
            if (_commandG.ExecuteScalar() != DBNull.Value)
                 goatsCount = Convert.ToInt32(_commandG.ExecuteScalar());
            if (_commandH.ExecuteScalar() != DBNull.Value)
                 horsesCount = Convert.ToInt32(_commandH.ExecuteScalar());
            if (_commandB.ExecuteScalar() != DBNull.Value)
                 birdsCount = Convert.ToInt32(_commandB.ExecuteScalar());
            if (_commandR.ExecuteScalar() != DBNull.Value)
                 rabbitsCount = Convert.ToInt32(_commandR.ExecuteScalar());
            if (_commandBE.ExecuteScalar() != DBNull.Value)
                 beesesCount = Convert.ToInt32(_commandBE.ExecuteScalar());

            dataGridView.Rows[0].Cells[0].Value = anymalsCount;
            dataGridView.Rows[0].Cells[1].Value = covsCount;
            dataGridView.Rows[0].Cells[2].Value = pigsCount;
            dataGridView.Rows[0].Cells[3].Value = sheepsCount;
            dataGridView.Rows[0].Cells[4].Value = goatsCount;
            dataGridView.Rows[0].Cells[5].Value = horsesCount;
            dataGridView.Rows[0].Cells[6].Value = birdsCount;
            dataGridView.Rows[0].Cells[7].Value = rabbitsCount;
            dataGridView.Rows[0].Cells[8].Value = beesesCount;

            _manager.closeConnection();

        }

        private void StatisticFillAll(DataGridView _dataGridView)
        {
           
            dataGridView = _dataGridView;
            dataGridView.DefaultCellStyle.Font = new Font("TimeNewRoman", 10);
            dataGridView.DefaultCellStyle.BackColor = Color.Coral;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.DataSource = null;
            dataGridView.Rows.Add();

            string a = "SELECT SUM(anymals) FROM anymals ";
            string c = "SELECT SUM(covs) FROM anymals ";
            string p = "SELECT SUM(pigs) FROM anymals ";
            string s = "SELECT SUM(sheeps) FROM anymals ";
            string g = "SELECT SUM(goats) FROM anymals ";
            string h = "SELECT SUM(horses) FROM anymals ";
            string b = "SELECT SUM(birds) FROM anymals ";
            string r = "SELECT SUM(rabbits) FROM anymals ";
            string be = "SELECT SUM(beeses) FROM anymals ";

            ConnectionClass _manager = new ConnectionClass();
            _manager.openConnection();

            MySqlCommand _commandA = new MySqlCommand(a, _manager.getConnection());
            MySqlCommand _commandC = new MySqlCommand(c, _manager.getConnection());
            MySqlCommand _commandP = new MySqlCommand(p, _manager.getConnection());
            MySqlCommand _commandS = new MySqlCommand(s, _manager.getConnection());
            MySqlCommand _commandG = new MySqlCommand(g, _manager.getConnection());
            MySqlCommand _commandH = new MySqlCommand(h, _manager.getConnection());
            MySqlCommand _commandB = new MySqlCommand(b, _manager.getConnection());
            MySqlCommand _commandR = new MySqlCommand(r, _manager.getConnection());
            MySqlCommand _commandBE = new MySqlCommand(be, _manager.getConnection());

            int anymalsCount = 0;
            int covsCount = 0;
            int pigsCount = 0;
            int sheepsCount = 0;
            int goatsCount = 0;
            int horsesCount = 0;
            int birdsCount = 0;
            int rabbitsCount = 0;
            int beesesCount = 0;

            if (_commandA.ExecuteScalar() != DBNull.Value)
                anymalsCount = Convert.ToInt32(_commandA.ExecuteScalar());
            if (_commandC.ExecuteScalar() != DBNull.Value)
                covsCount = Convert.ToInt32(_commandC.ExecuteScalar());
            if (_commandP.ExecuteScalar() != DBNull.Value)
                pigsCount = Convert.ToInt32(_commandP.ExecuteScalar());
            if (_commandS.ExecuteScalar() != DBNull.Value)
                sheepsCount = Convert.ToInt32(_commandS.ExecuteScalar());
            if (_commandG.ExecuteScalar() != DBNull.Value)
                goatsCount = Convert.ToInt32(_commandG.ExecuteScalar());
            if (_commandH.ExecuteScalar() != DBNull.Value)
                horsesCount = Convert.ToInt32(_commandH.ExecuteScalar());
            if (_commandB.ExecuteScalar() != DBNull.Value)
                birdsCount = Convert.ToInt32(_commandB.ExecuteScalar());
            if (_commandR.ExecuteScalar() != DBNull.Value)
                rabbitsCount = Convert.ToInt32(_commandR.ExecuteScalar());
            if (_commandBE.ExecuteScalar() != DBNull.Value)
                beesesCount = Convert.ToInt32(_commandBE.ExecuteScalar());

            dataGridView.Rows[0].Cells[0].Value = anymalsCount;
            dataGridView.Rows[0].Cells[1].Value = covsCount;
            dataGridView.Rows[0].Cells[2].Value = pigsCount;
            dataGridView.Rows[0].Cells[3].Value = sheepsCount;
            dataGridView.Rows[0].Cells[4].Value = goatsCount;
            dataGridView.Rows[0].Cells[5].Value = horsesCount;
            dataGridView.Rows[0].Cells[6].Value = birdsCount;
            dataGridView.Rows[0].Cells[7].Value = rabbitsCount;
            dataGridView.Rows[0].Cells[8].Value = beesesCount;

            _manager.closeConnection();

        }
    }


}
