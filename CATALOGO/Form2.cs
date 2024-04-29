using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using dominio;
using negocio;

namespace CATALOGO
{
    public partial class frmAgregar : Form
    {
        private Articulo articulo = null;
        private DataGridView dataGridPrincipal;

        public frmAgregar(DataGridView dataGrid)
        {
            InitializeComponent();
            dataGridPrincipal = dataGrid;
        }
        public frmAgregar(Articulo articulo, DataGridView dataGrid)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
            dataGridPrincipal = dataGrid;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            MarcaService marcaService = new MarcaService();
            CategoriaService categoriaService = new CategoriaService();
            try
            {
                cboMarca.DataSource = marcaService.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaService.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                if (articulo != null)
                {
                    txtCodArticulo.Text = articulo.CODIGO;
                    txtNombre.Text = articulo.NOMBRE;
                    txtDescripcion.Text = articulo.DESCRIPCION;
                    txtPrecio.Text = articulo.PRECIO.ToString();
                    txtUrl.Text = articulo.IMAGEN.Url;
                    //CargarImagen(articulo.IMAGEN.Url);
                    cboMarca.SelectedValue = articulo.MARCA.Id;
                    cboCategoria.SelectedValue = articulo.CATEGORIA.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarImagen(string URLimagen)
        {
            try
            {
                imgAgrArt.Load(URLimagen);
            }
            catch (Exception ex)
            {
                imgAgrArt.Load("https://media.istockphoto.com/id/1409329028/vector/no-picture-available-placeholder-thumbnail-icon-illustration-design.jpg?s=612x612&w=0&k=20&c=_zOuJu755g2eEUioiOUdz_mHKJQJn-tDgIAhQzyeKUQ=");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ArticuloService negocio = new ArticuloService();
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                if (!ValidarCampos())
                {
                    return;
                }

                articulo.NOMBRE = txtNombre.Text;
                articulo.CODIGO = txtCodArticulo.Text;
                articulo.DESCRIPCION = txtDescripcion.Text;
                articulo.PRECIO = decimal.Parse(txtPrecio.Text);
                articulo.CATEGORIA = (Categoria)cboCategoria.SelectedItem;
                articulo.MARCA = (Marca)cboMarca.SelectedItem;
                articulo.IMAGEN = new Imagen();
                articulo.IMAGEN.Url = txtUrl.Text;

                if (articulo.ID != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }

                List<Articulo> listaActualizada = negocio.ListarArticulos();
                dataGridPrincipal.DataSource = listaActualizada;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrl.Text);
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCodArticulo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos obligatorios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio ingresado no es válido.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
