using RestDemo.Model;
using RestDemo.Repositories;

namespace RestDemo.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student Students)
        {
           return repo.AddStudent(Students);
        }

        public int DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }

        public Student GetStudentById(int id)
        {
           return repo.GetStudentById(id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return repo.GetStudents();
        }

        public int UpdateStudent(Student Students)
        {
            return repo.UpdateStudent(Students);
        }
    }
}
