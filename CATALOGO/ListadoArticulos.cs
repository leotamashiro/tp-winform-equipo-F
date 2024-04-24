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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Aquí, puedes obtener el artículo seleccionado y mostrar sus detalles
                // Suponiendo que tienes una lista de Articulos llamada listaArticulos
                Articulo articulo = (Articulo)row.DataBoundItem;
                MostrarDetalleArticulo(articulo.ID);
            }
        }
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

        }
    }
}
