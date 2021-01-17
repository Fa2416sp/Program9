
namespace Program9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.системаКоординатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарисоватьОсиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tgxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arcsinxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцияПоВариантуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикФункцииВChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxCos = new System.Windows.Forms.PictureBox();
            this.pictureBoxSin = new System.Windows.Forms.PictureBox();
            this.pictureBoxTg = new System.Windows.Forms.PictureBox();
            this.pictureBoxArcsin = new System.Windows.Forms.PictureBox();
            this.pictureBoxExp = new System.Windows.Forms.PictureBox();
            this.pictureBoxF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArcsin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxF)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.системаКоординатToolStripMenuItem,
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // системаКоординатToolStripMenuItem
            // 
            this.системаКоординатToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нарисоватьОсиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.системаКоординатToolStripMenuItem.Name = "системаКоординатToolStripMenuItem";
            this.системаКоординатToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.системаКоординатToolStripMenuItem.Text = "Система координат";
            // 
            // нарисоватьОсиToolStripMenuItem
            // 
            this.нарисоватьОсиToolStripMenuItem.Name = "нарисоватьОсиToolStripMenuItem";
            this.нарисоватьОсиToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.нарисоватьОсиToolStripMenuItem.Text = "Нарисовать оси";
            this.нарисоватьОсиToolStripMenuItem.Click += new System.EventHandler(this.нарисоватьОсиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cosxToolStripMenuItem,
            this.sinxToolStripMenuItem,
            this.tgxToolStripMenuItem,
            this.arcsinxToolStripMenuItem,
            this.expxToolStripMenuItem,
            this.функцияПоВариантуToolStripMenuItem,
            this.графикФункцииВChartToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // cosxToolStripMenuItem
            // 
            this.cosxToolStripMenuItem.Name = "cosxToolStripMenuItem";
            this.cosxToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cosxToolStripMenuItem.Text = "Cos(x)";
            this.cosxToolStripMenuItem.Click += new System.EventHandler(this.cosxToolStripMenuItem_Click);
            // 
            // sinxToolStripMenuItem
            // 
            this.sinxToolStripMenuItem.Name = "sinxToolStripMenuItem";
            this.sinxToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sinxToolStripMenuItem.Text = "Sin(x)";
            this.sinxToolStripMenuItem.Click += new System.EventHandler(this.sinxToolStripMenuItem_Click);
            // 
            // tgxToolStripMenuItem
            // 
            this.tgxToolStripMenuItem.Name = "tgxToolStripMenuItem";
            this.tgxToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.tgxToolStripMenuItem.Text = "Tg(x)";
            this.tgxToolStripMenuItem.Click += new System.EventHandler(this.tgxToolStripMenuItem_Click);
            // 
            // arcsinxToolStripMenuItem
            // 
            this.arcsinxToolStripMenuItem.Name = "arcsinxToolStripMenuItem";
            this.arcsinxToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.arcsinxToolStripMenuItem.Text = "Arcsin(x)";
            this.arcsinxToolStripMenuItem.Click += new System.EventHandler(this.arcsinxToolStripMenuItem_Click);
            // 
            // expxToolStripMenuItem
            // 
            this.expxToolStripMenuItem.Name = "expxToolStripMenuItem";
            this.expxToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.expxToolStripMenuItem.Text = "Exp(x)";
            this.expxToolStripMenuItem.Click += new System.EventHandler(this.expxToolStripMenuItem_Click);
            // 
            // функцияПоВариантуToolStripMenuItem
            // 
            this.функцияПоВариантуToolStripMenuItem.Name = "функцияПоВариантуToolStripMenuItem";
            this.функцияПоВариантуToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.функцияПоВариантуToolStripMenuItem.Text = "Функция  по варианту";
            this.функцияПоВариантуToolStripMenuItem.Click += new System.EventHandler(this.функцияПоВариантуToolStripMenuItem_Click);
            // 
            // графикФункцииВChartToolStripMenuItem
            // 
            this.графикФункцииВChartToolStripMenuItem.Name = "графикФункцииВChartToolStripMenuItem";
            this.графикФункцииВChartToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.графикФункцииВChartToolStripMenuItem.Text = "График функции в Chart";
            this.графикФункцииВChartToolStripMenuItem.Click += new System.EventHandler(this.графикФункцииВChartToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 459);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(500, 200);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 433);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(262, 433);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "oy";
            // 
            // pictureBoxCos
            // 
            this.pictureBoxCos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCos.Image")));
            this.pictureBoxCos.Location = new System.Drawing.Point(372, 28);
            this.pictureBoxCos.Name = "pictureBoxCos";
            this.pictureBoxCos.Size = new System.Drawing.Size(139, 77);
            this.pictureBoxCos.TabIndex = 7;
            this.pictureBoxCos.TabStop = false;
            this.pictureBoxCos.Visible = false;
            // 
            // pictureBoxSin
            // 
            this.pictureBoxSin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSin.Image")));
            this.pictureBoxSin.Location = new System.Drawing.Point(372, 28);
            this.pictureBoxSin.Name = "pictureBoxSin";
            this.pictureBoxSin.Size = new System.Drawing.Size(139, 77);
            this.pictureBoxSin.TabIndex = 8;
            this.pictureBoxSin.TabStop = false;
            this.pictureBoxSin.Visible = false;
            // 
            // pictureBoxTg
            // 
            this.pictureBoxTg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTg.Image")));
            this.pictureBoxTg.Location = new System.Drawing.Point(372, 27);
            this.pictureBoxTg.Name = "pictureBoxTg";
            this.pictureBoxTg.Size = new System.Drawing.Size(139, 77);
            this.pictureBoxTg.TabIndex = 9;
            this.pictureBoxTg.TabStop = false;
            this.pictureBoxTg.Visible = false;
            // 
            // pictureBoxArcsin
            // 
            this.pictureBoxArcsin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArcsin.Image")));
            this.pictureBoxArcsin.Location = new System.Drawing.Point(372, 28);
            this.pictureBoxArcsin.Name = "pictureBoxArcsin";
            this.pictureBoxArcsin.Size = new System.Drawing.Size(139, 77);
            this.pictureBoxArcsin.TabIndex = 10;
            this.pictureBoxArcsin.TabStop = false;
            this.pictureBoxArcsin.Visible = false;
            // 
            // pictureBoxExp
            // 
            this.pictureBoxExp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExp.Image")));
            this.pictureBoxExp.Location = new System.Drawing.Point(372, 28);
            this.pictureBoxExp.Name = "pictureBoxExp";
            this.pictureBoxExp.Size = new System.Drawing.Size(139, 77);
            this.pictureBoxExp.TabIndex = 11;
            this.pictureBoxExp.TabStop = false;
            this.pictureBoxExp.Visible = false;
            // 
            // pictureBoxF
            // 
            this.pictureBoxF.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxF.Image")));
            this.pictureBoxF.Location = new System.Drawing.Point(263, 28);
            this.pictureBoxF.Name = "pictureBoxF";
            this.pictureBoxF.Size = new System.Drawing.Size(259, 41);
            this.pictureBoxF.TabIndex = 12;
            this.pictureBoxF.TabStop = false;
            this.pictureBoxF.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(534, 661);
            this.Controls.Add(this.pictureBoxF);
            this.Controls.Add(this.pictureBoxExp);
            this.Controls.Add(this.pictureBoxArcsin);
            this.Controls.Add(this.pictureBoxTg);
            this.Controls.Add(this.pictureBoxSin);
            this.Controls.Add(this.pictureBoxCos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArcsin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem системаКоординатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарисоватьОсиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tgxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arcsinxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функцияПоВариантуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикФункцииВChartToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxCos;
        private System.Windows.Forms.PictureBox pictureBoxSin;
        private System.Windows.Forms.PictureBox pictureBoxTg;
        private System.Windows.Forms.PictureBox pictureBoxArcsin;
        private System.Windows.Forms.PictureBox pictureBoxExp;
        private System.Windows.Forms.PictureBox pictureBoxF;
    }
}

