using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraConexionDb
{
    internal class Pokemon
    {
        //propiedades que voy a traer de la base de datos
        public int Numero {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion  { get; set; }
        public int idtipo { get; set; }
    }
}
