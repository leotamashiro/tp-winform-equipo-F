using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CATALOGO
{
    public class Articulo
    {

        // Propiedades del articulo
        public int ID { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public Marca MARCA { get; set; }
        public Categoria CATEGORIA { get; set; }
        public Imagen IMAGEN { get; set; }
        public decimal PRECIO { get; set; }

    }
}
