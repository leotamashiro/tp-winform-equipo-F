namespace CATALOGO
{
    partial class CategoriaForm
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
            accionCategoriaBtn = new Button();
            volverAtrasBtn = new Button();
            inputCategoria = new TextBox();
            categoriaTitulo = new Label();
            modificarSelectItem = new Label();
            labelCategoriaInput = new Label();
            cboCategoria = new ComboBox();
            SuspendLayout();
            // 
            // accionCategoriaBtn
            // 
            accionCategoriaBtn.Location = new Point(281, 256);
            accionCategoriaBtn.Margin = new Padding(3, 4, 3, 4);
            accionCategoriaBtn.Name = "accionCategoriaBtn";
            accionCategoriaBtn.Size = new Size(154, 63);
            accionCategoriaBtn.TabIndex = 0;
            accionCategoriaBtn.Text = "button1";
            accionCategoriaBtn.UseVisualStyleBackColor = true;
            accionCategoriaBtn.Click += accionCategoriaBtn_Click;
            // 
            // volverAtrasBtn
            // 
            volverAtrasBtn.Location = new Point(37, 257);
            volverAtrasBtn.Margin = new Padding(3, 4, 3, 4);
            volverAtrasBtn.Name = "volverAtrasBtn";
            volverAtrasBtn.Size = new Size(151, 61);
            volverAtrasBtn.TabIndex = 1;
            volverAtrasBtn.Text = "Volver";
            volverAtrasBtn.UseVisualStyleBackColor = true;
            volverAtrasBtn.Click += volverAtrasBtn_Click;
            // 
            // inputCategoria
            // 
            inputCategoria.Location = new Point(121, 179);
            inputCategoria.Margin = new Padding(3, 4, 3, 4);
            inputCategoria.Name = "inputCategoria";
            inputCategoria.Size = new Size(214, 27);
            inputCategoria.TabIndex = 2;
            // 
            // categoriaTitulo
            // 
            categoriaTitulo.AutoSize = true;
            categoriaTitulo.Font = new Font("Segoe UI", 14F);
            categoriaTitulo.Location = new Point(12, 9);
            categoriaTitulo.Name = "categoriaTitulo";
            categoriaTitulo.Size = new Size(116, 32);
            categoriaTitulo.TabIndex = 3;
            categoriaTitulo.Text = "Categoria";
            // 
            // modificarSelectItem
            // 
            modificarSelectItem.AutoSize = true;
            modificarSelectItem.Location = new Point(143, 71);
            modificarSelectItem.Name = "modificarSelectItem";
            modificarSelectItem.Size = new Size(175, 20);
            modificarSelectItem.TabIndex = 5;
            modificarSelectItem.Text = "Seleccione una categoria";
            // 
            // labelCategoriaInput
            // 
            labelCategoriaInput.AutoSize = true;
            labelCategoriaInput.Location = new Point(167, 155);
            labelCategoriaInput.Name = "labelCategoriaInput";
            labelCategoriaInput.Size = new Size(50, 20);
            labelCategoriaInput.TabIndex = 6;
            labelCategoriaInput.Text = "label2";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(121, 95);
            cboCategoria.Margin = new Padding(3, 4, 3, 4);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(214, 28);
            cboCategoria.TabIndex = 7;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 376);
            Controls.Add(cboCategoria);
            Controls.Add(labelCategoriaInput);
            Controls.Add(modificarSelectItem);
            Controls.Add(categoriaTitulo);
            Controls.Add(inputCategoria);
            Controls.Add(volverAtrasBtn);
            Controls.Add(accionCategoriaBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoriaForm";
            Text = "Administración de categorias";
            Load += CategoriaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button accionCategoriaBtn;
        private Button volverAtrasBtn;
        private TextBox inputCategoria;
        private Label categoriaTitulo;
        private Label modificarSelectItem;
        private Label labelCategoriaInput;
        private ComboBox cboCategoria;
    }
}