using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int X0; int Y0; int X1; int Y1;
        int a; int b; int c; int d; int f; int h;
        Image image;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Line")
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Circle")
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(colorDialog1.Color, trackBar1.Value);
            if (comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                X0 = Convert.ToInt32(textBox1.Text);
                Y0 = Convert.ToInt32(textBox2.Text);
                X1 = Convert.ToInt32(textBox3.Text);
                Y1 = Convert.ToInt32(textBox4.Text);
                Graphics g = panel1.CreateGraphics();
                g.DrawRectangle(pn, X0, Y0, X1, Y1);
            }
            else if(comboBox1.SelectedItem.ToString() == "Line")
            {
                X0 = Convert.ToInt32(textBox1.Text);
                Y0 = Convert.ToInt32(textBox2.Text);
                X1 = Convert.ToInt32(textBox3.Text);
                Y1 = Convert.ToInt32(textBox3.Text);
                Graphics g = panel1.CreateGraphics();
                g.DrawLine(pn, X0, Y0, X1, Y1);
            }
            else if(comboBox1.SelectedItem.ToString() == "Circle")
            {
                textBox5.Visible = false;
                textBox6.Visible = false;

                X0 = Convert.ToInt32(textBox1.Text);
                Y0 = Convert.ToInt32(textBox2.Text);
                X1 = Convert.ToInt32(textBox3.Text);
                Y1 = Convert.ToInt32(textBox3.Text);
                Graphics g = panel1.CreateGraphics();
                g.DrawEllipse(pn, X0, Y0, X1, Y1);
            }
            else if(comboBox1.SelectedItem.ToString() == "Triangle")
            {
                textBox5.Visible = true;
                textBox6.Visible = true;

                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                c = Convert.ToInt32(textBox3.Text);
                d = Convert.ToInt32(textBox4.Text);
                f = Convert.ToInt32(textBox5.Text);
                h = Convert.ToInt32(textBox6.Text);
                Graphics g = panel1.CreateGraphics();
                g.DrawLine(pn, a, b, c, d);
                g.DrawLine(pn, c, d, f, h);
                g.DrawLine(pn, f, h, a, b);
                
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Graphics clear = panel1.CreateGraphics();
            clear.Clear(Color.White);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(this.Size.Width, this.Size.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(this.Location, new Point(0, 0), this.Size);
            b.Save("C:\\games\\test.png");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Файлы изображений|*.bmp;*.png;*.jpg";
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                image = Image.FromFile(openDialog.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения картинки");
                return;
            }

            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = image.Size;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (image == null)
                return;
            e.Graphics.DrawImage(image, panel1.AutoScrollPosition.X, panel1.AutoScrollPosition.Y, image.Size.Width, image.Size.Height);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
