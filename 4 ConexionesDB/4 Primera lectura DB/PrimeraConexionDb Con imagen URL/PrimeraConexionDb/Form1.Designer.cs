namespace PrimeraConexionDb
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
            this.dtgPokemons = new System.Windows.Forms.DataGridView();
            this.pbxPokemons = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPokemons
            // 
            this.dtgPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPokemons.Location = new System.Drawing.Point(12, 12);
            this.dtgPokemons.Name = "dtgPokemons";
            this.dtgPokemons.RowHeadersWidth = 51;
            this.dtgPokemons.RowTemplate.Height = 24;
            this.dtgPokemons.Size = new System.Drawing.Size(776, 426);
            this.dtgPokemons.TabIndex = 0;
            this.dtgPokemons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPokemons_CellContentClick);
            this.dtgPokemons.SelectionChanged += new System.EventHandler(this.dtgPokemons_SelectionChanged);
            // 
            // pbxPokemons
            // 
            this.pbxPokemons.Location = new System.Drawing.Point(827, 89);
            this.pbxPokemons.Name = "pbxPokemons";
            this.pbxPokemons.Size = new System.Drawing.Size(503, 319);
            this.pbxPokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemons.TabIndex = 1;
            this.pbxPokemons.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 510);
            this.Controls.Add(this.pbxPokemons);
            this.Controls.Add(this.dtgPokemons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPokemons;
        private System.Windows.Forms.PictureBox pbxPokemons;
    }
}

