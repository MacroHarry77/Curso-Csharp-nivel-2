using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoExepciones2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;
            
            try
            {
                resultado = calcular();
                lbresultado.Text = " = " + resultado;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DESCONOCIDO...");
                //throw lanzar exepciones
            }
            //finally
            //{
                //el finally se va a ejecutar si o si tras finalizar o el try o el catch
                // AQUI Se van a escribir las instruciones que si o si necesito que se ejecuten
            //}
        } 
        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txbx1.Text);
                b = int.Parse(txbx2.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {
                //este metodo esta preparado para que, si todo funciono bien devuelva un 1(return 1) o
                //si algo funciono mal devuelva una exepcion.
                throw ex;//Devuelve una exepcion o devuelve un resultado
            }
        }
    }
}
