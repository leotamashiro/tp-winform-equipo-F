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

        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
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
                    //cargarImagen(articulo.ImagenUrl);
                    cboMarca.SelectedValue = articulo.MARCA.Id;
                    cboCategoria.SelectedValue = articulo.CATEGORIA.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                articulo.NOMBRE = txtNombre.Text;
                articulo.CODIGO = txtCodArticulo.Text;
                articulo.DESCRIPCION = txtDescripcion.Text;
                articulo.PRECIO = decimal.Parse(txtPrecio.Text);
                articulo.CATEGORIA = (Categoria)cboCategoria.SelectedItem;
                articulo.MARCA = (Marca)cboMarca.SelectedItem;

                if (articulo.IMAGEN == null)
                {
                    articulo.IMAGEN = new Imagen();
                }

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
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
