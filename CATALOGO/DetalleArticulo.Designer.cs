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
            nombreLabel.Location = new Point(117, 88);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(54, 15);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "Nombre:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new Point(117, 47);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new Size(49, 15);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "Codigo:";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(117, 134);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(72, 15);
            descLabel.TabIndex = 2;
            descLabel.Text = "Descripcion:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new Point(117, 229);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new Size(43, 15);
            marcaLabel.TabIndex = 3;
            marcaLabel.Text = "Marca:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new Point(117, 266);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(61, 15);
            categoriaLabel.TabIndex = 4;
            categoriaLabel.Text = "Categoria:";
            // 
            // imagenDetalle
            // 
            imagenDetalle.Location = new Point(456, 47);
            imagenDetalle.Name = "imagenDetalle";
            imagenDetalle.Size = new Size(271, 285);
            imagenDetalle.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenDetalle.TabIndex = 5;
            imagenDetalle.TabStop = false;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new Point(117, 309);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new Size(46, 15);
            precioLabel.TabIndex = 6;
            precioLabel.Text = "Precio: ";
            // 
            // volverListadoBtn
            // 
            volverListadoBtn.Location = new Point(117, 392);
            volverListadoBtn.Name = "volverListadoBtn";
            volverListadoBtn.Size = new Size(120, 46);
            volverListadoBtn.TabIndex = 7;
            volverListadoBtn.Text = "Volver";
            volverListadoBtn.UseVisualStyleBackColor = true;
            volverListadoBtn.Click += volverListadoBtn_Click;
            // 
            // eliminarArtBtn
            // 
            eliminarArtBtn.BackColor = Color.Red;
            eliminarArtBtn.ForeColor = Color.White;
            eliminarArtBtn.Location = new Point(607, 392);
            eliminarArtBtn.Name = "eliminarArtBtn";
            eliminarArtBtn.Size = new Size(120, 46);
            eliminarArtBtn.TabIndex = 8;
            eliminarArtBtn.Text = "Eliminar Articulo";
            eliminarArtBtn.UseVisualStyleBackColor = false;
            eliminarArtBtn.Click += eliminarArtBtn_Click;
            // 
            // codigoInput
            // 
            codigoInput.Location = new Point(215, 47);
            codigoInput.Name = "codigoInput";
            codigoInput.Size = new Size(184, 23);
            codigoInput.TabIndex = 9;
            // 
            // nombreInput
            // 
            nombreInput.Location = new Point(215, 88);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(184, 23);
            nombreInput.TabIndex = 10;
            // 
            // marcaInput
            // 
            marcaInput.Location = new Point(215, 229);
            marcaInput.Name = "marcaInput";
            marcaInput.Size = new Size(184, 23);
            marcaInput.TabIndex = 11;
            // 
            // descInput
            // 
            descInput.Location = new Point(215, 134);
            descInput.Multiline = true;
            descInput.Name = "descInput";
            descInput.Size = new Size(184, 88);
            descInput.TabIndex = 13;
            // 
            // categoriaInput
            // 
            categoriaInput.Location = new Point(215, 266);
            categoriaInput.Name = "categoriaInput";
            categoriaInput.Size = new Size(184, 23);
            categoriaInput.TabIndex = 15;
            // 
            // precioInput
            // 
            precioInput.Location = new Point(215, 309);
            precioInput.Name = "precioInput";
            precioInput.Size = new Size(184, 23);
            precioInput.TabIndex = 17;
            // 
            // DetalleArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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