using dominio;
using negocio;
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
    public partial class AgregarImagen : Form
    {
        ArticuloService articuloService;
        Articulo _articulo;
        DataGridView _dataGridView;
        public AgregarImagen(Articulo articulo, DataGridView dataGridView)
        {
            InitializeComponent();
            _articulo = articulo;
            _dataGridView = dataGridView;
            articuloService = new ArticuloService();
        }



        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AgregarImagen_Load(object sender, EventArgs e)
        {
            try
            {
                if (agregarImgInput.Text == "")
                {
                    nuevaImagenBox.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
                }
                else
                {
                    CargarImagen(agregarImgInput.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void agregarNuevaImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(agregarImgInput.Text))
                {
                    MessageBox.Show("Por favor complete la URL.", "Campos obligatorios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    articuloService.agregarNuevaImagen(_articulo.ID, agregarImgInput.Text);
                    MessageBox.Show("Imagen agregada con exito", "Accion satisfactoria", MessageBoxButtons.OK);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void agregarImgInputLeave(object sender, EventArgs e)
        {
            CargarImagen(agregarImgInput.Text);
        }

        private async Task CargarImagen(string url)
        {
            try
            {
                nuevaImagenBox.Load(url.Trim());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la imagen: " + ex.Message);
                nuevaImagenBox.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
            }
        }

    }
}
