namespace CATALOGO
{
    partial class AgregarImagen
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
            nuevaImagenBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            agregarImgInput = new TextBox();
            agregarNuevaImgBtn = new Button();
            VolverBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)nuevaImagenBox).BeginInit();
            SuspendLayout();
            // 
            // nuevaImagenBox
            // 
            nuevaImagenBox.Location = new Point(465, 91);
            nuevaImagenBox.Name = "nuevaImagenBox";
            nuevaImagenBox.Size = new Size(284, 265);
            nuevaImagenBox.SizeMode = PictureBoxSizeMode.StretchImage;
            nuevaImagenBox.TabIndex = 0;
            nuevaImagenBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(31, 91);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "Agregar Nueva Imagen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(31, 185);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 2;
            label2.Text = "URL";
            // 
            // agregarImgInput
            // 
            agregarImgInput.Location = new Point(76, 185);
            agregarImgInput.Name = "agregarImgInput";
            agregarImgInput.Size = new Size(358, 23);
            agregarImgInput.TabIndex = 3;
            agregarImgInput.Leave += agregarImgInputLeave;
            // 
            // agregarNuevaImgBtn
            // 
            agregarNuevaImgBtn.Location = new Point(309, 315);
            agregarNuevaImgBtn.Name = "agregarNuevaImgBtn";
            agregarNuevaImgBtn.Size = new Size(125, 41);
            agregarNuevaImgBtn.TabIndex = 4;
            agregarNuevaImgBtn.Text = "Agregar Imagen";
            agregarNuevaImgBtn.UseVisualStyleBackColor = true;
            agregarNuevaImgBtn.Click += agregarNuevaImgBtn_Click;
            // 
            // VolverBtn
            // 
            VolverBtn.Location = new Point(31, 315);
            VolverBtn.Name = "VolverBtn";
            VolverBtn.Size = new Size(109, 41);
            VolverBtn.TabIndex = 5;
            VolverBtn.Text = "Volver";
            VolverBtn.UseVisualStyleBackColor = true;
            VolverBtn.Click += VolverBtn_Click;
            // 
            // AgregarImagen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VolverBtn);
            Controls.Add(agregarNuevaImgBtn);
            Controls.Add(agregarImgInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nuevaImagenBox);
            Name = "AgregarImagen";
            Text = "AgregarImagen";
            Load += AgregarImagen_Load;
            ((System.ComponentModel.ISupportInitialize)nuevaImagenBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox nuevaImagenBox;
        private Label label1;
        private Label label2;
        private TextBox agregarImgInput;
        private Button agregarNuevaImgBtn;
        private Button VolverBtn;
    }
}