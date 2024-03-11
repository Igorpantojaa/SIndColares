using Infraestrutura;
using Infraestrutura.DTOs;

namespace SINDCOLARES
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
            //SindColaresContext context = new();
            Application.Run(new FRM_Inicio(new AssociadoDTO()));
        }
    }
}