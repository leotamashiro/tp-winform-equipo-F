using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATALOGO
{
    public partial class DetalleArticulo : Form
    {

        Articulo articulo;
        public DetalleArticulo()
        {
            InitializeComponent();
        }

        private void DetalleArticulo_Load(object sender, EventArgs e)
        {
            codigoInput.Text = articulo.codigo;
            nombreInput.Text = articulo.nombre;
            descInput.Text = articulo.descripcion;
            marcaInput.Text = articulo.Marca.Descripcion.ToString();
            categoriaInput.Text = articulo.Categoria.Descripcion.ToString();
            precioInput.Text = articulo.precio.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void volverListadoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
