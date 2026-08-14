using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentReportSystem.Models;

namespace StudentReportSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _students = new List<Student>();

        public StudentService()
        {
            _students.Add(new Student("Lefa", "ST001", 78));
            _students.Add(new Student("Thabo", "ST002", 65));
            _students.Add(new Student("Mpho", "ST003", 82));
            _students.Add(new Student("Zanele", "ST004", 91));
            _students.Add(new Student("Sipho", "ST005", 73));
            _students.Add(new Student("Kabelo", "ST006", 88));
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public async Task<List<Student>> LoadStudentDataAsync()
        {
            Console.WriteLine("Starting Student Report System...");
            Console.WriteLine("Loading student data...");
            await Task.Delay(2000);
            Console.WriteLine("Student data loaded successfully.");
            Console.WriteLine();
            return _students;
        }

        public async Task GenerateReportAsync(List<Student> students)
        {
            Console.WriteLine("Generating student report...");
            await Task.Delay(3000);
            Console.WriteLine("Report generated successfully.");
            Console.WriteLine();

            Console.WriteLine("STUDENT REPORT:");
            Console.WriteLine(new string('=', 50));

            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name}");
                Console.WriteLine($"Student Number: {student.StudentNumber}");
                Console.WriteLine($"Marks: {student.Marks}");
                Console.WriteLine();
            }

            Console.WriteLine("Student report completed.");
        }

        public async Task CalculateAverageAsync(List<Student> students)
        {
            Console.WriteLine("Calculating average marks...");
            await Task.Delay(1500);
            double average = students.Average(s => s.Marks);
            Console.WriteLine($"Average Marks: {average:F2}");
            Console.WriteLine();
        }

        public async Task FindTopStudentAsync(List<Student> students)
        {
            Console.WriteLine("Finding top student...");
            await Task.Delay(1000);
            var topStudent = students.OrderByDescending(s => s.Marks).First();
            Console.WriteLine($"Top Student: {topStudent.Name} ({topStudent.Marks} marks)");
            Console.WriteLine();
        }
    }
}