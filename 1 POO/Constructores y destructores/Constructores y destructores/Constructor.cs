using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_y_destructores
{
    internal class Constructor
    {
        //Permite cargar unos valores iniciales cargarlos y  que no sean modificables 
        //PUBLIC mismonombredelaclase (Puede o no recibir parametros){}
        public Constructor(string color, string material) 
        { 
            //this apuntador que hace referencia a la clase
            this.color = color;
            this.material = material;
        }

        //constructor vacio Sobrecarga de constructor
        public Constructor() { }
        //Destructor poco usado 
         ∼Constructor()
        { 

        }

        //Ejemplo con una botella

        private int capacidad;
        private string color;
        private string material;

    }
}
