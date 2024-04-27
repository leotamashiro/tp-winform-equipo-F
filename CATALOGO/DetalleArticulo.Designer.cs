namespace CATALOGO
{
    partial class DetalleArticulo
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
            nombreLabel = new Label();
            codigoLabel = new Label();
            descLabel = new Label();
            marcaLabel = new Label();
            categoriaLabel = new Label();
            imagenDetalle = new PictureBox();
            precioLabel = new Label();
            volverListadoBtn = new Button();
            eliminarArtBtn = new Button();
            codigoInput = new TextBox();
            nombreInput = new TextBox();
            marcaInput = new TextBox();
            descInput = new TextBox();
            categoriaInput = new TextBox();
            precioInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imagenDetalle).BeginInit();
            SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(134, 117);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(67, 20);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "Nombre:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new Point(134, 63);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new Size(61, 20);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "Codigo:";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(134, 179);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(90, 20);
            descLabel.TabIndex = 2;
            descLabel.Text = "Descripcion:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new Point(134, 305);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new Size(53, 20);
            marcaLabel.TabIndex = 3;
            marcaLabel.Text = "Marca:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new Point(134, 355);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(77, 20);
            categoriaLabel.TabIndex = 4;
            categoriaLabel.Text = "Categoria:";
            // 
            // imagenDetalle
            // 
            imagenDetalle.Location = new Point(521, 63);
            imagenDetalle.Margin = new Padding(3, 4, 3, 4);
            imagenDetalle.Name = "imagenDetalle";
            imagenDetalle.Size = new Size(310, 380);
            imagenDetalle.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenDetalle.TabIndex = 5;
            imagenDetalle.TabStop = false;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new Point(134, 412);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new Size(57, 20);
            precioLabel.TabIndex = 6;
            precioLabel.Text = "Precio: ";
            // 
            // volverListadoBtn
            // 
            volverListadoBtn.Location = new Point(134, 523);
            volverListadoBtn.Margin = new Padding(3, 4, 3, 4);
            volverListadoBtn.Name = "volverListadoBtn";
            volverListadoBtn.Size = new Size(137, 61);
            volverListadoBtn.TabIndex = 7;
            volverListadoBtn.Text = "Volver";
            volverListadoBtn.UseVisualStyleBackColor = true;
            volverListadoBtn.Click += volverListadoBtn_Click;
            // 
            // eliminarArtBtn
            // 
            eliminarArtBtn.BackColor = Color.Red;
            eliminarArtBtn.ForeColor = Color.White;
            eliminarArtBtn.Location = new Point(694, 523);
            eliminarArtBtn.Margin = new Padding(3, 4, 3, 4);
            eliminarArtBtn.Name = "eliminarArtBtn";
            eliminarArtBtn.Size = new Size(137, 61);
            eliminarArtBtn.TabIndex = 8;
            eliminarArtBtn.Text = "Eliminar Articulo";
            eliminarArtBtn.UseVisualStyleBackColor = false;
            eliminarArtBtn.Click += eliminarArtBtn_Click;
            // 
            // codigoInput
            // 
            codigoInput.Location = new Point(246, 63);
            codigoInput.Margin = new Padding(3, 4, 3, 4);
            codigoInput.Name = "codigoInput";
            codigoInput.Size = new Size(210, 27);
            codigoInput.TabIndex = 9;
            // 
            // nombreInput
            // 
            nombreInput.Location = new Point(246, 117);
            nombreInput.Margin = new Padding(3, 4, 3, 4);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(210, 27);
            nombreInput.TabIndex = 10;
            // 
            // marcaInput
            // 
            marcaInput.Location = new Point(246, 305);
            marcaInput.Margin = new Padding(3, 4, 3, 4);
            marcaInput.Name = "marcaInput";
            marcaInput.Size = new Size(210, 27);
            marcaInput.TabIndex = 11;
            // 
            // descInput
            // 
            descInput.Location = new Point(246, 179);
            descInput.Margin = new Padding(3, 4, 3, 4);
            descInput.Multiline = true;
            descInput.Name = "descInput";
            descInput.Size = new Size(210, 116);
            descInput.TabIndex = 13;
            // 
            // categoriaInput
            // 
            categoriaInput.Location = new Point(246, 355);
            categoriaInput.Margin = new Padding(3, 4, 3, 4);
            categoriaInput.Name = "categoriaInput";
            categoriaInput.Size = new Size(210, 27);
            categoriaInput.TabIndex = 15;
            // 
            // precioInput
            // 
            precioInput.Location = new Point(246, 412);
            precioInput.Margin = new Padding(3, 4, 3, 4);
            precioInput.Name = "precioInput";
            precioInput.Size = new Size(210, 27);
            precioInput.TabIndex = 17;
            // 
            // DetalleArticulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(precioInput);
            Controls.Add(categoriaInput);
            Controls.Add(descInput);
            Controls.Add(marcaInput);
            Controls.Add(nombreInput);
            Controls.Add(codigoInput);
            Controls.Add(eliminarArtBtn);
            Controls.Add(volverListadoBtn);
            Controls.Add(precioLabel);
            Controls.Add(imagenDetalle);
            Controls.Add(categoriaLabel);
            Controls.Add(marcaLabel);
            Controls.Add(descLabel);
            Controls.Add(codigoLabel);
            Controls.Add(nombreLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DetalleArticulo";
            Text = "DetalleArticulo";
            Load += DetalleArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)imagenDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreLabel;
        private Label codigoLabel;
        private Label descLabel;
        private Label marcaLabel;
        private Label categoriaLabel;
        private PictureBox imagenDetalle;
        private Label precioLabel;
        private Button volverListadoBtn;
        private Button eliminarArtBtn;
        private TextBox codigoInput;
        private TextBox nombreInput;
        private TextBox marcaInput;
        private TextBox descInput;
        private TextBox categoriaInput;
        private TextBox precioInput;
    }
}