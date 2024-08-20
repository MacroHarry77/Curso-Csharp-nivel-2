using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipoDeDatoDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha =  DateTime.Now;

            MessageBox.Show("La fecha es: " + fecha.ToString("dddd/MMMM/y"));
            //.AddDays agrega o dias a la fecha y asi junto con los demas Adds...
            //.ToShortDateString muestra solo la fecha, sin la hora
            //.ToShortTimeString solo muestra la hora
        }

        private void btnDtpick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + dateTimePicker1.Value.ToString("dddd /MM /yyyy"));
            
            //Capturar fecha y guardarla
            DateTime fecha1;
            fecha1 = dateTimePicker1.Value;

            // Es mejor trabajar con los datos puros sin pasarlo a ToString,,, Guardada en una variable
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
             
        }
    }
}
