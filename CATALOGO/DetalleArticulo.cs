using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        private Articulo _articulo;
        private int _id;
        public DetalleArticulo(int id)
        {
            InitializeComponent();
            _id = id;
        }

        ArticuloService articuloService = new ArticuloService();

        private void DetalleArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                _articulo = articuloService.listarArticuloXID(_id);
                codigoInput.Text = _articulo.CODIGO;
                nombreInput.Text = _articulo.NOMBRE;
                descInput.Text = _articulo.DESCRIPCION;
                marcaInput.Text = _articulo.MARCA.Descripcion.ToString();
                categoriaInput.Text = _articulo.CATEGORIA.Descripcion.ToString();
                precioInput.Text = _articulo.PRECIO.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                    // Eliminar el artículo de la lista de artículos
                    //listaArticulos.Remove(_articulo);
                    MessageBox.Show("Articulo eliminado correctamente!");
                    // Actualizar la vista del DataGridView
                    //ActualizarDataGridView();

                    // Cerrar el formulario DetalleArticulo
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
