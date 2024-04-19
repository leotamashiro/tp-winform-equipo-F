namespace CATALOGO
{
    partial class vtPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnListadoArt = new Button();
            statusStrip1 = new StatusStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblMenu = new Label();
            btnBusArt = new Button();
            btnAgregArt = new Button();
            btnModArt = new Button();
            btnElemArt = new Button();
            SuspendLayout();
            // 
            // btnListadoArt
            // 
            btnListadoArt.Location = new Point(54, 135);
            btnListadoArt.Name = "btnListadoArt";
            btnListadoArt.Size = new Size(209, 29);
            btnListadoArt.TabIndex = 0;
            btnListadoArt.Text = "Listado de artículos";
            btnListadoArt.UseVisualStyleBackColor = true;
            btnListadoArt.Click += btnListadoArt_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 381);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(322, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblMenu
            // 
            lblMenu.Anchor = AnchorStyles.Top;
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 12F);
            lblMenu.Location = new Point(131, 86);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(62, 28);
            lblMenu.TabIndex = 5;
            lblMenu.Text = "Menú";
            // 
            // btnBusArt
            // 
            btnBusArt.Location = new Point(54, 170);
            btnBusArt.Name = "btnBusArt";
            btnBusArt.Size = new Size(209, 29);
            btnBusArt.TabIndex = 6;
            btnBusArt.Text = "Búsqueda de artículos";
            btnBusArt.UseVisualStyleBackColor = true;
            btnBusArt.Click += btnBusArt_Click;
            // 
            // btnAgregArt
            // 
            btnAgregArt.Location = new Point(54, 205);
            btnAgregArt.Name = "btnAgregArt";
            btnAgregArt.Size = new Size(209, 29);
            btnAgregArt.TabIndex = 7;
            btnAgregArt.Text = "Agregar artículos";
            btnAgregArt.UseVisualStyleBackColor = true;
            // 
            // btnModArt
            // 
            btnModArt.Location = new Point(54, 240);
            btnModArt.Name = "btnModArt";
            btnModArt.Size = new Size(209, 29);
            btnModArt.TabIndex = 8;
            btnModArt.Text = "Modificar artículos";
            btnModArt.UseVisualStyleBackColor = true;
            // 
            // btnElemArt
            // 
            btnElemArt.Location = new Point(54, 275);
            btnElemArt.Name = "btnElemArt";
            btnElemArt.Size = new Size(209, 29);
            btnElemArt.TabIndex = 9;
            btnElemArt.Text = "Eliminar articulos";
            btnElemArt.UseVisualStyleBackColor = true;
            // 
            // vtPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 403);
            Controls.Add(btnElemArt);
            Controls.Add(btnModArt);
            Controls.Add(btnAgregArt);
            Controls.Add(btnBusArt);
            Controls.Add(lblMenu);
            Controls.Add(statusStrip1);
            Controls.Add(btnListadoArt);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(340, 450);
            MinimumSize = new Size(340, 450);
            Name = "vtPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catálogo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListadoArt;
        private StatusStrip statusStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblMenu;
        private Button btnBusArt;
        private Button btnAgregArt;
        private Button btnModArt;
        private Button btnElemArt;
    }
}
