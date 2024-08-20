using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioBasico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( tbNombre.Text == "" || tbApelido.Text == "" || tbEdad.Text == "" || tbDireccion.Text == "")
            {
                MessageBox.Show("Porfavor Complete todos los espacios");
            }
            else
            {
                textBox1.Text = "Nombre y Apellido: " + tbNombre.Text + " " + tbApelido.Text + "" +
                    Environment.NewLine + "Edad: " + tbEdad.Text +
                    Environment.NewLine + "Direccion: " + tbDireccion.Text;
            }

            if (tbNombre.Text == "")
            {
                tbNombre.BackColor = Color.Red;
            }else
                tbNombre.BackColor = System.Drawing.SystemColors.Control;

            if (tbApelido.Text == "")
            {
                tbApelido.BackColor = Color.Red;              
            }
            else
                tbApelido.BackColor = System.Drawing.SystemColors.Control;
            if (tbEdad.Text == "")
            {
                tbEdad.BackColor = Color.Red;               
            }
            else
                tbEdad.BackColor = System.Drawing.SystemColors.Control;
            if (tbDireccion.Text == "")
            {
                tbDireccion.BackColor = Color.Red;               
            }
            else
                tbDireccion.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Uso de ascii para permitir entrada de solo numeros y el de borrar
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
