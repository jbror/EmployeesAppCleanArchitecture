using EmployeesApp.Infrastructure.Persistance.Repositories;
using EmployeesApp.Web.Services;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();



            builder.Services.AddSingleton<IEmployeeService, EmployeeService>(); // Kör med "original" data
            
            //builder.Services.AddSingleton<IEmployeeService, OtherEmployeeService>();  // Kör med "test" data


            var app = builder.Build();
            app.MapControllers();


            app.Run();
        }
    }
}

