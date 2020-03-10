using System;
using System.Windows.Forms;

namespace FORCES_main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Read values from textboxes
            double Force = double.Parse(textBox1.Text);
            double Angle = double.Parse(textBox2.Text);

            //read values from textboxes
            try
            {
                Force = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Type a number in the force box");
                Force = 0.0;
            }

            try
            {
                Angle = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Type a number in the angle box");
                Angle = 0.0;
            }
            
            //caluculate Fx and Fy
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            //put values for Fx and Fy in labels
            label1.Text = "Fx = " + Fx + "N";
            label2.Text = "Fy = " + Fy + "N";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

