using RestDemo.Data;
using RestDemo.Model;

namespace RestDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddStudent(Student Students)
        {
            int result = 0;
            db.Students?.Add(Students);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int result = 0;
            var stud = db.Students?.Where(x => x.Stuid == id).SingleOrDefault();
            if (stud != null)
            {
                db.Students?.Remove(stud);
                result = db.SaveChanges();
            }
            return result;
        }

        public Student GetStudentById(int id)
        {
            return db.Students?.Where(x => x.Stuid == id).SingleOrDefault();
        }

        public IEnumerable<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public int UpdateStudent(Student Students)
        {
            int result = 0;
            var stud=db.Students?.Where(x=>x.Stuid==Students.Stuid).SingleOrDefault();
            if (stud != null)
            {
                stud.Name = Students.Name;
                stud.Branch = Students.Branch;
                stud.Marks = Students.Marks;
            }
            return result;
        }
    }
}
