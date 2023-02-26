using DIDemo.Models;
using DIDemo.Repository;

namespace DIDemo.Service
{

    public class StudentService:IStudentService
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo) 
        { 
            this.repo = repo;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return repo.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return repo.GetStudentById(id);
        }

        public int AddStudent(Student student)
        {
            return repo.AddStudent(student);
        }

        public int UpdateStudent(Student student)
        {
            return repo.UpdateStudent(student);
        }

        public int DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }
    }
}
