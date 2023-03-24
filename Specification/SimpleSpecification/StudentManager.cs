
namespace SimpleSpecification
{
    public class StudentManager
    {
       private IEnumerable<Student> _students = new List<Student>
       {
           new Student{Name = "Ramesh", Age = 29, Course = "Electronics", Grade = "A", YearOfCompletion = 2014},
           new Student{Name = "Suredh", Age = 28, Course = "Commerce", Grade = "B", YearOfCompletion = 2016},
           new Student{Name = "Shruti", Age = 25, Course = "BBA", Grade = "B", YearOfCompletion = 2018},
       };

       public IEnumerable<Student> GetStudents()
       {
           return _students;
       }

       public Student GetStudentsByName(string name)
       {
           return _students.Where(s=>s.Name.Equals(name)).FirstOrDefault();
       }

       public Student GetStudentsByAge(int age)
       {
           return _students.Where(s=>s.Age.Equals(age)).FirstOrDefault();
       }
    }
}