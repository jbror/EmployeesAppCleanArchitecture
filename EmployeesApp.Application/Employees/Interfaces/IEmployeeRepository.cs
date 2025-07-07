using EmployeesApp.Domain.Entities;

namespace EmployeesApp.Web.Services
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        Employee[] GetAll();
        Employee? GetById(int id);
    }
}