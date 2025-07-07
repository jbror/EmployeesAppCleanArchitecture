using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public interface IEmployeeReposistory
    {
        void Add(Employee employee);
        Employee[] GetAll();
        Employee? GetById(int id);
    }
}