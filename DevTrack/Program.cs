namespace DevTrack
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
            using var instancia = new System.Threading.Mutex(true, @"Local\DevTrack.Escritorio", out bool primeraInstancia);
            if (!primeraInstancia)
            {
                MessageBox.Show("DevTrack ya está abierto.");
                return;
            }

            try
            {
                Almacen.Cargar();
            }
            catch (Exception error) when (error is IOException or UnauthorizedAccessException or System.Text.Json.JsonException)
            {
                MessageBox.Show("No se pudieron recuperar los datos: " + error.Message);
                return;
            }

            using var acceso = new Acceso();
            if (acceso.ShowDialog() == DialogResult.OK)
                Application.Run(new Form1());
        }
    }
}
