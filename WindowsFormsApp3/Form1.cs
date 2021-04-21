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
        int X; int Y; int W; int H;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                X = Convert.ToInt32(textBox1.Text);
                Y = Convert.ToInt32(textBox2.Text);
                W = Convert.ToInt32(textBox3.Text);
                H = Convert.ToInt32(textBox4.Text);
                Pen pn = new Pen(Color.Black, 3);
                Graphics g = panel1.CreateGraphics();
                g.DrawRectangle(pn, X, Y, W, H);
            }
            else if(comboBox1.SelectedItem.ToString() == "Line")
            {
                X = Convert.ToInt32(textBox1.Text);
                Y = Convert.ToInt32(textBox2.Text);
                W = Convert.ToInt32(textBox3.Text);
                H = Convert.ToInt32(textBox3.Text);
                Pen pn = new Pen(Color.Black, 3);
                Graphics g = panel1.CreateGraphics();
                g.DrawLine(pn, X, Y, W, H);
            }
            else if(comboBox1.SelectedItem.ToString() == "Circle")
            {
                X = Convert.ToInt32(textBox1.Text);
                Y = Convert.ToInt32(textBox2.Text);
                W = Convert.ToInt32(textBox3.Text);
                H = Convert.ToInt32(textBox3.Text);
                Pen pn = new Pen(Color.Black, 3);
                Graphics g = panel1.CreateGraphics();
                g.DrawEllipse(pn, X, Y, W, H);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics clear = panel1.CreateGraphics();
            clear.Clear(Color.White);
        }
    }
}
