﻿namespace CATALOGO
{
    partial class ListadoArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            menuStrip1 = new MenuStrip();
            editarToolStripMenuItem = new ToolStripMenuItem();
            agregarArticuloToolStripMenuItem = new ToolStripMenuItem();
            modificarArticuloToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            marcaToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem1 = new ToolStripMenuItem();
            agregarNuevaImagenToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            cboMarcas = new ComboBox();
            lblMarca = new Label();
            groupBox1 = new GroupBox();
            btnReset = new Button();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscador.Location = new Point(555, 33);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(193, 27);
            txtBuscador.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(472, 31);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(78, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(758, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarArticuloToolStripMenuItem, modificarArticuloToolStripMenuItem, categoriaToolStripMenuItem, marcaToolStripMenuItem, agregarNuevaImagenToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            agregarArticuloToolStripMenuItem.Size = new Size(243, 26);
            agregarArticuloToolStripMenuItem.Text = "Agregar articulo";
            agregarArticuloToolStripMenuItem.Click += agregarArticuloToolStripMenuItem_Click;
            // 
            // modificarArticuloToolStripMenuItem
            // 
            modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            modificarArticuloToolStripMenuItem.Size = new Size(243, 26);
            modificarArticuloToolStripMenuItem.Text = "Modificar articulo";
            modificarArticuloToolStripMenuItem.Click += modificarArticuloToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem1, eliminarToolStripMenuItem });
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(243, 26);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(224, 26);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(224, 26);
            modificarToolStripMenuItem1.Text = "Modificar";
            modificarToolStripMenuItem1.Click += modificarToolStripMenuItem1_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(224, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // marcaToolStripMenuItem
            // 
            marcaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem1, modificarToolStripMenuItem, eliminarToolStripMenuItem1 });
            marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            marcaToolStripMenuItem.Size = new Size(243, 26);
            marcaToolStripMenuItem.Text = "Marca";
            // 
            // agregarToolStripMenuItem1
            // 
            agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            agregarToolStripMenuItem1.Size = new Size(224, 26);
            agregarToolStripMenuItem1.Text = "Agregar";
            agregarToolStripMenuItem1.Click += agregarToolStripMenuItem1_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(224, 26);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem1
            // 
            eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            eliminarToolStripMenuItem1.Size = new Size(224, 26);
            eliminarToolStripMenuItem1.Text = "Eliminar";
            eliminarToolStripMenuItem1.Click += eliminarToolStripMenuItem1_Click;
            // 
            // agregarNuevaImagenToolStripMenuItem
            // 
            agregarNuevaImagenToolStripMenuItem.Name = "agregarNuevaImagenToolStripMenuItem";
            agregarNuevaImagenToolStripMenuItem.Size = new Size(243, 26);
            agregarNuevaImagenToolStripMenuItem.Text = "Agregar nueva imagen";
            agregarNuevaImagenToolStripMenuItem.Click += agregarNuevaImagenToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(11, 67);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(735, 347);
            dataGridView1.TabIndex = 5;
            dataGridView1.DataError += dataGridView1_DataError;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(555, 455);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(185, 48);
            button2.TabIndex = 2;
            button2.Text = "Ver Detalle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonVerDetalle;
            // 
            // cboMarcas
            // 
            cboMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cboMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarcas.FormattingEnabled = true;
            cboMarcas.Location = new Point(119, 16);
            cboMarcas.Name = "cboMarcas";
            cboMarcas.Size = new Size(154, 28);
            cboMarcas.TabIndex = 6;
            cboMarcas.SelectedIndexChanged += cboMarcas_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(42, 24);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(53, 20);
            lblMarca.TabIndex = 7;
            lblMarca.Text = "Marca:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(cboCategoria);
            groupBox1.Controls.Add(lblCategoria);
            groupBox1.Controls.Add(cboMarcas);
            groupBox1.Controls.Add(lblMarca);
            groupBox1.Location = new Point(11, 420);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 91);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros rápidos";
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.Reset1;
            btnReset.Location = new Point(279, 35);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(37, 32);
            btnReset.TabIndex = 9;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // cboCategoria
            // 
            cboCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(119, 55);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(154, 28);
            cboCategoria.TabIndex = 8;
            cboCategoria.SelectedIndexChanged += cboCategoria_SelectedIndexChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(42, 59);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoria:";
            // 
            // ListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 523);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(560, 558);
            Name = "ListadoArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de artículos";
            Load += ListadoArticulos_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscador;
        private Button btnBuscar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button2;
        private ToolStripMenuItem modificarArticuloToolStripMenuItem;
        private ComboBox cboMarcas;
        private Label lblMarca;
        private GroupBox groupBox1;
        private ComboBox cboCategoria;
        private Label lblCategoria;
        private Button btnReset;
        private ToolStripMenuItem agregarNuevaImagenToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem marcaToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem1;
    }
}
