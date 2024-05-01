namespace CATALOGO
{
    partial class MarcaForm
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
            cboMarca = new ComboBox();
            labelMarcaInput = new Label();
            modificarSelectItem = new Label();
            marcaTitulo = new Label();
            inputMarca = new TextBox();
            volverAtrasBtn = new Button();
            accionMarcasBtn = new Button();
            SuspendLayout();
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(128, 100);
            cboMarca.Margin = new Padding(3, 4, 3, 4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(214, 28);
            cboMarca.TabIndex = 14;
            // 
            // labelMarcaInput
            // 
            labelMarcaInput.AutoSize = true;
            labelMarcaInput.Location = new Point(174, 160);
            labelMarcaInput.Name = "labelMarcaInput";
            labelMarcaInput.Size = new Size(50, 20);
            labelMarcaInput.TabIndex = 13;
            labelMarcaInput.Text = "label2";
            // 
            // modificarSelectItem
            // 
            modificarSelectItem.AutoSize = true;
            modificarSelectItem.Location = new Point(157, 76);
            modificarSelectItem.Name = "modificarSelectItem";
            modificarSelectItem.Size = new Size(153, 20);
            modificarSelectItem.TabIndex = 12;
            modificarSelectItem.Text = "Seleccione una marca";
            // 
            // marcaTitulo
            // 
            marcaTitulo.AutoSize = true;
            marcaTitulo.Font = new Font("Segoe UI", 14F);
            marcaTitulo.Location = new Point(19, 14);
            marcaTitulo.Name = "marcaTitulo";
            marcaTitulo.Size = new Size(79, 32);
            marcaTitulo.TabIndex = 11;
            marcaTitulo.Text = "Marca";
            // 
            // inputMarca
            // 
            inputMarca.Location = new Point(128, 184);
            inputMarca.Margin = new Padding(3, 4, 3, 4);
            inputMarca.Name = "inputMarca";
            inputMarca.Size = new Size(214, 27);
            inputMarca.TabIndex = 10;
            // 
            // volverAtrasBtn
            // 
            volverAtrasBtn.Location = new Point(44, 262);
            volverAtrasBtn.Margin = new Padding(3, 4, 3, 4);
            volverAtrasBtn.Name = "volverAtrasBtn";
            volverAtrasBtn.Size = new Size(151, 61);
            volverAtrasBtn.TabIndex = 9;
            volverAtrasBtn.Text = "Volver";
            volverAtrasBtn.UseVisualStyleBackColor = true;
            volverAtrasBtn.Click += volverAtrasBtn_Click;
            // 
            // accionMarcasBtn
            // 
            accionMarcasBtn.Location = new Point(288, 261);
            accionMarcasBtn.Margin = new Padding(3, 4, 3, 4);
            accionMarcasBtn.Name = "accionMarcasBtn";
            accionMarcasBtn.Size = new Size(154, 63);
            accionMarcasBtn.TabIndex = 8;
            accionMarcasBtn.Text = "button1";
            accionMarcasBtn.UseVisualStyleBackColor = true;
            accionMarcasBtn.Click += accionMarcasBtn_Click;
            // 
            // MarcaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 360);
            Controls.Add(cboMarca);
            Controls.Add(labelMarcaInput);
            Controls.Add(modificarSelectItem);
            Controls.Add(marcaTitulo);
            Controls.Add(inputMarca);
            Controls.Add(volverAtrasBtn);
            Controls.Add(accionMarcasBtn);
            Name = "MarcaForm";
            Text = "Administración de marcas";
            Load += MarcaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMarca;
        private Label labelMarcaInput;
        private Label modificarSelectItem;
        private Label marcaTitulo;
        private TextBox inputMarca;
        private Button volverAtrasBtn;
        private Button accionMarcasBtn;
    }
}