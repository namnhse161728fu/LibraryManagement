using Microsoft.Extensions.DependencyInjection;
using Repositories.Implements;
using Repositories.Interfaces;
using Repositories.Models;
using Services.Interfaces;
using Services.Implements;
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
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ILibrarianService, LibrarianService>();
            services.AddScoped<ILoanService, LoanService>();
            services.AddScoped<ILoanDetailService, LoanDetailService>();
        }
    }
}