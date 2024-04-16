namespace CATALOGO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //Articulo articuloPrueba = new Articulo("AA00", "Tablet S9", "Tablet de 6 pulgadas");

            // Creo una lista de articulos 
            List<Articulo> articulos = new List<Articulo>();

            // ======= Agrego objecto articulo a la lista Articulos  ======= //

            //articulos.Add(articuloPrueba);

            // ======= Se podria listar con esto => LISTADO DE ARTICULOS ======= //
            foreach (Articulo articulo in articulos)
            {
                    
            }

        }
    }
}