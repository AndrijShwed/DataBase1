namespace DataBase
{
    partial class Населені_Пункти
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
            this.dataGridViewНаселені_Пункти = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.головнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.населеніПунктиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonПовернутись = new DataBase.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewНаселені_Пункти)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewНаселені_Пункти
            // 
            this.dataGridViewНаселені_Пункти.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewНаселені_Пункти.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(4)))), ((int)(((byte)(12)))));
            this.dataGridViewНаселені_Пункти.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewНаселені_Пункти.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewНаселені_Пункти.Name = "dataGridViewНаселені_Пункти";
            this.dataGridViewНаселені_Пункти.RowHeadersWidth = 51;
            this.dataGridViewНаселені_Пункти.RowTemplate.Height = 24;
            this.dataGridViewНаселені_Пункти.Size = new System.Drawing.Size(1030, 420);
            this.dataGridViewНаселені_Пункти.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.головнаToolStripMenuItem,
            this.населеніПунктиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // головнаToolStripMenuItem
            // 
            this.головнаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.головнаToolStripMenuItem.Name = "головнаToolStripMenuItem";
            this.головнаToolStripMenuItem.Size = new System.Drawing.Size(116, 32);
            this.головнаToolStripMenuItem.Text = "Головна /";
            this.головнаToolStripMenuItem.Click += new System.EventHandler(this.головнаToolStripMenuItem_Click);
            // 
            // населеніПунктиToolStripMenuItem
            // 
            this.населеніПунктиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.населеніПунктиToolStripMenuItem.Name = "населеніПунктиToolStripMenuItem";
            this.населеніПунктиToolStripMenuItem.Size = new System.Drawing.Size(195, 32);
            this.населеніПунктиToolStripMenuItem.Text = "Населені_Пункти";
            // 
            // ButtonПовернутись
            // 
            this.ButtonПовернутись.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonПовернутись.BackColor = System.Drawing.Color.Red;
            this.ButtonПовернутись.FlatAppearance.BorderSize = 0;
            this.ButtonПовернутись.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonПовернутись.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonПовернутись.ForeColor = System.Drawing.Color.White;
            this.ButtonПовернутись.Location = new System.Drawing.Point(800, 501);
            this.ButtonПовернутись.Name = "ButtonПовернутись";
            this.ButtonПовернутись.Size = new System.Drawing.Size(250, 40);
            this.ButtonПовернутись.TabIndex = 0;
            this.ButtonПовернутись.Text = "<<<Повернутись";
            this.ButtonПовернутись.UseVisualStyleBackColor = false;
            this.ButtonПовернутись.Click += new System.EventHandler(this.ButtonПовернутись_Click);
            // 
            // Населені_Пункти
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.dataGridViewНаселені_Пункти);
            this.Controls.Add(this.ButtonПовернутись);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Населені_Пункти";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Населені_Пункти";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewНаселені_Пункти)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton ButtonПовернутись;
        private System.Windows.Forms.DataGridView dataGridViewНаселені_Пункти;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem головнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem населеніПунктиToolStripMenuItem;
    }
}