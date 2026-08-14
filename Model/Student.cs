using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportSystem.Models
{
    // Student class - represents a student with their information and marks
    public class Student
    {
        // Student's full name
        public string Name { get; set; } = string.Empty;

        // Student's unique student number
        public string StudentNumber { get; set; } = string.Empty;

        // Student's marks
        public double Marks { get; set; }

        // Constructor
        public Student(string name, string studentNumber, double marks)
        {
            Name = name;
            StudentNumber = studentNumber;
            Marks = marks;
        }

        // Display student information as a formatted string
        public override string ToString()
        {
            return $"Student: {Name} | Student Number: {StudentNumber} | Marks: {Marks}";
        }
    }
}