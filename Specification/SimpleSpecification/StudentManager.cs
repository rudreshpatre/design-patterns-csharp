
namespace SimpleSpecification
{
    public class StudentManager
    {
       private IEnumerable<Student> _students = new List<Student>
       {
           new Student{Name = "Ramesh", Age = 29, Course = "Electronics", Grade = "A", YearOfCompletion = 2014},
           new Student{Name = "Suresh", Age = 28, Course = "Commerce", Grade = "B", YearOfCompletion = 2016},
           new Student{Name = "Shruti", Age = 25, Course = "BBA", Grade = "B", YearOfCompletion = 2018},
       };

       public IEnumerable<Student> GetStudents()
       {
           return _students;
       }

        // we are having multiple methods doing the simple check based on the property passed, 
        // this can later grow to large number of such methods and may become difficult to maintain.
        // how can we make it more clean?
       public Student GetStudentsByName(string name)
       {
           return _students.Where(s=>s.Name.Equals(name)).FirstOrDefault();
       }

       public Student GetStudentsByAge(int age)
       {
           return _students.Where(s=>s.Age.Equals(age)).FirstOrDefault();
       }

        public Student GetStudentsByCourse(string course)
       {
           return _students.Where(s => s.Course.Equals(course, StringComparison.OrdinalIgnoreCase))
                           .FirstOrDefault();
       }
    }
}