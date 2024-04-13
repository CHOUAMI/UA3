using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_UA3
{
    // Classe principale de l'application
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Course> courses = new List<Course>();
        static List<Grade> grades = new List<Grade>();

        static void Main(string[] args)
        {
            // Menu principal
            while (true)
            {
                Console.WriteLine("1. Créer étudiant");
                Console.WriteLine("2. Afficher étudient(s)");
                Console.WriteLine("3. Créer Cours");
                Console.WriteLine("4. Afficher Cours");
                Console.WriteLine("5. Entrer Note");
                Console.WriteLine("6. Afficher Note ");
                Console.WriteLine("7. Afficher le relevé de Note");
                Console.WriteLine("8. Sorti");
                Console.Write("Selectioner autre option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateStudent();
                        break;
                    case "2":
                        DisplayStudents();
                        break;
                    case "3":
                        CreateCourse();
                        break;
                    case "4":
                        DisplayCourses();
                        break;
                    case "5":
                        EnterGrades();
                        break;
                    case "6":
                        DisplayGrades();
                        break;
                    case "7":
                        GenerateStudentReport();
                        break;
                    case "8":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // Méthodes pour chaque fonctionnalité

        static void CreateStudent()
        {
            Console.Write("Enter student number: ");
            int studentNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            students.Add(new Student { StudentNumber = studentNumber, FirstName = firstName, LastName = lastName });
        }

        static void DisplayStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void CreateCourse()
        {
            Console.Write("Enter course number: ");
            int courseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter course code: ");
            string code = Console.ReadLine();

            Console.Write("Enter course title: ");
            string title = Console.ReadLine();

            courses.Add(new Course { CourseNumber = courseNumber, Code = code, Title = title });
        }

        static void DisplayCourses()
        {
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }

        static void EnterGrades()
        {
            Console.Write("Enter student number: ");
            int studentNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter course number: ");
            int courseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter grade: ");
            double grade = double.Parse(Console.ReadLine());

            grades.Add(new Grade { StudentNumber = studentNumber, CourseNumber = courseNumber, Score = grade });
        }

        static void DisplayGrades()
        {
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        static void GenerateStudentReport()
        {
            Console.Write("Enter student number: ");
            int studentNumber = int.Parse(Console.ReadLine());

            var student = students.Find(s => s.StudentNumber == studentNumber);
            if (student != null)
            {
                string fileName = $"StudentReport_{studentNumber}.txt";
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(student);
                    writer.WriteLine("Grades:");
                    foreach (var grade in grades)
                    {
                        if (grade.StudentNumber == studentNumber)
                        {
                            writer.WriteLine(grade);
                        }
                    }
                }
                Console.WriteLine($"Report generated: {fileName}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
