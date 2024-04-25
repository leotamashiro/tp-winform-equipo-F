using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using dominio;
using negocio;

namespace CATALOGO
{
    public partial class ListadoArticulos : Form
    {

        private List<Articulo> listarArticulo;

        public ListadoArticulos()
        {
            InitializeComponent();
        }

        ArticuloService articuloService = new ArticuloService();
       
        private void MostrarDetalleArticulo(int id)
        {
            try
            {
                DetalleArticulo detalleForm = new DetalleArticulo(id);
                detalleForm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            listarArticulo = articuloService.ListarArticulos();
            dataGridView1.DataSource = listarArticulo;
            dataGridView1.AutoResizeColumns();
            CargarImagen(listarArticulo[0].IMAGEN.Url);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            CargarImagen(articuloSeleccionado.IMAGEN.Url);
        }

        

        private void CargarImagen(string URLimagen)
        {
            try
            {
                picBoxArticulo.Load(URLimagen);
            }
            catch (Exception ex)
            {
                picBoxArticulo.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
            }
        }

        private void buttonVerDetalle(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            MostrarDetalleArticulo(articuloSeleccionado.ID);
        }
    }
}
