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
            picBoxArticulo = new PictureBox();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxArticulo).BeginInit();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(866, 54);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(188, 27);
            txtBuscador.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(781, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { descargarTablaToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // descargarTablaToolStripMenuItem
            // 
            descargarTablaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vistaActualToolStripMenuItem, completaToolStripMenuItem });
            descargarTablaToolStripMenuItem.Name = "descargarTablaToolStripMenuItem";
            descargarTablaToolStripMenuItem.Size = new Size(197, 26);
            descargarTablaToolStripMenuItem.Text = "Descargar tabla";
            // 
            // vistaActualToolStripMenuItem
            // 
            vistaActualToolStripMenuItem.Name = "vistaActualToolStripMenuItem";
            vistaActualToolStripMenuItem.Size = new Size(168, 26);
            vistaActualToolStripMenuItem.Text = "Vista actual";
            // 
            // completaToolStripMenuItem
            // 
            completaToolStripMenuItem.Name = "completaToolStripMenuItem";
            completaToolStripMenuItem.Size = new Size(168, 26);
            completaToolStripMenuItem.Text = "Completa";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1066, 30);
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
            agregarArticuloToolStripMenuItem.Size = new Size(200, 26);
            agregarArticuloToolStripMenuItem.Text = "Agregar articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            eliminarArticuloToolStripMenuItem.Size = new Size(200, 26);
            eliminarArticuloToolStripMenuItem.Text = "Eliminar articulo";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 332);
            dataGridView1.TabIndex = 5;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // picBoxArticulo
            // 
            picBoxArticulo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBoxArticulo.Location = new Point(719, 139);
            picBoxArticulo.Name = "picBoxArticulo";
            picBoxArticulo.Size = new Size(335, 240);
            picBoxArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxArticulo.TabIndex = 6;
            picBoxArticulo.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(555, 457);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(135, 56);
            button2.TabIndex = 7;
            button2.Text = "Ver Detalle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonVerDetalle;
            // 
            // ListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 544);
            Controls.Add(button2);
            Controls.Add(picBoxArticulo);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ListadoArticulos";
            Text = "Lista de artículos";
            Load += ListadoArticulos_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxArticulo).EndInit();
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
        private PictureBox picBoxArticulo;
        private Button button2;
    }
}