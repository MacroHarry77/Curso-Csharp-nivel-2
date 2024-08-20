using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyectoWINFORM
{
    public partial class Form1 : Form
    {
        //Constructor 
        public Form1()
        {
            //Funcion 
            InitializeComponent();
        }
        int V1;
        int V2;
        int R;
        string Op;
        private void Suma_Click(object sender, EventArgs e)
        {
            //int suma = int.Parse(Texto.Text);
            V1 = int.Parse(Texto.Text);
            label1.Text = V1.ToString();
            Op = Suma.Text;

        }
        private void menos_Click(object sender, EventArgs e)
        {
            V1 = int.Parse(Texto.Text);
            label1.Text = V1.ToString();
            Op = menos.Text;

        }
        private void Por_Click(object sender, EventArgs e)
        {
            V1 = int.Parse(Texto.Text);
            label1.Text = V1.ToString();
            Op = Por.Text;
        }
        private void button1_Click_1(object sender, EventArgs e)//Igual
        {
            if (Op == "+")
            {
                V2 = int.Parse(Texto.Text);
                Texto.Clear();
                R = V1 + V2;
                Texto.Text = R.ToString();
            } else if (Op == "-")
            {
                V2 = int.Parse(Texto.Text);
                Texto.Clear();
                R = V1 - V2;
                Texto.Text = R.ToString();
            }
            else if (Op == "*")
            {
                V2 = int.Parse(Texto.Text);
                Texto.Clear();
                R = V1 * V2;
                Texto.Text = R.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to this event xd ");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // MessageBox.Show("Gracias por salir ");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Mundo en interfaz Grafica");
            //string texto = Texto.Text;
            //label1.Text = "Hola " + texto;
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += Boton1.Text;
        }
        private void Boton2_Click(object sender, EventArgs e)
        {
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += Boton2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (label1.Text == Texto.Text)
            {
                Texto.Clear();
            }
            Texto.Text += button0.Text;
        }
    }
}
