using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMemoriaWinfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string valor1;
        string valor2;     
        private void UpdateButtonState(ref Button btn1, ref Button btn2, ref string valor1, ref string valor2,ref string originaltext)
        {
            
            if (string.IsNullOrWhiteSpace(btn1.Text))
            {
                if (string.IsNullOrWhiteSpace(valor1))
                {
                    btn1.Text = originaltext;
                    btn2 = btn1;
                    valor1 = originaltext;
                    return;
                }
                else
                {
                    btn1.Text = originaltext;
                    valor2 = originaltext;
                }

                if (valor2 == valor1)
                {
                    btn1.Text = "#";
                    btn2.Text = "#";
                    valor1 = string.Empty;
                    valor2 = string.Empty;
                }
                else
                {
                    btn1.Text = string.Empty;
                    btn2.Text = string.Empty;
                    valor1 = string.Empty;
                    valor2 = string.Empty;
                }
            }
        }
 
        Button btn1 = new Button();
        Button btn2 = new Button();
        private void btnT1_Click(object sender, EventArgs e)
        {
            
            btn1 = sender as Button;
            string OriginalText = "1";

            UpdateButtonState(ref btn1, ref btn2, ref  valor1, ref  valor2,ref OriginalText);
        }
        
        private void btnT2_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "2";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "1";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "2";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "0";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT6_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "3";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT7_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "4";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT8_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "3";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT9_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "4";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT10_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "5";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT15_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "6";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT14_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "5";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT13_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "6";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT12_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "7";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        private void btnT11_Click(object sender, EventArgs e)
        {
            btn1 = sender as Button;
            string OriginalText = "7";

            UpdateButtonState(ref btn1, ref btn2, ref valor1, ref valor2, ref OriginalText);
        }

        
    }
}
