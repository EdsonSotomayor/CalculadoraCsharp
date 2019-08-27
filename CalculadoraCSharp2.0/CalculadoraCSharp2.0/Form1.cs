using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharp2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x, y,z;
        string op;


        private void One_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void Cero_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (this.Pantalla.Text.Contains('.') == false)
            {
                this.Pantalla.Text = this.Pantalla.Text + ".";
            }
        }

        private void Divi_Click(object sender, EventArgs e)
        {
            op = "/";
            x = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            op = "+";
            x = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            y = double.Parse(Pantalla.Text);
            switch (op)
            {
                case "+":
                    z = x + y;
                    Pantalla.Text = z.ToString();
                    break;
                case "-":
                    z = x - y;
                    Pantalla.Text = z.ToString();
                    break;
                case "/":
                    z = x / y;
                    Pantalla.Text = z.ToString();
                    break;
                case "*":
                    z = x * y;
                    Pantalla.Text = z.ToString();
                    break;
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Count() - 1);
        }

        private void C_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            op = "*";
            x = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            op = "-";
            x = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }
    }
}

