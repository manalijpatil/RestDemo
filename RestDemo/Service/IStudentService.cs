using RestDemo.Model;

namespace RestDemo.Service
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int id);
        int AddStudent(Student Students);
        int UpdateStudent(Student Students);
        int DeleteStudent(int id);
    }
}
