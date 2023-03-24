// See https://aka.ms/new-console-template for more information
using SimpleSpecification;

Console.WriteLine("Hello, Specification!");

var mngr = new StudentManager();
var studentList = mngr.GetStudents();

var studentOne = mngr.GetStudentsByName("Ramesh");
var studentTwo = mngr.GetStudentsByAge(25);
var studentThree = mngr.GetStudentsByCourse("Commerce");


System.Console.WriteLine("END");
