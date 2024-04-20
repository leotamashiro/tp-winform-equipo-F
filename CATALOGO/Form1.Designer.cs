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
            btnListadoArt.Location = new Point(47, 101);
            btnListadoArt.Margin = new Padding(3, 2, 3, 2);
            btnListadoArt.Name = "btnListadoArt";
            btnListadoArt.Size = new Size(183, 22);
            btnListadoArt.TabIndex = 0;
            btnListadoArt.Text = "Listado de artículos";
            btnListadoArt.UseVisualStyleBackColor = true;
            btnListadoArt.Click += btnListadoArt_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 286);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(284, 22);
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
            lblMenu.Location = new Point(115, 64);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(50, 21);
            lblMenu.TabIndex = 5;
            lblMenu.Text = "Menú";
            // 
            // btnBusArt
            // 
            btnBusArt.Location = new Point(47, 128);
            btnBusArt.Margin = new Padding(3, 2, 3, 2);
            btnBusArt.Name = "btnBusArt";
            btnBusArt.Size = new Size(183, 22);
            btnBusArt.TabIndex = 6;
            btnBusArt.Text = "Búsqueda de artículos";
            btnBusArt.UseVisualStyleBackColor = true;
            btnBusArt.Click += btnBusArt_Click;
            // 
            // btnAgregArt
            // 
            btnAgregArt.Location = new Point(47, 154);
            btnAgregArt.Margin = new Padding(3, 2, 3, 2);
            btnAgregArt.Name = "btnAgregArt";
            btnAgregArt.Size = new Size(183, 22);
            btnAgregArt.TabIndex = 7;
            btnAgregArt.Text = "Agregar artículos";
            btnAgregArt.UseVisualStyleBackColor = true;
            btnAgregArt.Click += btnAgregArt_Click;
            // 
            // btnModArt
            // 
            btnModArt.Location = new Point(47, 180);
            btnModArt.Margin = new Padding(3, 2, 3, 2);
            btnModArt.Name = "btnModArt";
            btnModArt.Size = new Size(183, 22);
            btnModArt.TabIndex = 8;
            btnModArt.Text = "Modificar artículos";
            btnModArt.UseVisualStyleBackColor = true;
            // 
            // btnElemArt
            // 
            btnElemArt.Location = new Point(47, 206);
            btnElemArt.Margin = new Padding(3, 2, 3, 2);
            btnElemArt.Name = "btnElemArt";
            btnElemArt.Size = new Size(183, 22);
            btnElemArt.TabIndex = 9;
            btnElemArt.Text = "Eliminar articulos";
            btnElemArt.UseVisualStyleBackColor = true;
            // 
            // vtPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 308);
            Controls.Add(btnElemArt);
            Controls.Add(btnModArt);
            Controls.Add(btnAgregArt);
            Controls.Add(btnBusArt);
            Controls.Add(lblMenu);
            Controls.Add(statusStrip1);
            Controls.Add(btnListadoArt);
            MaximumSize = new Size(300, 347);
            MinimumSize = new Size(300, 347);
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
