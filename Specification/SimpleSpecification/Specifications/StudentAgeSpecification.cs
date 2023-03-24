namespace SimpleSpecification.Specifications
{
    public class StudentAgeSpecification : IStudentSpecification
    {
        private int _age;

        public StudentAgeSpecification(int age)
        {
            _age = age;
        }
        public bool isSatisfiedBy(Student student)
        {
            return student.Age.Equals(_age);
        }
    }
}