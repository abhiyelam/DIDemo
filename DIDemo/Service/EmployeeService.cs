using DIDemo.Models;
using DIDemo.Repository;

namespace DIDemo.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;
        public EmployeeService(IEmployeeRepository repo) 
        {
            this.repo = repo;
        }
        public int AddEmployee(Employee employee)
        {
            return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return repo.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public int UpdateEmployee(Employee employee)
        {
            return repo.UpdateEmployee(employee);
        }
    }
}
