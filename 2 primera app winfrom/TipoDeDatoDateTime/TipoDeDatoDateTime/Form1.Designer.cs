namespace TipoDeDatoDateTime
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnDtpick = new System.Windows.Forms.Button();
            this.btnDmcalendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(231, 134);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(323, 369);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(140, 23);
            this.btnFecha.TabIndex = 2;
            this.btnFecha.Text = "Mostrar Fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnDtpick
            // 
            this.btnDtpick.Location = new System.Drawing.Point(572, 62);
            this.btnDtpick.Name = "btnDtpick";
            this.btnDtpick.Size = new System.Drawing.Size(75, 23);
            this.btnDtpick.TabIndex = 3;
            this.btnDtpick.Text = "prueba1";
            this.btnDtpick.UseVisualStyleBackColor = true;
            this.btnDtpick.Click += new System.EventHandler(this.btnDtpick_Click);
            // 
            // btnDmcalendar
            // 
            this.btnDmcalendar.Location = new System.Drawing.Point(572, 134);
            this.btnDmcalendar.Name = "btnDmcalendar";
            this.btnDmcalendar.Size = new System.Drawing.Size(75, 23);
            this.btnDmcalendar.TabIndex = 4;
            this.btnDmcalendar.Text = "prueba2";
            this.btnDmcalendar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDmcalendar);
            this.Controls.Add(this.btnDtpick);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnDtpick;
        private System.Windows.Forms.Button btnDmcalendar;
    }
}

