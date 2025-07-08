using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Domain.Entities;

namespace EmployeesApp.Application.Employees.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }


    public void Add(Employee employee)
    {

        
        _employeeRepository.Add(employee);        

        // File.WriteAllText(@"C:\Users\bror\Documents\kaka.txt", $"Adding employee {employee.Id}");

    }

    public Employee[] GetAll()
    {
        return _employeeRepository.GetAll();
    }


    public Employee? GetById(int id)
    {
        return _employeeRepository.GetById(id);
    }
}



