using Microsoft.Extensions.DependencyInjection;
using Repositories.Implements;
using Repositories.Interfaces;
using Repositories.Models;

namespace LibraryManagementGUI
{
    internal static class Program
    {
        private static IServiceProvider serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            
            Application.Run(new LoginForm());
        }

        private static void ConfigureService(IServiceCollection services)
        {
            //Add Dependency Injections
            services.AddDbContext<LibraryManagementContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}