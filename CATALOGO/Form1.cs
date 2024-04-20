namespace CATALOGO
{
    public partial class vtPrincipal : Form
    {
        public vtPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListadoArt_Click(object sender, EventArgs e)
        {
            ListadoArticulos ventana = new ListadoArticulos();
            ventana.ShowDialog();
        }

        private void btnBusArt_Click(object sender, EventArgs e)
        {
            BusquedaArticulos ventana = new BusquedaArticulos();
            ventana.ShowDialog();
        }

        private void btnAgregArt_Click(object sender, EventArgs e)
        {
            frmAgregar alta = new frmAgregar(); 
            alta.ShowDialog(); 
        }
    }
}
