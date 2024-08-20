using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form1 : Form
    {
        private int secondsElapsed;
        public Form1()
        {
            InitializeComponent();        
        }
        
        private void button1_Click(object sender, EventArgs e)//Agregar tiempo en el label
        {
            string tiempoTexto = txbTime.Text;

            // Tratar de parsear el tiempo ingresado en el TextBox
            if (TimeSpan.TryParse(tiempoTexto, out TimeSpan tiempoInicial))
            {
                // Convertir el tiempo inicial en segundos
                secondsElapsed = (int)tiempoInicial.TotalSeconds;

                // Mostrar el tiempo inicial en el Label
                lbtime1.Text = tiempoInicial.ToString(@"hh\:mm\:ss"); 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el tiempo en formato hh:mm:ss");
            }
        }
      
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer2.Stop();

            timer1 = new Timer();
            timer1.Interval = 1000; // Intervalo de 1 segundo (1000 ms)

            timer1.Tick += timer1_Tick;

            // Iniciar el temporizador
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {          
            if (secondsElapsed > 0)
            {
                secondsElapsed--;
            }
            else 
            {
                timer1.Stop();
                MessageBox.Show("!Temporizador finalizado!");
            }
            TimeSpan timeSpan = TimeSpan.FromSeconds(secondsElapsed);//permite formatear el tiempo en diferentes formatos
            //@"hh\:mm\:ss" para mostrar las horas, minutos y segundos con ceros a la izquierda.
            //"hh": Horas con dos dígitos.
            //"mm": Minutos con dos dígitos.
            //"ss": Segundos con dos dígitos.
            // Actualizar el texto del Label para mostrar el tiempo transcurrido.
            lbtime1.Text =  timeSpan.ToString(@"hh\:mm\:ss");       
        }
        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            TimeSpan timeSpan = TimeSpan.FromSeconds(secondsElapsed);
            lbtime1.Text = timeSpan.ToString(@"hh\:mm\:ss");
        }
    }
}
