using DIDemo.Models;

namespace DIDemo.Service
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetEmployeeById(int id);
        public int AddEmployee(Employee employee);
        public int UpdateEmployee(Employee employee);
        public int DeleteEmployee(int id);

    }
}
