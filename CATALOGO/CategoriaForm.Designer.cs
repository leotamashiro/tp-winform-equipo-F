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
            accionCategoriaBtn.Location = new Point(595, 348);
            accionCategoriaBtn.Name = "accionCategoriaBtn";
            accionCategoriaBtn.Size = new Size(135, 47);
            accionCategoriaBtn.TabIndex = 0;
            accionCategoriaBtn.Text = "button1";
            accionCategoriaBtn.UseVisualStyleBackColor = true;
            accionCategoriaBtn.Click += accionCategoriaBtn_Click;
            // 
            // volverAtrasBtn
            // 
            volverAtrasBtn.Location = new Point(84, 349);
            volverAtrasBtn.Name = "volverAtrasBtn";
            volverAtrasBtn.Size = new Size(132, 46);
            volverAtrasBtn.TabIndex = 1;
            volverAtrasBtn.Text = "Volver";
            volverAtrasBtn.UseVisualStyleBackColor = true;
            volverAtrasBtn.Click += volverAtrasBtn_Click;
            // 
            // inputCategoria
            // 
            inputCategoria.Location = new Point(310, 208);
            inputCategoria.Name = "inputCategoria";
            inputCategoria.Size = new Size(188, 23);
            inputCategoria.TabIndex = 2;
            // 
            // categoriaTitulo
            // 
            categoriaTitulo.AutoSize = true;
            categoriaTitulo.Font = new Font("Segoe UI", 14F);
            categoriaTitulo.Location = new Point(84, 35);
            categoriaTitulo.Name = "categoriaTitulo";
            categoriaTitulo.Size = new Size(94, 25);
            categoriaTitulo.TabIndex = 3;
            categoriaTitulo.Text = "Categoria";
            // 
            // modificarSelectItem
            // 
            modificarSelectItem.AutoSize = true;
            modificarSelectItem.Location = new Point(310, 104);
            modificarSelectItem.Name = "modificarSelectItem";
            modificarSelectItem.Size = new Size(138, 15);
            modificarSelectItem.TabIndex = 5;
            modificarSelectItem.Text = "Seleccione una categoria";
            // 
            // labelCategoriaInput
            // 
            labelCategoriaInput.AutoSize = true;
            labelCategoriaInput.Location = new Point(310, 180);
            labelCategoriaInput.Name = "labelCategoriaInput";
            labelCategoriaInput.Size = new Size(38, 15);
            labelCategoriaInput.TabIndex = 6;
            labelCategoriaInput.Text = "label2";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(310, 133);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(188, 23);
            cboCategoria.TabIndex = 7;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboCategoria);
            Controls.Add(labelCategoriaInput);
            Controls.Add(modificarSelectItem);
            Controls.Add(categoriaTitulo);
            Controls.Add(inputCategoria);
            Controls.Add(volverAtrasBtn);
            Controls.Add(accionCategoriaBtn);
            Name = "CategoriaForm";
            Text = "CategoriaForm";
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