namespace CATALOGO
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
            dataGridView1 = new DataGridView();
            Col_ID = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            Col_Descrip = new DataGridViewTextBoxColumn();
            Col_marca = new DataGridViewTextBoxColumn();
            Col_Categoria = new DataGridViewTextBoxColumn();
            Col_Img = new DataGridViewTextBoxColumn();
            Col_Precio = new DataGridViewTextBoxColumn();
            Col_Detalle = new DataGridViewButtonColumn();
            textBox1 = new TextBox();
            button1 = new Button();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            descargarTablaToolStripMenuItem = new ToolStripMenuItem();
            vistaActualToolStripMenuItem = new ToolStripMenuItem();
            completaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            editarToolStripMenuItem = new ToolStripMenuItem();
            agregarArticuloToolStripMenuItem = new ToolStripMenuItem();
            eliminarArticuloToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Col_ID, ColNombre, Col_Descrip, Col_marca, Col_Categoria, Col_Img, Col_Precio, Col_Detalle });
            dataGridView1.Location = new Point(10, 50);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Size = new Size(802, 392);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Col_ID
            // 
            Col_ID.HeaderText = "ID";
            Col_ID.MinimumWidth = 6;
            Col_ID.Name = "Col_ID";
            Col_ID.DataPropertyName = "ID";
            Col_ID.ReadOnly = true;
            Col_ID.Width = 125;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.DataPropertyName = "NOMBRE";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 125;
            // 
            // Col_Descrip
            // 
            Col_Descrip.HeaderText = "Descripción";
            Col_Descrip.MinimumWidth = 6;
            Col_Descrip.Name = "Col_Descrip";
            Col_Descrip.DataPropertyName = "DESCRIPCION";
            Col_Descrip.ReadOnly = true;
            Col_Descrip.Width = 125;
            // 
            // Col_marca
            // 
            Col_marca.HeaderText = "Marca";
            Col_marca.MinimumWidth = 6;
            Col_marca.Name = "Col_marca";
            Col_marca.DataPropertyName = "MARCA";
            Col_marca.ReadOnly = true;
            Col_marca.Width = 125;
            // 
            // Col_Categoria
            // 
            Col_Categoria.HeaderText = "Categoria";
            Col_Categoria.MinimumWidth = 6;
            Col_Categoria.Name = "Col_Categoria";
            Col_Categoria.DataPropertyName = "CATEGORIA";
            Col_Categoria.ReadOnly = true;
            Col_Categoria.Width = 125;
            // 
            // Col_Img
            // 
            Col_Img.HeaderText = "Imagen";
            Col_Img.MinimumWidth = 6;
            Col_Img.Name = "Col_Img";
            Col_Img.DataPropertyName = "IMAGEN";
            Col_Img.ReadOnly = true;
            Col_Img.Width = 125;
            // 
            // Col_Precio
            // 
            Col_Precio.HeaderText = "Precio";
            Col_Precio.MinimumWidth = 6;
            Col_Precio.Name = "Col_Precio";
            Col_Precio.DataPropertyName = "PRECIO";
            Col_Precio.ReadOnly = true;
            Col_Precio.Width = 125;
            // 
            // Col_Detalle
            // 
            Col_Detalle.HeaderText = "Detalle";
            Col_Detalle.MinimumWidth = 6;
            Col_Detalle.Name = "Col_Detalle";
            Col_Detalle.UseColumnTextForButtonValue = true;
            Col_Detalle.Text = "Ver Detalle";
            Col_Detalle.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(648, 25);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(571, 23);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(69, 22);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { descargarTablaToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // descargarTablaToolStripMenuItem
            // 
            descargarTablaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vistaActualToolStripMenuItem, completaToolStripMenuItem });
            descargarTablaToolStripMenuItem.Name = "descargarTablaToolStripMenuItem";
            descargarTablaToolStripMenuItem.Size = new Size(155, 22);
            descargarTablaToolStripMenuItem.Text = "Descargar tabla";
            // 
            // vistaActualToolStripMenuItem
            // 
            vistaActualToolStripMenuItem.Name = "vistaActualToolStripMenuItem";
            vistaActualToolStripMenuItem.Size = new Size(134, 22);
            vistaActualToolStripMenuItem.Text = "Vista actual";
            // 
            // completaToolStripMenuItem
            // 
            completaToolStripMenuItem.Name = "completaToolStripMenuItem";
            completaToolStripMenuItem.Size = new Size(134, 22);
            completaToolStripMenuItem.Text = "Completa";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(822, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarArticuloToolStripMenuItem, eliminarArticuloToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            agregarArticuloToolStripMenuItem.Size = new Size(160, 22);
            agregarArticuloToolStripMenuItem.Text = "Agregar articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            eliminarArticuloToolStripMenuItem.Size = new Size(160, 22);
            eliminarArticuloToolStripMenuItem.Text = "Eliminar articulo";
            // 
            // ListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 451);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListadoArticulos";
            Text = "Lista de artículos";
            Load += ListadoArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Col_ID;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn Col_Descrip;
        private DataGridViewTextBoxColumn Col_marca;
        private DataGridViewTextBoxColumn Col_Categoria;
        private DataGridViewTextBoxColumn Col_Img;
        private DataGridViewTextBoxColumn Col_Precio;
        private DataGridViewButtonColumn Col_Detalle;
        private TextBox textBox1;
        private Button button1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem descargarTablaToolStripMenuItem;
        private ToolStripMenuItem vistaActualToolStripMenuItem;
        private ToolStripMenuItem completaToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private ToolStripMenuItem eliminarArticuloToolStripMenuItem;
    }
}