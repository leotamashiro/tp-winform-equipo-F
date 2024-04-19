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
            textBox1 = new TextBox();
            button1 = new Button();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            editarToolStripMenuItem = new ToolStripMenuItem();
            agregarArticuloToolStripMenuItem = new ToolStripMenuItem();
            eliminarArticuloToolStripMenuItem = new ToolStripMenuItem();
            descargarTablaToolStripMenuItem = new ToolStripMenuItem();
            vistaActualToolStripMenuItem = new ToolStripMenuItem();
            completaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Col_ID, ColNombre, Col_Descrip, Col_marca, Col_Categoria, Col_Img, Col_Precio });
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(916, 523);
            dataGridView1.TabIndex = 0;
            // 
            // Col_ID
            // 
            Col_ID.HeaderText = "ID";
            Col_ID.MinimumWidth = 6;
            Col_ID.Name = "Col_ID";
            Col_ID.ReadOnly = true;
            Col_ID.Width = 125;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 125;
            // 
            // Col_Descrip
            // 
            Col_Descrip.HeaderText = "Descripción";
            Col_Descrip.MinimumWidth = 6;
            Col_Descrip.Name = "Col_Descrip";
            Col_Descrip.ReadOnly = true;
            Col_Descrip.Width = 125;
            // 
            // Col_marca
            // 
            Col_marca.HeaderText = "Marca";
            Col_marca.MinimumWidth = 6;
            Col_marca.Name = "Col_marca";
            Col_marca.ReadOnly = true;
            Col_marca.Width = 125;
            // 
            // Col_Categoria
            // 
            Col_Categoria.HeaderText = "Categoria";
            Col_Categoria.MinimumWidth = 6;
            Col_Categoria.Name = "Col_Categoria";
            Col_Categoria.ReadOnly = true;
            Col_Categoria.Width = 125;
            // 
            // Col_Img
            // 
            Col_Img.HeaderText = "Imagen";
            Col_Img.MinimumWidth = 6;
            Col_Img.Name = "Col_Img";
            Col_Img.ReadOnly = true;
            Col_Img.Width = 125;
            // 
            // Col_Precio
            // 
            Col_Precio.HeaderText = "Precio";
            Col_Precio.MinimumWidth = 6;
            Col_Precio.Name = "Col_Precio";
            Col_Precio.ReadOnly = true;
            Col_Precio.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(740, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(653, 31);
            button1.Name = "button1";
            button1.Size = new Size(79, 29);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { descargarTablaToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(940, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarArticuloToolStripMenuItem, eliminarArticuloToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            agregarArticuloToolStripMenuItem.Size = new Size(224, 26);
            agregarArticuloToolStripMenuItem.Text = "Agregar articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            eliminarArticuloToolStripMenuItem.Size = new Size(224, 26);
            eliminarArticuloToolStripMenuItem.Text = "Eliminar articulo";
            // 
            // descargarTablaToolStripMenuItem
            // 
            descargarTablaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vistaActualToolStripMenuItem, completaToolStripMenuItem });
            descargarTablaToolStripMenuItem.Name = "descargarTablaToolStripMenuItem";
            descargarTablaToolStripMenuItem.Size = new Size(224, 26);
            descargarTablaToolStripMenuItem.Text = "Descargar tabla";
            // 
            // vistaActualToolStripMenuItem
            // 
            vistaActualToolStripMenuItem.Name = "vistaActualToolStripMenuItem";
            vistaActualToolStripMenuItem.Size = new Size(224, 26);
            vistaActualToolStripMenuItem.Text = "Vista actual";
            // 
            // completaToolStripMenuItem
            // 
            completaToolStripMenuItem.Name = "completaToolStripMenuItem";
            completaToolStripMenuItem.Size = new Size(224, 26);
            completaToolStripMenuItem.Text = "Completa";
            // 
            // ListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 601);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            MainMenuStrip = menuStrip1;
            Name = "ListadoArticulos";
            Text = "Lista de artículos";
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