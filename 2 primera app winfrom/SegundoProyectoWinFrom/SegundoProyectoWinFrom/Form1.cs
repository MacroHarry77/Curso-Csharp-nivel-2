using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProyectoWinFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemen = txtElement.Text;
            //listview es una coleccion o funciona como una
            lvtext.Items.Add(elemen);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbbxColor.Items.Add("Rojo");
            CbbxColor.Items.Add("Azul");
            CbbxColor.Items.Add("Verde");
            CbbxColor.Items.Add("Blanco");
            CbbxColor.Items.Add("Negro");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string name = txtElement.Text;
            DateTime fechaN = FechaNacimiento.Value;
            //Operdor ternario
            string vida = chbxVida.Checked == true ? " Le gusta su vida " : " Odia su vida ";
            string estado;
            if (rbtCasado.Checked)
                estado = rbtCasado.Text;
            else if (rbtsoltero.Checked)
                estado = rbtCasado.Text;
            else
                estado = rdtGamer.Text;

            string colorfav = CbbxColor.SelectedItem.ToString();
            string numerofav = NumeroFav.Value.ToString();

            MessageBox.Show(" Nombre: " + name + " Fecha de nacimiento: " + fechaN + vida + " Estado Civil: " + estado + " Color favorito: " + colorfav + " Numero favorito: " + numerofav);
        }
    }
}
 