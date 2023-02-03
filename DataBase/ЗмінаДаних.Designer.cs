namespace DataBase
{
    partial class ЗмінаДаних
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ЗмінаДаних));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewЗберегтиЗміни = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.НаГоловнуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.НаселенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.переглядДанихToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.переглядДанихToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вибраніToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідЗПрограмиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідУВікноВходуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідУВікноРеєстраціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Choose = new System.Windows.Forms.Button();
            this.textBoxПрізвище = new System.Windows.Forms.TextBox();
            this.textBoxІм_я = new System.Windows.Forms.TextBox();
            this.textBoxПобатькові = new System.Windows.Forms.TextBox();
            this.textBoxНаселенийПункт = new System.Windows.Forms.TextBox();
            this.buttonЗберегтиЗміни = new System.Windows.Forms.Button();
            this.textBoxНомер = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonПовернутись = new DataBase.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗберегтиЗміни)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дані для редагування або видалення:";
            // 
            // dataGridViewЗберегтиЗміни
            // 
            this.dataGridViewЗберегтиЗміни.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewЗберегтиЗміни.Location = new System.Drawing.Point(13, 217);
            this.dataGridViewЗберегтиЗміни.Name = "dataGridViewЗберегтиЗміни";
            this.dataGridViewЗберегтиЗміни.RowHeadersWidth = 51;
            this.dataGridViewЗберегтиЗміни.RowTemplate.Height = 24;
            this.dataGridViewЗберегтиЗміни.Size = new System.Drawing.Size(2020, 650);
            this.dataGridViewЗберегтиЗміни.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.НаГоловнуToolStripMenuItem,
            this.НаселенняToolStripMenuItem,
            this.toolStripMenuItem1,
            this.переглядДанихToolStripMenuItem2,
            this.видалитиToolStripMenuItem,
            this.toolStripMenuItem5,
            this.вихідToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1924, 36);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // НаГоловнуToolStripMenuItem
            // 
            this.НаГоловнуToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.НаГоловнуToolStripMenuItem.Name = "НаГоловнуToolStripMenuItem";
            this.НаГоловнуToolStripMenuItem.Size = new System.Drawing.Size(111, 32);
            this.НаГоловнуToolStripMenuItem.Text = "Головна/";
            this.НаГоловнуToolStripMenuItem.Click += new System.EventHandler(this.НаГоловнуToolStripMenuItem_Click);
            // 
            // НаселенняToolStripMenuItem
            // 
            this.НаселенняToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.НаселенняToolStripMenuItem.Name = "НаселенняToolStripMenuItem";
            this.НаселенняToolStripMenuItem.Size = new System.Drawing.Size(132, 32);
            this.НаселенняToolStripMenuItem.Text = "Населення/";
            this.НаселенняToolStripMenuItem.Click += new System.EventHandler(this.НаселенняToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переглядДанихToolStripMenuItem1});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 32);
            this.toolStripMenuItem1.Text = "Редагувати";
            // 
            // переглядДанихToolStripMenuItem1
            // 
            this.переглядДанихToolStripMenuItem1.Name = "переглядДанихToolStripMenuItem1";
            this.переглядДанихToolStripMenuItem1.Size = new System.Drawing.Size(86, 26);
            // 
            // переглядДанихToolStripMenuItem2
            // 
            this.переглядДанихToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.переглядДанихToolStripMenuItem2.Name = "переглядДанихToolStripMenuItem2";
            this.переглядДанихToolStripMenuItem2.Size = new System.Drawing.Size(182, 32);
            this.переглядДанихToolStripMenuItem2.Text = "Перегляд даних";
            this.переглядДанихToolStripMenuItem2.Click += new System.EventHandler(this.переглядДанихToolStripMenuItem2_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вибраніToolStripMenuItem2});
            this.видалитиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            // 
            // вибраніToolStripMenuItem2
            // 
            this.вибраніToolStripMenuItem2.Name = "вибраніToolStripMenuItem2";
            this.вибраніToolStripMenuItem2.Size = new System.Drawing.Size(177, 32);
            this.вибраніToolStripMenuItem2.Text = "Вибрані";
            this.вибраніToolStripMenuItem2.Click += new System.EventHandler(this.вибраніToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(255, 32);
            this.toolStripMenuItem5.Text = "               Про програму";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідЗПрограмиToolStripMenuItem,
            this.вихідУВікноВходуToolStripMenuItem,
            this.вихідУВікноРеєстраціїToolStripMenuItem});
            this.вихідToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(81, 32);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // вихідЗПрограмиToolStripMenuItem
            // 
            this.вихідЗПрограмиToolStripMenuItem.Name = "вихідЗПрограмиToolStripMenuItem";
            this.вихідЗПрограмиToolStripMenuItem.Size = new System.Drawing.Size(334, 32);
            this.вихідЗПрограмиToolStripMenuItem.Text = "вихід з програми";
            this.вихідЗПрограмиToolStripMenuItem.Click += new System.EventHandler(this.вихідЗПрограмиToolStripMenuItem_Click);
            // 
            // вихідУВікноВходуToolStripMenuItem
            // 
            this.вихідУВікноВходуToolStripMenuItem.Name = "вихідУВікноВходуToolStripMenuItem";
            this.вихідУВікноВходуToolStripMenuItem.Size = new System.Drawing.Size(334, 32);
            this.вихідУВікноВходуToolStripMenuItem.Text = "вихід у вікно входу";
            this.вихідУВікноВходуToolStripMenuItem.Click += new System.EventHandler(this.вихідУВікноВходуToolStripMenuItem_Click);
            // 
            // вихідУВікноРеєстраціїToolStripMenuItem
            // 
            this.вихідУВікноРеєстраціїToolStripMenuItem.Name = "вихідУВікноРеєстраціїToolStripMenuItem";
            this.вихідУВікноРеєстраціїToolStripMenuItem.Size = new System.Drawing.Size(334, 32);
            this.вихідУВікноРеєстраціїToolStripMenuItem.Text = "вихід у вікно реєстрації";
            this.вихідУВікноРеєстраціїToolStripMenuItem.Click += new System.EventHandler(this.вихідУВікноРеєстраціїToolStripMenuItem_Click);
            // 
            // Choose
            // 
            this.Choose.BackColor = System.Drawing.Color.Yellow;
            this.Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Choose.Location = new System.Drawing.Point(16, 29);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(241, 39);
            this.Choose.TabIndex = 5;
            this.Choose.Text = "Знайти по:";
            this.Choose.UseVisualStyleBackColor = false;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // textBoxПрізвище
            // 
            this.textBoxПрізвище.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxПрізвище.Location = new System.Drawing.Point(16, 79);
            this.textBoxПрізвище.Name = "textBoxПрізвище";
            this.textBoxПрізвище.Size = new System.Drawing.Size(235, 34);
            this.textBoxПрізвище.TabIndex = 7;
            this.textBoxПрізвище.Enter += new System.EventHandler(this.textBoxПрізвище_Enter);
            this.textBoxПрізвище.Leave += new System.EventHandler(this.textBoxПрізвище_Leave);
            // 
            // textBoxІм_я
            // 
            this.textBoxІм_я.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxІм_я.Location = new System.Drawing.Point(257, 79);
            this.textBoxІм_я.Name = "textBoxІм_я";
            this.textBoxІм_я.Size = new System.Drawing.Size(230, 34);
            this.textBoxІм_я.TabIndex = 8;
            this.textBoxІм_я.Enter += new System.EventHandler(this.textBoxІм_я_Enter);
            this.textBoxІм_я.Leave += new System.EventHandler(this.textBoxІм_я_Leave);
            // 
            // textBoxПобатькові
            // 
            this.textBoxПобатькові.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxПобатькові.Location = new System.Drawing.Point(493, 79);
            this.textBoxПобатькові.Name = "textBoxПобатькові";
            this.textBoxПобатькові.Size = new System.Drawing.Size(258, 34);
            this.textBoxПобатькові.TabIndex = 9;
            this.textBoxПобатькові.Enter += new System.EventHandler(this.textBoxПобатькові_Enter);
            this.textBoxПобатькові.Leave += new System.EventHandler(this.textBoxПобатькові_Leave);
            // 
            // textBoxНаселенийПункт
            // 
            this.textBoxНаселенийПункт.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxНаселенийПункт.Location = new System.Drawing.Point(757, 79);
            this.textBoxНаселенийПункт.Name = "textBoxНаселенийПункт";
            this.textBoxНаселенийПункт.Size = new System.Drawing.Size(223, 34);
            this.textBoxНаселенийПункт.TabIndex = 10;
            this.textBoxНаселенийПункт.Enter += new System.EventHandler(this.textBoxНаселенийПункт_Enter);
            this.textBoxНаселенийПункт.Leave += new System.EventHandler(this.textBoxНаселенийПункт_Leave);
            // 
            // buttonЗберегтиЗміни
            // 
            this.buttonЗберегтиЗміни.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonЗберегтиЗміни.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonЗберегтиЗміни.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonЗберегтиЗміни.Location = new System.Drawing.Point(1167, 74);
            this.buttonЗберегтиЗміни.Name = "buttonЗберегтиЗміни";
            this.buttonЗберегтиЗміни.Size = new System.Drawing.Size(245, 39);
            this.buttonЗберегтиЗміни.TabIndex = 11;
            this.buttonЗберегтиЗміни.Text = "Зберегти зміни\r\n";
            this.buttonЗберегтиЗміни.UseVisualStyleBackColor = false;
            this.buttonЗберегтиЗміни.Click += new System.EventHandler(this.buttonЗберегтиЗміни_Click_1);
            // 
            // textBoxНомер
            // 
            this.textBoxНомер.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxНомер.Location = new System.Drawing.Point(986, 79);
            this.textBoxНомер.Name = "textBoxНомер";
            this.textBoxНомер.Size = new System.Drawing.Size(175, 34);
            this.textBoxНомер.TabIndex = 12;
            this.textBoxНомер.Enter += new System.EventHandler(this.textBoxНомер_Enter);
            this.textBoxНомер.Leave += new System.EventHandler(this.textBoxНомер_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxНомер);
            this.groupBox1.Controls.Add(this.buttonЗберегтиЗміни);
            this.groupBox1.Controls.Add(this.textBoxНаселенийПункт);
            this.groupBox1.Controls.Add(this.textBoxПобатькові);
            this.groupBox1.Controls.Add(this.textBoxІм_я);
            this.groupBox1.Controls.Add(this.textBoxПрізвище);
            this.groupBox1.Controls.Add(this.Choose);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1435, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Налаштування";
            // 
            // ButtonПовернутись
            // 
            this.ButtonПовернутись.BackColor = System.Drawing.Color.Red;
            this.ButtonПовернутись.FlatAppearance.BorderSize = 0;
            this.ButtonПовернутись.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonПовернутись.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonПовернутись.ForeColor = System.Drawing.Color.White;
            this.ButtonПовернутись.Location = new System.Drawing.Point(1800, 920);
            this.ButtonПовернутись.Name = "ButtonПовернутись";
            this.ButtonПовернутись.Size = new System.Drawing.Size(225, 40);
            this.ButtonПовернутись.TabIndex = 9;
            this.ButtonПовернутись.Text = "<<<Повернутись";
            this.ButtonПовернутись.UseVisualStyleBackColor = false;
            this.ButtonПовернутись.Click += new System.EventHandler(this.ButtonПовернутись_Click);
            // 
            // ЗмінаДаних
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1924, 997);
            this.Controls.Add(this.ButtonПовернутись);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewЗберегтиЗміни);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ЗмінаДаних";
            this.Text = "ЗмінаДаних";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.ЗмінаДаних_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗберегтиЗміни)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewЗберегтиЗміни;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem НаГоловнуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem НаселенняToolStripMenuItem;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.TextBox textBoxПрізвище;
        private System.Windows.Forms.TextBox textBoxІм_я;
        private System.Windows.Forms.TextBox textBoxПобатькові;
        private System.Windows.Forms.TextBox textBoxНаселенийПункт;
        private System.Windows.Forms.Button buttonЗберегтиЗміни;
        private System.Windows.Forms.TextBox textBoxНомер;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідЗПрограмиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідУВікноВходуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідУВікноРеєстраціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переглядДанихToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вибраніToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem переглядДанихToolStripMenuItem2;
        private RJButton ButtonПовернутись;
    }
}