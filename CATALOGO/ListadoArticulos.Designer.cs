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
            menuStrip1 = new MenuStrip();
            editarToolStripMenuItem = new ToolStripMenuItem();
            agregarArticuloToolStripMenuItem = new ToolStripMenuItem();
            modificarArticuloToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            modificarMarcaToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            cboMarcas = new ComboBox();
            lblMarca = new Label();
            groupBox1 = new GroupBox();
            btnReset = new Button();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            agregarNuevaImagenToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscador.Location = new Point(486, 25);
            txtBuscador.Margin = new Padding(3, 2, 3, 2);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(169, 23);
            txtBuscador.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(413, 23);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(68, 22);
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
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(663, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarArticuloToolStripMenuItem, modificarArticuloToolStripMenuItem, modificarToolStripMenuItem, modificarMarcaToolStripMenuItem, agregarNuevaImagenToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            agregarArticuloToolStripMenuItem.Size = new Size(194, 22);
            agregarArticuloToolStripMenuItem.Text = "Agregar articulo";
            agregarArticuloToolStripMenuItem.Click += agregarArticuloToolStripMenuItem_Click;
            // 
            // modificarArticuloToolStripMenuItem
            // 
            modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            modificarArticuloToolStripMenuItem.Size = new Size(194, 22);
            modificarArticuloToolStripMenuItem.Text = "Modificar articulo";
            modificarArticuloToolStripMenuItem.Click += modificarArticuloToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(194, 22);
            modificarToolStripMenuItem.Text = "Modificar categoria";
            // 
            // modificarMarcaToolStripMenuItem
            // 
            modificarMarcaToolStripMenuItem.Name = "modificarMarcaToolStripMenuItem";
            modificarMarcaToolStripMenuItem.Size = new Size(194, 22);
            modificarMarcaToolStripMenuItem.Text = "Modificar marca";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(10, 50);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(643, 260);
            dataGridView1.TabIndex = 5;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(486, 341);
            button2.Name = "button2";
            button2.Size = new Size(162, 36);
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
            cboMarcas.Location = new Point(104, 12);
            cboMarcas.Margin = new Padding(3, 2, 3, 2);
            cboMarcas.Name = "cboMarcas";
            cboMarcas.Size = new Size(135, 23);
            cboMarcas.TabIndex = 6;
            cboMarcas.SelectedIndexChanged += cboMarcas_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(37, 18);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
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
            groupBox1.Location = new Point(10, 315);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(284, 68);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros rápidos";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(244, 26);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(32, 24);
            btnReset.TabIndex = 9;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // cboCategoria
            // 
            cboCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(104, 41);
            cboCategoria.Margin = new Padding(3, 2, 3, 2);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(135, 23);
            cboCategoria.TabIndex = 8;
            cboCategoria.SelectedIndexChanged += cboCategoria_SelectedIndexChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(37, 44);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoria:";
            // 
            // agregarNuevaImagenToolStripMenuItem
            // 
            agregarNuevaImagenToolStripMenuItem.Name = "agregarNuevaImagenToolStripMenuItem";
            agregarNuevaImagenToolStripMenuItem.Size = new Size(194, 22);
            agregarNuevaImagenToolStripMenuItem.Text = "Agregar nueva imagen";
            agregarNuevaImagenToolStripMenuItem.Click += agregarNuevaImagenToolStripMenuItem_Click;
            // 
            // ListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 392);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(492, 430);
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
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem modificarMarcaToolStripMenuItem;
        private Button btnReset;
        private ToolStripMenuItem agregarNuevaImagenToolStripMenuItem;
    }
}
