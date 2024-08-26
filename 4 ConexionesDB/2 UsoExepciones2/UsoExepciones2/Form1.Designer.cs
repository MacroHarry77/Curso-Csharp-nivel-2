namespace UsoExepciones2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbresultado = new System.Windows.Forms.Label();
            this.txbx1 = new System.Windows.Forms.TextBox();
            this.txbx2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(263, 209);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(14, 16);
            this.lbresultado.TabIndex = 0;
            this.lbresultado.Text = "=";
            // 
            // txbx1
            // 
            this.txbx1.Location = new System.Drawing.Point(221, 59);
            this.txbx1.Name = "txbx1";
            this.txbx1.Size = new System.Drawing.Size(100, 22);
            this.txbx1.TabIndex = 1;
            // 
            // txbx2
            // 
            this.txbx2.Location = new System.Drawing.Point(221, 113);
            this.txbx2.Name = "txbx2";
            this.txbx2.Size = new System.Drawing.Size(100, 22);
            this.txbx2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbx2);
            this.Controls.Add(this.txbx1);
            this.Controls.Add(this.lbresultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.TextBox txbx1;
        private System.Windows.Forms.TextBox txbx2;
        private System.Windows.Forms.Button button1;
    }
}

