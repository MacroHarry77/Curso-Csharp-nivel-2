using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Botella
    {
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;//ml
            cantidadActual = 0;
        }

        private string color;
        private string material;
        private int capacidad;
        private int cantidadActual;

        public int Capacidad { get { return capacidad; } }
        public int CantidadActual { get { return cantidadActual; } }


                //metodo recarga la botella de 0 a 100 y devuelve el costo
                //50 por cada 100

                //Metodo
                public float recargar()
                {
                    if (cantidadActual > 0)
                    {
                        int dif = 100 - cantidadActual;
                        float monto = dif * 50 / 100;
                        cantidadActual += dif;
                        return monto;
                    }

                    cantidadActual = 100;
                    return 50;
                }
    }
}
    

        
    

