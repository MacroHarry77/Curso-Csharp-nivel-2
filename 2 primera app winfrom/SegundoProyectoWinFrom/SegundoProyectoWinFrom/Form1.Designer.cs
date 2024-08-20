namespace SegundoProyectoWinFrom
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.lvtext = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaNaci = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.chbxVida = new System.Windows.Forms.CheckBox();
            this.FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Perfil = new System.Windows.Forms.Label();
            this.rbtsoltero = new System.Windows.Forms.RadioButton();
            this.rbtCasado = new System.Windows.Forms.RadioButton();
            this.rdtGamer = new System.Windows.Forms.RadioButton();
            this.grbxEstadoC = new System.Windows.Forms.GroupBox();
            this.lblColorF = new System.Windows.Forms.Label();
            this.CbbxColor = new System.Windows.Forms.ComboBox();
            this.NumeroFav = new System.Windows.Forms.NumericUpDown();
            this.numFav = new System.Windows.Forms.Label();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.grbxEstadoC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFav)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(315, 470);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(197, 103);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(140, 22);
            this.txtElement.TabIndex = 1;
            // 
            // lvtext
            // 
            this.lvtext.HideSelection = false;
            this.lvtext.Location = new System.Drawing.Point(102, 470);
            this.lvtext.Name = "lvtext";
            this.lvtext.Size = new System.Drawing.Size(207, 55);
            this.lvtext.TabIndex = 2;
            this.lvtext.UseCompatibleStateImageBehavior = false;
            this.lvtext.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // lblFechaNaci
            // 
            this.lblFechaNaci.AutoSize = true;
            this.lblFechaNaci.Location = new System.Drawing.Point(72, 148);
            this.lblFechaNaci.Name = "lblFechaNaci";
            this.lblFechaNaci.Size = new System.Drawing.Size(119, 16);
            this.lblFechaNaci.TabIndex = 4;
            this.lblFechaNaci.Text = "Fecha Nacimiento:";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(102, 531);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(140, 22);
            this.txt.TabIndex = 5;
            // 
            // chbxVida
            // 
            this.chbxVida.AutoSize = true;
            this.chbxVida.Location = new System.Drawing.Point(197, 184);
            this.chbxVida.Name = "chbxVida";
            this.chbxVida.Size = new System.Drawing.Size(131, 20);
            this.chbxVida.TabIndex = 6;
            this.chbxVida.Text = "Te gusta tu vida?";
            this.chbxVida.UseVisualStyleBackColor = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.Location = new System.Drawing.Point(197, 148);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.FechaNacimiento.TabIndex = 7;
            // 
            // Perfil
            // 
            this.Perfil.AutoSize = true;
            this.Perfil.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfil.Location = new System.Drawing.Point(102, 27);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(180, 40);
            this.Perfil.TabIndex = 8;
            this.Perfil.Text = "Perfil Pesonal";
            // 
            // rbtsoltero
            // 
            this.rbtsoltero.AutoSize = true;
            this.rbtsoltero.Checked = true;
            this.rbtsoltero.Location = new System.Drawing.Point(34, 47);
            this.rbtsoltero.Name = "rbtsoltero";
            this.rbtsoltero.Size = new System.Drawing.Size(71, 20);
            this.rbtsoltero.TabIndex = 9;
            this.rbtsoltero.TabStop = true;
            this.rbtsoltero.Text = "Soltero";
            this.rbtsoltero.UseVisualStyleBackColor = true;
            // 
            // rbtCasado
            // 
            this.rbtCasado.AutoSize = true;
            this.rbtCasado.Location = new System.Drawing.Point(143, 47);
            this.rbtCasado.Name = "rbtCasado";
            this.rbtCasado.Size = new System.Drawing.Size(76, 20);
            this.rbtCasado.TabIndex = 10;
            this.rbtCasado.TabStop = true;
            this.rbtCasado.Text = "Casado";
            this.rbtCasado.UseVisualStyleBackColor = true;
            // 
            // rdtGamer
            // 
            this.rdtGamer.AutoSize = true;
            this.rdtGamer.Location = new System.Drawing.Point(252, 47);
            this.rdtGamer.Name = "rdtGamer";
            this.rdtGamer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdtGamer.Size = new System.Drawing.Size(69, 20);
            this.rdtGamer.TabIndex = 11;
            this.rdtGamer.Text = "Gamer";
            this.rdtGamer.UseVisualStyleBackColor = true;
            // 
            // grbxEstadoC
            // 
            this.grbxEstadoC.Controls.Add(this.rbtsoltero);
            this.grbxEstadoC.Controls.Add(this.rdtGamer);
            this.grbxEstadoC.Controls.Add(this.rbtCasado);
            this.grbxEstadoC.Location = new System.Drawing.Point(109, 210);
            this.grbxEstadoC.Name = "grbxEstadoC";
            this.grbxEstadoC.Size = new System.Drawing.Size(374, 100);
            this.grbxEstadoC.TabIndex = 12;
            this.grbxEstadoC.TabStop = false;
            this.grbxEstadoC.Text = "Estado Civil";
            // 
            // lblColorF
            // 
            this.lblColorF.AutoSize = true;
            this.lblColorF.Location = new System.Drawing.Point(126, 324);
            this.lblColorF.Name = "lblColorF";
            this.lblColorF.Size = new System.Drawing.Size(68, 16);
            this.lblColorF.TabIndex = 13;
            this.lblColorF.Text = "Color Fav:";
            // 
            // CbbxColor
            // 
            this.CbbxColor.FormattingEnabled = true;
            this.CbbxColor.Location = new System.Drawing.Point(207, 321);
            this.CbbxColor.Name = "CbbxColor";
            this.CbbxColor.Size = new System.Drawing.Size(121, 24);
            this.CbbxColor.TabIndex = 14;
            // 
            // NumeroFav
            // 
            this.NumeroFav.Location = new System.Drawing.Point(207, 350);
            this.NumeroFav.Name = "NumeroFav";
            this.NumeroFav.Size = new System.Drawing.Size(120, 22);
            this.NumeroFav.TabIndex = 15;
            // 
            // numFav
            // 
            this.numFav.AutoSize = true;
            this.numFav.Location = new System.Drawing.Point(110, 352);
            this.numFav.Name = "numFav";
            this.numFav.Size = new System.Drawing.Size(84, 16);
            this.numFav.TabIndex = 16;
            this.numFav.Text = "Numero Fav:";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(197, 404);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnPerfil.TabIndex = 17;
            this.btnPerfil.Text = "Ver perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.numFav);
            this.Controls.Add(this.NumeroFav);
            this.Controls.Add(this.CbbxColor);
            this.Controls.Add(this.lblColorF);
            this.Controls.Add(this.grbxEstadoC);
            this.Controls.Add(this.Perfil);
            this.Controls.Add(this.FechaNacimiento);
            this.Controls.Add(this.chbxVida);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lblFechaNaci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvtext);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbxEstadoC.ResumeLayout(false);
            this.grbxEstadoC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.ListView lvtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaNaci;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.CheckBox chbxVida;
        private System.Windows.Forms.DateTimePicker FechaNacimiento;
        private System.Windows.Forms.Label Perfil;
        private System.Windows.Forms.RadioButton rbtsoltero;
        private System.Windows.Forms.RadioButton rbtCasado;
        private System.Windows.Forms.RadioButton rdtGamer;
        private System.Windows.Forms.GroupBox grbxEstadoC;
        private System.Windows.Forms.Label lblColorF;
        private System.Windows.Forms.ComboBox CbbxColor;
        private System.Windows.Forms.NumericUpDown NumeroFav;
        private System.Windows.Forms.Label numFav;
        private System.Windows.Forms.Button btnPerfil;
    }
}

