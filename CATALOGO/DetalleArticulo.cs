using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
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
        private DataGridView dataGridPrincipal;
        private int _id;
        private string[] urls;
        private int indiceImagenActual;
        public DetalleArticulo(int id, DataGridView gridTable)
        {
            InitializeComponent();
            _id = id;
            dataGridPrincipal = gridTable;
        }

        ArticuloService articuloService = new ArticuloService();

        private async void DetalleArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                _articulo = articuloService.listarArticuloXID(_id);
                if (_articulo != null)
                {
                    codigoInput.Text = _articulo.CODIGO ?? string.Empty;
                    nombreInput.Text = _articulo.NOMBRE ?? string.Empty;
                    descInput.Text = _articulo.DESCRIPCION ?? string.Empty;
                    marcaInput.Text = _articulo.MARCA?.Descripcion ?? string.Empty;
                    categoriaInput.Text = _articulo.CATEGORIA?.Descripcion ?? string.Empty;
                    precioInput.Text = _articulo.PRECIO != 0 ? string.Format("{0:0.00}", _articulo.PRECIO) : string.Empty;

                    if (_articulo.IMAGEN != null && !string.IsNullOrEmpty(_articulo.IMAGEN.Url))
                    {
                        urls = _articulo.IMAGEN.Url.Split(',');
                        await CargarImagen(urls[0]);

                        indiceImagenActual = 0;

                        if (urls.Length <= 1)
                        {
                            SiguienteImagenButton.Visible = false;
                            AnteriorImagenButton.Visible = false;
                        }
                        else
                        {
                            SiguienteImagenButton.Visible = true;
                            AnteriorImagenButton.Visible = true;
                        }
                    }
                    else
                    {
                        SiguienteImagenButton.Visible = false;
                        AnteriorImagenButton.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el artículo con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                imagenDetalle.Load(url.Trim());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la imagen: " + ex.Message);
                imagenDetalle.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
            }
        }

        private async void SiguienteImagenButton_Click(object sender, EventArgs e)
        {
            indiceImagenActual++;

            if (indiceImagenActual >= urls.Length)
            {
                indiceImagenActual = 0;
            }

            await CargarImagen(urls[indiceImagenActual]);
        }

        private async void AnteriorImagenButton_Click(object sender, EventArgs e)
        {
            indiceImagenActual--;

            if (indiceImagenActual < 0)
            {
                indiceImagenActual = urls.Length - 1;
            }

            await CargarImagen(urls[indiceImagenActual]);
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
                    List<Articulo> listaActualizada = articuloService.ListarArticulos();
                    dataGridPrincipal.DataSource = listaActualizada;

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
