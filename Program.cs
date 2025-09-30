namespace SistemaProtoGuiA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Repository repository = new Repository();

            ApplicationConfiguration.Initialize();
            Application.Run(new Janela2());
        }
    }
}