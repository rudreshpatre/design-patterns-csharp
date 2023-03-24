namespace SimpleSpecification.Specifications
{
    public class StudentNameSpecification : IStudentSpecification
    {
        private string _name;
        public StudentNameSpecification(string name)
        {
            _name = name;
        }

        public bool isSatisfiedBy(Student student)
        {
            return student.Name.Equals(_name);
        }
    }
}