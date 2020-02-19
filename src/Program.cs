using System;
using src;

namespace KrisHale.CodeLou.ExerciseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //     var inputtingStudent = true;
            //     while (inputtingStudent)
            //     {
            //         InputStudent();

            //         Console.WriteLine("Do you want to enter another student? (Y/N)");
            //         inputtingStudent = Console.ReadLine().ToLower() == "y";
            //     }

            // }


            // static Student InputStudent()
            // {
            //     Console.WriteLine("Enter Student Id");
            //     var studentId = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Enter First Name");
            //     var studentFirstName = Console.ReadLine();
            //     Console.WriteLine("Enter Last Name");
            //     var studentLastName = Console.ReadLine();
            //     Console.WriteLine("Enter Class Name");
            //     var className = Console.ReadLine();
            //     Console.WriteLine("Enter Last Class Completed");
            //     var lastClass = Console.ReadLine();
            //     Console.WriteLine("Enter Last Class Completed Date in format MM/dd/YYYY");
            //     var lastCompletedOn = DateTimeOffset.Parse(Console.ReadLine());
            //     Console.WriteLine("Enter Start Date in format MM/dd/YYYY");
            //     var startDate = DateTimeOffset.Parse(Console.ReadLine());

            //     var studentRecord = new Student();
            //     studentRecord.StudentId = studentId;
            //     studentRecord.FirstName = studentFirstName;
            //     studentRecord.LastName = studentLastName;
            //     studentRecord.ClassName = className;
            //     studentRecord.StartDate = startDate;
            //     studentRecord.LastClassCompleted = lastClass;
            //     studentRecord.LastClassCompletedOn = lastCompletedOn;
            //     Console.WriteLine($"Student Id | Name |  Class "); ;
            //     Console.WriteLine($"{studentRecord.StudentId} | {studentRecord.FirstName} {studentRecord.LastName} | {studentRecord.ClassName} ");
            //     Console.ReadKey();
            //     return studentRecord;

            var inputtingStudent = true;
            while (inputtingStudent)
            {
                DisplayMenu();
                var option = Console.ReadLine();
                switch (int.Parse(option))
                {
                    case 1:
                        InputStudent();
                        break;
                    case 2:
                        DisplayStudents();
                        break;
                    case 3:
                        SearchStudents();
                        break;
                    case 4:
                        inputtingStudent = false;
                        break;
                }
                
            }

        }
        private static void DisplayMenu()
                {
                    Console.WriteLine("Select from the following operations:");
                    Console.WriteLine("1: Enter new student");
                    Console.WriteLine("2: List all students");
                    Console.WriteLine("3: Search for student by name");
                    Console.WriteLine("4: Exit");
                }
        private static void InputStudent()
            {
                Console.WriteLine("Enter Student Id");
                var studentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First Name");
                var studentFirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                var studentLastName = Console.ReadLine();
                Console.WriteLine("Enter Class Name");
                var className = Console.ReadLine();
                Console.WriteLine("Enter Last Class Completed");
                var lastClass = Console.ReadLine();
                Console.WriteLine("Enter Last Class Completed Date in format MM/dd/YYYY");
                var lastCompletedOn = DateTimeOffset.Parse(Console.ReadLine());
                Console.WriteLine("Enter Start Date in format MM/dd/YYYY");
                var startDate = DateTimeOffset.Parse(Console.ReadLine());

                var studentRecord = new Student();
                studentRecord.StudentId = studentId;
                studentRecord.FirstName = studentFirstName;
                studentRecord.LastName = studentLastName;
                studentRecord.ClassName = className;
                studentRecord.StartDate = startDate;
                studentRecord.LastClassCompleted = lastClass;
                studentRecord.LastClassCompletedOn = lastCompletedOn;
                Console.WriteLine($"Student Id | Name |  Class "); ;
                Console.WriteLine($"{studentRecord.StudentId} | {studentRecord.FirstName} {studentRecord.LastName} | {studentRecord.ClassName} ");
                Console.ReadKey();
        }
    }
}


//Challenge 3 sollution
//
//
//
// //
// //
// Class Program
// {
//     statis string _studentRepositoryPath = $"{AppDomain.CurrentDomain.BaseDirectory"}\\students.json";
// 

// static IList<student> studentList = file.Exists(_studentRepositoryPath) ? Read() : new List<Student>();

// static async void Save()
// {
//     using (var file = file.CreateText(_studentRepositoryPath))
//     {
//         await file.WriteAsync(JsonSerializer.Serialize(studentsList));
//     }
// }

// static IList<Student> Read() {
//     return Json.Serializer.Deserialize<IList<student>>(File.ReadAllText(_studentRepositoryPath));
// }

