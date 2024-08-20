using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TercerProyectoWin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        List<string> Nombre = new List<string>();
        List<string> Telefono = new List<string>();
        int posicion = -1;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombre.Text;
            string tel = txbTelefono.Text;

            if (posicion >= 0) 
            {
                Nombre[posicion] = nombre;
                Telefono[posicion] = tel;
                lvContact.Items[posicion].Text = nombre;
                posicion = -1;
            }
            else
            {
                 Nombre.Add(nombre);
                 Telefono.Add(tel);
                 lvContact.Items.Add(nombre);
            }
                
            txtbNombre.Clear();
            txbTelefono.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvContact.SelectedIndices.Count > 0)
            {
                // Obtén el índice del primer elemento seleccionado
                int selectedIndex = lvContact.SelectedIndices[0];
                lvContact.Items.RemoveAt(selectedIndex);
                Nombre.RemoveAt(selectedIndex);
                Telefono.RemoveAt(selectedIndex);
            }

        }
        private void lvContact_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvContact.SelectedIndices.Count > 0)
            {  
                // Obtén el índice del primer elemento seleccionado
                int selectedIndex = lvContact.SelectedIndices[0];
                txtbNombre.Text = Nombre[selectedIndex];
                txbTelefono.Text = Telefono[selectedIndex];
                posicion = selectedIndex;

                //lvContact.Items.RemoveAt((int)selectedIndex);
                //Nombre.RemoveAt(selectedIndex);
                //Telefono.RemoveAt(selectedIndex);
            }
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            lvlistaContactos.Clear();

            lvlistaContactos.Columns.Add("Nombre" ,80);
            lvlistaContactos.Columns.Add("Telefono", 100);

            for (int i = 0; i < Nombre.Count; i++)
            {
                // Crea un nuevo ListViewItem con el nombre
                ListViewItem item = new ListViewItem(Nombre[i]);

                // Agrega el teléfono como subitem
                item.SubItems.Add(Telefono[i]);

                // Agrega el nuevo elemento al ListView
                lvlistaContactos.Items.Add(item);
            }
        }
    }
}
