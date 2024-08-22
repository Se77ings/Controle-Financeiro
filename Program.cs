using Controle_Financeiro.data;
using Controle_Financeiro.models;
using Microsoft.EntityFrameworkCore;

namespace Controle_Financeiro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using DataContext context = new DataContext();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            

            User novoUser = new User { Name = "admin", Password = "admin" };

            context.Users.Add(novoUser);
            int affectedRows = context.SaveChanges();
            Console.WriteLine($"{affectedRows} row(s) inserted.");
            Console.WriteLine("Finalizado");

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

        }
    }
}