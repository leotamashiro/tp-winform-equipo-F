using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using dominio;
using negocio;

namespace CATALOGO
{
    public partial class DetalleArticulo : Form
    {
        private Articulo _articulo;
        private int _id;
        public DetalleArticulo(int id)
        {
            InitializeComponent();
            _id = id;
        }

        ArticuloService articuloService = new ArticuloService();

        private async void DetalleArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                _articulo = articuloService.listarArticuloXID(_id);
                codigoInput.Text = _articulo.CODIGO;
                nombreInput.Text = _articulo.NOMBRE;
                descInput.Text = _articulo.DESCRIPCION;
                marcaInput.Text = _articulo.MARCA.Descripcion.ToString();
                categoriaInput.Text = _articulo.CATEGORIA.Descripcion.ToString();
                precioInput.Text = string.Format("{0:0.00}", _articulo.PRECIO);
                CargarImagen(_articulo.IMAGEN.Url.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task CargarImagen(string url)
        {
            try
            {
                imagenDetalle.Load(url);
            }
            catch (Exception ex)
            {
                imagenDetalle.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
            }
        }

        private void volverListadoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarArtBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este artículo?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    articuloService.eliminarArticulo(_articulo.ID);
                    MessageBox.Show("Articulo eliminado correctamente!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el artículo: " + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
