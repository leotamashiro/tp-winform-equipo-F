using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CATALOGO
{
    internal class Articulo
    {
        // Constructor default
        public Articulo(string codigo, string nombre, string descripcion, Marca marca, Categoria categoria, Imagen imagen, decimal precio)
        {}

        // Propiedades del articulo
        public string codigo { get; set; }
        public string nombre{ get; set; }
        public string descripcion{ get; set; }
        public Marca Marca{ get; set; }
        public Categoria Categoria{ get; set; }
        public Imagen imagen { get; set; }
        public decimal precio { get; set; }
        
    }
}
