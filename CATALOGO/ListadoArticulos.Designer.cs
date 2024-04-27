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
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            descargarTablaToolStripMenuItem = new ToolStripMenuItem();
            vistaActualToolStripMenuItem = new ToolStripMenuItem();
            completaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            editarToolStripMenuItem = new ToolStripMenuItem();
            agregarArticuloToolStripMenuItem = new ToolStripMenuItem();
            eliminarArticuloToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            toolStrip1 = new ToolStrip();
            toolAddArt = new ToolStripButton();
            toolDelArt = new ToolStripButton();
            modificarArticuloToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top;
            txtBuscador.Location = new Point(508, 61);
            txtBuscador.Margin = new Padding(3, 2, 3, 2);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(169, 23);
            txtBuscador.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.Location = new Point(434, 59);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(68, 22);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            menuStrip1.Size = new Size(687, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarArticuloToolStripMenuItem, eliminarArticuloToolStripMenuItem, modificarArticuloToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            agregarArticuloToolStripMenuItem.Size = new Size(180, 22);
            agregarArticuloToolStripMenuItem.Text = "Agregar articulo";
            agregarArticuloToolStripMenuItem.Click += agregarArticuloToolStripMenuItem_Click;
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            eliminarArticuloToolStripMenuItem.Size = new Size(180, 22);
            eliminarArticuloToolStripMenuItem.Text = "Eliminar articulo";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 86);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 230);
            dataGridView1.TabIndex = 5;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(508, 320);
            button2.Name = "button2";
            button2.Size = new Size(162, 42);
            button2.TabIndex = 7;
            button2.Text = "Ver Detalle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonVerDetalle;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolAddArt, toolDelArt });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(687, 27);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolAddArt
            // 
            toolAddArt.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolAddArt.Image = Properties.Resources.AddArticulo;
            toolAddArt.ImageTransparentColor = Color.Magenta;
            toolAddArt.Name = "toolAddArt";
            toolAddArt.Size = new Size(24, 24);
            toolAddArt.Text = "toolStripButton1";
            // 
            // toolDelArt
            // 
            toolDelArt.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolDelArt.Image = Properties.Resources.DeleteArticulo;
            toolDelArt.ImageTransparentColor = Color.Magenta;
            toolDelArt.Name = "toolDelArt";
            toolDelArt.Size = new Size(24, 24);
            toolDelArt.Text = "toolStripButton1";
            // 
            // modificarArticuloToolStripMenuItem
            // 
            modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            modificarArticuloToolStripMenuItem.Size = new Size(180, 22);
            modificarArticuloToolStripMenuItem.Text = "Modificar articulo";
            modificarArticuloToolStripMenuItem.Click += modificarArticuloToolStripMenuItem_Click;
            // 
            // ListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 388);
            Controls.Add(toolStrip1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListadoArticulos";
            Text = "Lista de artículos";
            Load += ListadoArticulos_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscador;
        private Button btnBuscar;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem descargarTablaToolStripMenuItem;
        private ToolStripMenuItem vistaActualToolStripMenuItem;
        private ToolStripMenuItem completaToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolAddArt;
        private ToolStripButton toolDelArt;
        private ToolStripMenuItem modificarArticuloToolStripMenuItem;
    }
}