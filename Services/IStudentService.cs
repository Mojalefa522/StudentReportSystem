using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentReportSystem.Models;

namespace StudentReportSystem.Services
{
    public interface IStudentService
    {
        Task<List<Student>> LoadStudentDataAsync();
        Task GenerateReportAsync(List<Student> students);
        Task CalculateAverageAsync(List<Student> students);
        Task FindTopStudentAsync(List<Student> students);
        List<Student> GetStudents();
    }
}