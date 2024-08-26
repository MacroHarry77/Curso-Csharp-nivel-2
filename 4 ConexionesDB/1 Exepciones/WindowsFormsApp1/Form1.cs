using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            //Capturar las exepciones
            try
            {
                a = int.Parse(txbx1.Text);
                b = int.Parse(txbx2.Text);
                r = a / b;

                lbresultado.Text = r.ToString();
            }
            catch (FormatException ex)//Exepction es por decir el padre de las Exepciones que contiene toda las exepciones; FormatException
            {
                MessageBox.Show("Por favor ingrese solo numeros ");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por 0 ");
            }

        }
    }
}
