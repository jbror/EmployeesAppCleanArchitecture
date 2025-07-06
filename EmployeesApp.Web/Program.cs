using EmployeesApp.Web.Services;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); 

            

            builder.Services.AddSingleton<IEmployeeService, EmployeeService>(); // K�r med "original" data
            //builder.Services.AddSingleton<IEmployeeService, OtherEmployeeService>();  // K�r med "test" data


            var app = builder.Build();
            app.MapControllers();


            app.Run();
        }
    }
}

// Registrera service-klassen som en transient service i Program L�gg nu till en ny anst�lld � varf�r syns den inte p� index-sidan?:

// builder.Services.AddTransient<EmployeeService>(); N�r jag registrerar min klass som transient s� skapas en ny "version" av
// EmployeeService varje g�ng den anv�nds. N�r jag sparar en Employee i min lista s� sparas den i just den versionen. Laddar jag om sidan
// f�r jag en ny "version" och ser inte det jag lagt til tidigare i den andra "versionen"



// Registrera service-klassen som en singleton service i Program L�gg nu till en ny anst�lld - varf�r syns den nu p� index-sidan?:

// F�r att tillskillnad i fr�n en transient klass s� skickas "samma version" av min EmployeeService-klass n�r jag registrerat den som singleton.
// Allts� sparas min �ndringar i min "version" och samma version skickas med n�sta g�ng jag anv�nder klassen. 



// Vad har vi vunnit p� att anv�nda Dependency Injection ist�llet f�r att l�ta controller-klasserna sj�lva instansiera sina beroenden?:

// Det �r mycket mer flexibelt. Nu skickas v�r EmployeeService-klass med automatiskt och vi kan l�tt byta ut den om vi vill. 
// Nu tilldeelas v�ra beroende med konstruktorn och vi kan enkelt byta ut till t.ex. en testversion. 

