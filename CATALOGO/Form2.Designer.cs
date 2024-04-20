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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 46);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "CODIGO DE ARTICULO";
            // 
            // txtCodArticulo
            // 
            txtCodArticulo.Location = new Point(160, 38);
            txtCodArticulo.Name = "txtCodArticulo";
            txtCodArticulo.Size = new Size(157, 23);
            txtCodArticulo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 83);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(160, 112);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(157, 23);
            txtDescripcion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 120);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 194);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "CATEGORIA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 157);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "MARCA";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(160, 223);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(157, 23);
            txtPrecio.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 231);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 16;
            label8.Text = "PRECIO";
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(160, 157);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(157, 23);
            cboMarca.TabIndex = 18;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(160, 194);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(157, 23);
            cboCategoria.TabIndex = 19;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(28, 313);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(90, 23);
            btnConfirmar.TabIndex = 20;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(227, 313);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 23);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(160, 260);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(157, 23);
            txtUrl.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 268);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 24;
            label6.Text = "URL";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(372, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 200);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 353);
            Controls.Add(pictureBox1);
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
            Name = "frmAgregar";
            Text = "Agregar Articulos";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}