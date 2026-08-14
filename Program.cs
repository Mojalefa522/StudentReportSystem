using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StudentReportSystem.Models;
using StudentReportSystem.Services;

namespace StudentReportSystem
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("  STUDENT REPORT SYSTEM");
            Console.WriteLine("========================================");
            Console.WriteLine();

            var studentService = new StudentService();

            Console.WriteLine("Starting Student Report System...");
            Console.WriteLine();

            List<Student> students = await studentService.LoadStudentDataAsync();
            await studentService.GenerateReportAsync(students);
            await studentService.CalculateAverageAsync(students);
            await studentService.FindTopStudentAsync(students);

            Console.WriteLine("========================================");
            Console.WriteLine("ALL OPERATIONS COMPLETED SUCCESSFULLY");
            Console.WriteLine("========================================");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}