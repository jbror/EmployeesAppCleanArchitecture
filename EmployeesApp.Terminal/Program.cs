using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Application.Employees.Services;
using EmployeesApp.Infrastructure.Persistance.Repositories;

namespace EmployeesApp.Terminal;

internal class Program
{
    static void Main(string[] args)
    {


        var employeeRepository = new EmployeeRepository();
        var employeeService = new EmployeeService(employeeRepository);











    }
}
