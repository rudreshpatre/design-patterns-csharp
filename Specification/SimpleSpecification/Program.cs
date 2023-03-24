// See https://aka.ms/new-console-template for more information
using SimpleSpecification;
using SimpleSpecification.Specifications;

Console.WriteLine("Hello, Specification!");

var mngr = new StudentManager();
var studentList = mngr.GetStudents();

// get students using specific methods for a property
var studentOne = mngr.GetStudentsByName("Ramesh");
var studentTwo = mngr.GetStudentsByAge(25);
var studentThree = mngr.GetStudentsByCourse("Commerce");

// get students using a specification
var ageTwentyThreeSpecification = new StudentAgeSpecification(23);
var studentFour = mngr.GetStudentBySpecification(ageTwentyThreeSpecification, studentList);

var nameSureshSpecification = new StudentNameSpecification("Suresh");
var nameRameshSpecification = new StudentNameSpecification("Ramesh");
var nameShrutiSpecification = new StudentNameSpecification("Shruti");
var studentFive = mngr.GetStudentBySpecification(nameSureshSpecification, studentList);
var studentSix = mngr.GetStudentBySpecification(nameRameshSpecification, studentList);
var studentSeven = mngr.GetStudentBySpecification(nameShrutiSpecification, studentList);

var courseBBASpecification = new StudentCourseSpecification("BBA");
var studentEight = mngr.GetStudentBySpecification(courseBBASpecification,studentList);

System.Console.WriteLine("END");
