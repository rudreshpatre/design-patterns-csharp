// See https://aka.ms/new-console-template for more information
using SimpleSpecification;
using SimpleSpecification.Specifications;

Console.WriteLine("Hello, Specification!");

var mngr = new StudentManager();
var studentList = mngr.GetStudents();

// get students without using specific method
var studentOne = mngr.GetStudentsByName("Ramesh");
var studentTwo = mngr.GetStudentsByAge(25);
var studentThree = mngr.GetStudentsByCourse("Commerce");

// get students using a specification
var ageSpecification = new StudentAgeSpecification(23);
var studentFour = mngr.GetStudentBySpecification(ageSpecification, studentList);

System.Console.WriteLine("END");
