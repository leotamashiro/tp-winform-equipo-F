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
    public partial class CategoriaForm : Form
    {
        int _tipoVentana;
        DataGridView _dataGrid;
        ComboBox _comboBox;
        public CategoriaForm(int tipoVentana, DataGridView dataGrid, ComboBox listaCategorias)
        {
            InitializeComponent();
            _tipoVentana = tipoVentana;
            _dataGrid = dataGrid;
            _comboBox = listaCategorias;
        }

        private void volverAtrasBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            CategoriaService categoriaService = new CategoriaService();
            try
            {
                if (_tipoVentana == 0)
                {
                    try
                    {
                        categoriaTitulo.Text = "Agregar Categoria";
                        accionCategoriaBtn.Text = "Agregar";
                        cboCategoria.Visible = false;
                        modificarSelectItem.Visible = false;
                        labelCategoriaInput.Text = "Nueva Categoria";
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (_tipoVentana == 1)
                {
                    categoriaTitulo.Text = "Modificar Categoria";
                    accionCategoriaBtn.Text = "Modificar";
                    labelCategoriaInput.Text = "Nuevo nombre";
                    try
                    {
                        cboCategoria.DataSource = categoriaService.listar();
                        cboCategoria.ValueMember = "Id";
                        cboCategoria.DisplayMember = "Descripcion";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    Categoria categoria = new Categoria();
                    categoriaTitulo.Text = "Eliminar Categoria";
                    accionCategoriaBtn.Text = "Eliminar";
                    labelCategoriaInput.Visible = false;
                    inputCategoria.Visible = false;
                    try
                    {
                        cboCategoria.DataSource = categoriaService.listar();
                        cboCategoria.ValueMember = "Id";
                        cboCategoria.DisplayMember = "Descripcion";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
            catch
            {
            }

        }

        private void accionCategoriaBtn_Click(object sender, EventArgs e)
        {
            CategoriaService categoriaService = new CategoriaService();
            ArticuloService articuloService = new ArticuloService();
            if (_tipoVentana == 0)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(inputCategoria.Text))
                    {
                        MessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos obligatorios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    categoriaService.agregarCategoria(inputCategoria.Text);
                    MessageBox.Show("Categoria Agregada", "Accion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Articulo> listaActualizada= articuloService.ListarArticulos();
                    List<Categoria> categoriaActualizada = categoriaService.listar();
                    _dataGrid.DataSource = listaActualizada;
                    _comboBox.DataSource = categoriaActualizada;
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else if (_tipoVentana == 1)
            {
                Categoria categoriaActualizada = new Categoria();
                try
                {
                    if (cboCategoria.SelectedItem == null || string.IsNullOrWhiteSpace(inputCategoria.Text))
                    {
                        MessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos obligatorios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    categoriaActualizada = (Categoria)cboCategoria.SelectedItem;
                    categoriaActualizada.Descripcion = inputCategoria.Text;
                    categoriaService.modificarCategoria(categoriaActualizada);
                    MessageBox.Show("Categoria Modificada", "Accion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Articulo> listaActualizada = articuloService.ListarArticulos();
                    List<Categoria> categoriasActualizada = categoriaService.listar();
                    _dataGrid.DataSource = listaActualizada;
                    _comboBox.DataSource = categoriasActualizada;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Categoria categoriaElegida = new Categoria();
                categoriaElegida = (Categoria)cboCategoria.SelectedItem;
                if (cboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione una categoría.", "Categoría no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    categoriaService.eliminarCategoria(categoriaElegida.Id);
                    MessageBox.Show("Categoria Eliminada", "Accion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Articulo> listaActualizada = articuloService.ListarArticulos();
                    List<Categoria> categoriasActualizada = categoriaService.listar();
                    _dataGrid.DataSource = listaActualizada;
                    _comboBox.DataSource = categoriasActualizada;
                    this.Close();
                }
            }
        }
    }
}
