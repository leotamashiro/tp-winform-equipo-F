namespace CATALOGO
{
    partial class frmAgregar
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
            label1 = new Label();
            txtCodArticulo = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPrecio = new TextBox();
            label8 = new Label();
            cboMarca = new ComboBox();
            cboCategoria = new ComboBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtUrl = new TextBox();
            label6 = new Label();
            imgAgrArt = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgAgrArt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 61);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "CODIGO DE ARTICULO";
            // 
            // txtCodArticulo
            // 
            txtCodArticulo.Location = new Point(207, 58);
            txtCodArticulo.Margin = new Padding(3, 4, 3, 4);
            txtCodArticulo.Name = "txtCodArticulo";
            txtCodArticulo.Size = new Size(179, 27);
            txtCodArticulo.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(207, 107);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 111);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(207, 156);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(179, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 159);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 254);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 12;
            label4.Text = "CATEGORIA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 204);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "MARCA";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(209, 332);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(179, 27);
            txtPrecio.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 335);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 16;
            label8.Text = "PRECIO";
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(209, 201);
            cboMarca.Margin = new Padding(3, 4, 3, 4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(179, 28);
            cboMarca.TabIndex = 3;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(209, 251);
            cboCategoria.Margin = new Padding(3, 4, 3, 4);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(179, 28);
            cboCategoria.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(32, 417);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(103, 31);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(259, 417);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 31);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(209, 292);
            txtUrl.Margin = new Padding(3, 4, 3, 4);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(179, 27);
            txtUrl.TabIndex = 6;
            txtUrl.Leave += txtUrl_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 295);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 24;
            label6.Text = "URL";
            // 
            // imgAgrArt
            // 
            imgAgrArt.Location = new Point(425, 78);
            imgAgrArt.Margin = new Padding(3, 4, 3, 4);
            imgAgrArt.Name = "imgAgrArt";
            imgAgrArt.Size = new Size(299, 267);
            imgAgrArt.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAgrArt.TabIndex = 26;
            imgAgrArt.TabStop = false;
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 471);
            Controls.Add(imgAgrArt);
            Controls.Add(txtUrl);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(cboCategoria);
            Controls.Add(cboMarca);
            Controls.Add(txtPrecio);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCodArticulo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAgregar";
            Text = "Agregar Articulos";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)imgAgrArt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodArticulo;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPrecio;
        private Label label8;
        private ComboBox cboMarca;
        private ComboBox cboCategoria;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtUrl;
        private Label label6;
        private PictureBox imgAgrArt;
    }
}