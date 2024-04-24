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

namespace CATALOGO
{
    public partial class frmAgregar : Form
    {
        private Articulo articulo = null;

        public frmAgregar()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Articulo articulo = new Articulo();

            articulo.ID = 0;
            articulo.NOMBRE = txtNombre.Text;
            articulo.CODIGO = txtCodArticulo.Text;
            articulo.DESCRIPCION = txtDescripcion.Text; 
            articulo.PRECIO = decimal.Parse(txtPrecio.Text);
            //articulo.imagen= (Imagen);
            articulo.CATEGORIA = (Categoria)cboCategoria.SelectedItem;
            articulo.MARCA = (Marca)cboMarca.SelectedItem;
        }
    }
}
