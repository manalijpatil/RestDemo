using RestDemo.Model;

namespace RestDemo.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int id);
        int AddStudent(Student Students);
        int UpdateStudent(Student Students);
        int DeleteStudent(int id);
    }
}
