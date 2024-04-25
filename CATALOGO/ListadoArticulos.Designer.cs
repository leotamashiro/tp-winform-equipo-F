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
            dataGridView1 = new DataGridView();
            picBoxArticulo = new PictureBox();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxArticulo).BeginInit();
            SuspendLayout();
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
            menuStrip1.Size = new Size(933, 24);
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
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 68);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(594, 249);
            dataGridView1.TabIndex = 5;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // picBoxArticulo
            // 
            picBoxArticulo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBoxArticulo.Location = new Point(629, 104);
            picBoxArticulo.Margin = new Padding(3, 2, 3, 2);
            picBoxArticulo.Name = "picBoxArticulo";
            picBoxArticulo.Size = new Size(293, 180);
            picBoxArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxArticulo.TabIndex = 6;
            picBoxArticulo.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(486, 343);
            button2.Name = "button2";
            button2.Size = new Size(118, 42);
            button2.TabIndex = 7;
            button2.Text = "Ver Detalle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonVerDetalle;
            // 
            // ListadoArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 408);
            Controls.Add(button2);
            Controls.Add(picBoxArticulo);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridView dataGridView1;
        private PictureBox picBoxArticulo;
        private Button button2;
    }
}