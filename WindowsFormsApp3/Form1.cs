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
        int X0; int Y0; int X1; int Y1; int X2; int Y2;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                X0 = Convert.ToInt32(textBox1.Text);
                Y0 = Convert.ToInt32(textBox2.Text);
                X1 = Convert.ToInt32(textBox3.Text);
                Y1 = Convert.ToInt32(textBox4.Text);
                Pen pn = new Pen(Color.Black, 3);
                Graphics g = panel1.CreateGraphics();
                g.DrawRectangle(pn, X0, Y0, X1, Y1);
            }
            else if(comboBox1.SelectedItem.ToString() == "Line")
            {
                X0 = Convert.ToInt32(textBox1.Text);
                Y0 = Convert.ToInt32(textBox2.Text);
                X1 = Convert.ToInt32(textBox3.Text);
                Y1 = Convert.ToInt32(textBox3.Text);
                Pen pn = new Pen(Color.Black, 3);
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
                Pen pn = new Pen(Color.Black, 3);
                Graphics g = panel1.CreateGraphics();
                g.DrawEllipse(pn, X0, Y0, X1, Y1);
            }
            else if(comboBox1.SelectedItem.ToString() == "Triangle")
            {
                textBox5.Visible = true;
                textBox6.Visible = true;

                X0 = Convert.ToInt32(textBox1.Text);
                Y0 = Convert.ToInt32(textBox2.Text);
                X1 = Convert.ToInt32(textBox3.Text);
                Y1 = Convert.ToInt32(textBox4.Text);
                X2 = Convert.ToInt32(textBox5.Text);
                Y2 = Convert.ToInt32(textBox6.Text);
                Pen pn = new Pen(Color.Black, 3);
                Graphics g = panel1.CreateGraphics();
                g.DrawLine(pn, X0, Y0, X1, Y1);
                g.DrawLine(pn, X1, Y1, X2, Y2);
                g.DrawLine(pn, X2, Y2, X0, Y0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics clear = panel1.CreateGraphics();
            clear.Clear(Color.White);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Pen pn = new Pen(Color.Black, 3);
            Graphics g = panel1.CreateGraphics();
            g.DrawEllipse(pn, X0, Y0, X1, Y1);
        }
    }
}
