using DIDemo.Data;
using DIDemo.Models;

namespace DIDemo.Repository
{
    public class EmployeeRepository :IEmployeeRepository
    {
        private ApplicationDbContext db;
        public EmployeeRepository(ApplicationDbContext db) 
        { 
            this.db = db;
        }
        public int AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            int result=db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int result = 0;
            var p = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (p != null)
            {
                db.Employees.Remove(p);
                result= db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            var employee= db.Employees.Find(id);
            return employee;
        }

        public int UpdateEmployee(Employee employee)
        {
            int result = 0;
            var p=db.Employees.Where(x=>x.Id == employee.Id).FirstOrDefault();
            if (p != null)
            {
                p.Name = employee.Name;
                p.Email = employee.Email;
                p.Mobile = employee.Mobile;
                p.Age = employee.Age;
                result=db.SaveChanges();
            }
            return result;
        }
    }
}
