namespace SimpleSpecification.Specifications
{
    public class StudentCourseSpecification : IStudentSpecification
    {
        private string _course;
        public StudentCourseSpecification(string course)
        {
            _course = course;
        }

        public bool isSatisfiedBy(Student student)
        {
            return student.Course.Equals(_course);
        }
    }
}