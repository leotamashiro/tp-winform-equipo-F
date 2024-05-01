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
    public partial class MarcaForm : Form
    {
        int _tipoVentana;
        DataGridView _dataGrid;
        ComboBox _comboBox;

        public MarcaForm(int tipoVentana, DataGridView dataGrid, ComboBox listaMarcas)
        {
            InitializeComponent();
            _tipoVentana = tipoVentana;
            _dataGrid = dataGrid;
            _comboBox = listaMarcas;
        }

        private void volverAtrasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MarcaForm_Load(object sender, EventArgs e)
        {
            MarcaService marcaService = new MarcaService();
            try
            {
                if (_tipoVentana == 0)
                {
                    try
                    {
                        marcaTitulo.Text = "Agregar Marca";
                        accionMarcasBtn.Text = "Agregar";
                        cboMarca.Visible = false;
                        modificarSelectItem.Visible = false;
                        labelMarcaInput.Text = "Nueva Marca";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (_tipoVentana == 1)
                {
                    marcaTitulo.Text = "Modificar Marca";
                    accionMarcasBtn.Text = "Modificar";
                    labelMarcaInput.Text = "Nuevo nombre";
                    try
                    {
                        cboMarca.DataSource = marcaService.listar();
                        cboMarca.ValueMember = "Id";
                        cboMarca.DisplayMember = "Descripcion";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    Marca marca = new Marca();
                    marcaTitulo.Text = "Eliminar Marca";
                    accionMarcasBtn.Text = "Eliminar";
                    labelMarcaInput.Visible = false;
                    inputMarca.Visible = false;
                    try
                    {
                        cboMarca.DataSource = marcaService.listar();
                        cboMarca.ValueMember = "Id";
                        cboMarca.DisplayMember = "Descripcion";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        
        private void accionMarcasBtn_Click(object sender, EventArgs e)
        {
            MarcaService marcaService = new MarcaService();
            ArticuloService articuloService = new ArticuloService();
            if (_tipoVentana == 0)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(inputMarca.Text))
                    {
                        MessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos obligatorios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Marca marcaNueva = new Marca();
                    marcaNueva.Descripcion = inputMarca.Text;
                    marcaService.agregarMarca(marcaNueva);
                    MessageBox.Show("Marca agregada", "Accion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Articulo> listaActualizada = articuloService.ListarArticulos();
                    List<Marca> marcaActualizada = marcaService.listar();
                    _dataGrid.DataSource = listaActualizada;
                    _comboBox.DataSource = marcaActualizada;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_tipoVentana == 1)
            {
                Marca marcaActualizada = new Marca();
                try
                {
                    if (cboMarca.SelectedItem == null || string.IsNullOrWhiteSpace(inputMarca.Text))
                    {
                        MessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos obligatorios vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    marcaActualizada = (Marca)cboMarca.SelectedItem;
                    marcaActualizada.Descripcion = inputMarca.Text;
                    marcaService.modificarMarca(marcaActualizada);
                    MessageBox.Show("Marca modificada", "Accion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Articulo> listaArticuloActualizada = articuloService.ListarArticulos();
                    List<Marca> listaMarcasActualizada = marcaService.listar();
                    _dataGrid.DataSource = listaArticuloActualizada;
                    _comboBox.DataSource = listaMarcasActualizada;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    Marca marcaElegida = new Marca();
                    marcaElegida = (Marca)cboMarca.SelectedItem;
                
                    if (cboMarca.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor seleccione una marca.", "Marca no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        marcaService.eliminarMarca(marcaElegida.Id);
                        MessageBox.Show("Marca eliminada", "Accion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<Articulo> listaActualizada = articuloService.ListarArticulos();
                        List<Marca> listaMarcasActualizada = marcaService.listar();
                        _dataGrid.DataSource = listaActualizada;
                        _comboBox.DataSource = listaMarcasActualizada;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
