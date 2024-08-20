namespace TercerProyectoWin
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
            this.lvContact = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.lvlistaContactos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvContact
            // 
            this.lvContact.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvContact.HideSelection = false;
            this.lvContact.Location = new System.Drawing.Point(247, 57);
            this.lvContact.Name = "lvContact";
            this.lvContact.Size = new System.Drawing.Size(187, 244);
            this.lvContact.TabIndex = 0;
            this.lvContact.UseCompatibleStateImageBehavior = false;
            this.lvContact.View = System.Windows.Forms.View.List;
            this.lvContact.SelectedIndexChanged += new System.EventHandler(this.lvContact_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(102, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(102, 188);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(102, 233);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(37, 72);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(59, 16);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(102, 72);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 22);
            this.txtbNombre.TabIndex = 5;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(37, 111);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(64, 16);
            this.lbTelefono.TabIndex = 6;
            this.lbTelefono.Text = "Telefono:";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(102, 105);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(100, 22);
            this.txbTelefono.TabIndex = 7;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(68, 278);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(152, 23);
            this.btnlist.TabIndex = 8;
            this.btnlist.Text = "lista de contactos";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // lvlistaContactos
            // 
            this.lvlistaContactos.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvlistaContactos.HideSelection = false;
            this.lvlistaContactos.Location = new System.Drawing.Point(440, 57);
            this.lvlistaContactos.Name = "lvlistaContactos";
            this.lvlistaContactos.Size = new System.Drawing.Size(239, 244);
            this.lvlistaContactos.TabIndex = 9;
            this.lvlistaContactos.UseCompatibleStateImageBehavior = false;
            this.lvlistaContactos.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvlistaContactos);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvContact);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvContact;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.ListView lvlistaContactos;
    }
}

