using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTextoBasico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string copiar;
        string cortar;
        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rtchTex.SelectedText.Length > 0)
            {
                copiar = rtchTex.SelectedText;
            }else
                copiar = rtchTex.Text;
        }

        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int posicionCursor = rtchTex.SelectionStart;
            rtchTex.Text = rtchTex.Text.Insert(posicionCursor, copiar);
            rtchTex.SelectionStart = posicionCursor + copiar.Length;
        }

        private void cortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rtchTex.SelectedText.Length > 0)
            {
                copiar = rtchTex.SelectedText;
                rtchTex.Text = rtchTex.Text.Remove(rtchTex.SelectionStart, rtchTex.SelectionLength);
            }
            else
            { 
                copiar = rtchTex.Text;
                rtchTex.Clear();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // Carpeta inicial
                openFileDialog.Filter = "Archivos de Texto (*.txt)|*.txt|Todos Los Archivos (*.*)|*.*"; // Filtros
                openFileDialog.FilterIndex = 1; // Índice del filtro seleccionado
                openFileDialog.RestoreDirectory = true; // Restaurar el directorio anterior

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtén la ruta completa del archivo seleccionado
                    string filePath = openFileDialog.FileName;

                    // Leer el archivo (opcional)
                    string fileContent = System.IO.File.ReadAllText(filePath);
                    rtchTex.Text = fileContent;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\"; // Carpeta inicial
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"; // Filtros
                saveFileDialog.FilterIndex = 1; // Índice del filtro seleccionado
                saveFileDialog.RestoreDirectory = true; // Restaurar el directorio anterior

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtén la ruta completa del archivo seleccionado
                    string filePath = saveFileDialog.FileName;

                    // Guardar el archivo (opcional)
                    System.IO.File.WriteAllText(filePath, rtchTex.Text);
                    MessageBox.Show("Archivo guardado con éxito", "Guardar Archivo");
                }
            }
        }
    }
}
