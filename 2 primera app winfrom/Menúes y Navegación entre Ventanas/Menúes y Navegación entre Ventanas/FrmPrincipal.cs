using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menúes_y_Navegación_entre_Ventanas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Navegar a otras ventanas ]
            // instancia del objeto Form1 que es nuestra segunda ventana 
            Form1 ventana = new Form1();// se crea un objeto de tipo form que yo puedo utilizar
            // ventana.Show(); //mostrar ventana
            // otra forma de mostrar la ventana
            ventana.ShowDialog();// esta solo permite que halla una ventana a la vez
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)//intera por la colecion de formularios "abiertos"
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una ventana, termine de trabajar con la ventana existente Gracias");
                    return;
                }
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
