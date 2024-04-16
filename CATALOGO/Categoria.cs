using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATALOGO
{
    internal class Categoria
    {
        // Propiedades
        private int id;
        private string nombre;

        // Getters y setters 
        public int Id {
            get { return id; } 
            set {  id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
