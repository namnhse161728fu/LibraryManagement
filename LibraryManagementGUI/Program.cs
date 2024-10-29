using Microsoft.Extensions.DependencyInjection;
using Repositories.Implements;
using Repositories.Interfaces;
using Repositories.Models;
using Services.Interfaces;
using Services.Implements;
using Services;
namespace LibraryManagementGUI
{
    internal static class Program
    {
        public static IServiceProvider serviceProvider;
        public static IServiceScope CurrentScope; // Scope hiện tại cho phiên làm việc của nhân viên

        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureService(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
        }

        private static void ConfigureService(IServiceCollection services)
        {
            // Cấu hình Dependency Injection
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
            services.AddScoped<ServiceProviders>();

            services.AddScoped<LoginForm>();
            services.AddScoped<LibraryManagementForm>();
        }
    }
}