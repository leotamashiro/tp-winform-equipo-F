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

        ArticuloService articuloService = new ArticuloService();

        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void MostrarDetalleArticulo(int id, DataGridView gridTable)
        {
            try
            {
                DetalleArticulo detalleForm = new DetalleArticulo(id, gridTable);
                detalleForm.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            listarArticulo = cargar();
            dataGridView1.DataSource = listarArticulo;
            ocultarColumnas();
            //CargarImagen(listarArticulo[0].IMAGEN.Url);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            CargarImagen(articuloSeleccionado.IMAGEN.Url);
        }



        private void CargarImagen(string URLimagen)
        {
            //try
            //{
            //    picBoxArticulo.Load(URLimagen);
            //}
            //catch (Exception ex)
            //{
            //    picBoxArticulo.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
            //}
        }

        private void buttonVerDetalle(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem != null)
                {
                    Articulo articuloSeleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
                    MostrarDetalleArticulo(articuloSeleccionado.ID, dataGridView1);
                }
                else
                {
                    MessageBox.Show("No hay artículos para mostrar o no se ha seleccionado ninguno válido.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private List<Articulo> cargar()
        {
            return articuloService.ListarArticulos();
        }

        private void ocultarColumnas()
        {
            dataGridView1.Columns["IMAGEN"].Visible = false;
            dataGridView1.Columns["DESCRIPCION"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscador.Text;

            List<Articulo> listarArticuloFiltrada;

            if (filtro != "")
            {
                listarArticuloFiltrada = listarArticulo.FindAll(articulo => articulo.NOMBRE.ToUpper().Contains(filtro.ToUpper())
                || articulo.CATEGORIA.Descripcion.ToUpper().Contains(filtro.ToUpper())
                || articulo.MARCA.Descripcion.ToUpper().Contains(filtro.ToUpper())
                || articulo.CODIGO.ToUpper().Contains(filtro.ToUpper()));
            }
            else { listarArticuloFiltrada = listarArticulo; }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listarArticuloFiltrada;

            ocultarColumnas();
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar alta = new frmAgregar();
            alta.ShowDialog();
            cargar();
        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("NO SELECCIONASTE UN ARTICULO");
            }
            else
            {
                articuloSeleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
                frmAgregar modificar = new frmAgregar(articuloSeleccionado);
                modificar.ShowDialog();
                cargar();
            }
        }
    }
}
