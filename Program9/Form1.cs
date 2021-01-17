using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Program9
{
    public partial class Form1 : Form
    {
        Graphics Graph1;
        Double x, y, ox, oy;
        Pen Pen1 = new Pen(Color.Red, 1);
        Pen Pen2 = new Pen(Color.Black, 2);
        Pen Pen3 = new Pen(Color.Cyan, 3);
        Pen Pen4 = new Pen(Color.Brown, 2);
        Pen Pen5 = new Pen(Color.Fuchsia, 2);

        Font drawFont = new Font("Arial", 12);

        SolidBrush Brush1 = new SolidBrush(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void нарисоватьОсиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph1 = pictureBox1.CreateGraphics();
            int i = 0;
            Graph1.Clear(Color.White);
            for (i = -250; i <= 250; i += 50)
                Graph1.DrawString(Convert.ToString(i), drawFont, Brush1, i + 250, 210);
            for (i = -200; i <= 200; i += 50)
                Graph1.DrawString(Convert.ToString(i), drawFont, Brush1, 260, 200 - i);
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -200);
            Graph1.DrawLine(Pen1, -250, 0, 250, 0);
            Graph1.DrawLine(Pen1, 0, -200, 0, 200);
            for (i = -250; i <= 250; i += 50)
                Graph1.DrawEllipse(Pen3, i, 0, 1, 1);
            for (i = -200; i <= 200; i += 50)
                Graph1.DrawEllipse(Pen3, 0, i, 1, 1);
            Graph1.Dispose();
        }

        private void cosxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxCos.Visible = true;
            pictureBoxSin.Visible = false;
            pictureBoxTg.Visible = false;
            pictureBoxArcsin.Visible = false;
            pictureBoxExp.Visible = false;
            pictureBoxF.Visible = false;

            Graphics Graph1 = pictureBox1.CreateGraphics();
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -200);
            ox = Convert.ToDouble(numericUpDown1.Value);
            oy = Convert.ToDouble(numericUpDown2.Value);
            x = -250;
            while (x <= 250)
            {
                y = oy * Math.Cos(x / ox);
                Graph1.DrawRectangle(Pen1, (Int32)x, (Int32)y, 1, 1);
                x = x + 0.01;
            }

        }

        private void sinxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxCos.Visible = false;
            pictureBoxSin.Visible = true;
            pictureBoxTg.Visible = false;
            pictureBoxArcsin.Visible = false;
            pictureBoxExp.Visible = false;
            pictureBoxF.Visible = false;

            ox = Convert.ToDouble(numericUpDown1.Value);
            oy = Convert.ToDouble(numericUpDown2.Value);
            Graphics Graph1 = pictureBox1.CreateGraphics();
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -200);
            x = -250;
            while (x <= 250)
            {
                y = oy * Math.Sin(x / ox);
                Graph1.DrawEllipse(Pen2, (Int32)x, (Int32)y, 1, 1);
                x = x + 0.01;
            }
        }

        private void tgxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxCos.Visible = false;
            pictureBoxSin.Visible = false;
            pictureBoxTg.Visible = true;
            pictureBoxArcsin.Visible = false;
            pictureBoxExp.Visible = false;
            pictureBoxF.Visible = false;

            Graphics Graph1 = pictureBox1.CreateGraphics();
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -200);
            ox = Convert.ToDouble(numericUpDown1.Value);
            oy = Convert.ToDouble(numericUpDown2.Value);
            x = -250;
            while (x <= 250)
            {
                y = oy * Math.Tan(x / ox);
                Graph1.DrawEllipse(Pen3, (Int32)x, (Int32)y, 1, 1);
                x = x + 0.01;
            }


        }
        private void arcsinxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxCos.Visible = false;
            pictureBoxSin.Visible = false;
            pictureBoxTg.Visible = false;
            pictureBoxArcsin.Visible = true;
            pictureBoxExp.Visible = false;
            pictureBoxF.Visible = false;

            colorDialog1.ShowDialog();
            Pen2.Color = colorDialog1.Color;
            ox = Convert.ToDouble(numericUpDown1.Value);
            oy = Convert.ToDouble(numericUpDown2.Value);
            Graphics Graph1 = pictureBox1.CreateGraphics();
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -200);
            x = -1;
            while (x <= 1)
            {
                y = oy * Math.Asin(x / ox);
                Graph1.DrawEllipse(Pen2, (float)x, (float)y, 1, 1);
                x = x + 0.01;
            }
        }

        private void expxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxCos.Visible = false;
            pictureBoxSin.Visible = false;
            pictureBoxTg.Visible = false;
            pictureBoxArcsin.Visible = false;
            pictureBoxExp.Visible = true;
            pictureBoxF.Visible = false;

            colorDialog1.ShowDialog();
            Pen2.Color = colorDialog1.Color;
            ox = Convert.ToDouble(numericUpDown1.Value);
            oy = Convert.ToDouble(numericUpDown2.Value);
            Graphics Graph1 = pictureBox1.CreateGraphics();
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -200);
            x = -250;
            while (x <= 100)
            {
                y = Math.Exp(x / ox);
                Graph1.DrawEllipse(Pen2, (float)x, (float)y, 1, 1);
                x = x + 0.01;
            }
        }

        private void функцияПоВариантуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxCos.Visible = false;
            pictureBoxSin.Visible = false;
            pictureBoxTg.Visible = false;
            pictureBoxArcsin.Visible = false;
            pictureBoxExp.Visible = false;
            pictureBoxF.Visible = true;

            colorDialog1.ShowDialog();
            Pen2.Color = colorDialog1.Color;
            ox = Convert.ToDouble(numericUpDown1.Value);
            oy = Convert.ToDouble(numericUpDown2.Value);
            Graphics Graph1 = pictureBox1.CreateGraphics();
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -200);
            x = -250;
            while (x <= 250)
            {
                y = 700.0 / 33.0 * Math.Sqrt((4 * Math.Pow(Math.Cos(x), 2)) + (4 * Math.Cos(x)) + 8);
                Graph1.DrawEllipse(Pen2, (float)x, (float)y, 1, 1);
                x = x + 0.1;
            }
        }
        private void графикФункцииВChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (x = -25; x <= 25; x += 0.02)
            {
                y = 700.0 / 33.0 * Math.Sqrt((4 * Math.Pow(Math.Cos(x), 2)) + (4 * Math.Cos(x)) + 8);
                chart1.Series[0].Points.AddXY(x, y);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}