using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATALOGO
{
    internal class Marca
    {
        // Propiedades
        private int id;
        private string descripcion;

        // Getters y setters 
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
