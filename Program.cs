using System;
using System.Collections.Generic;
using System.IO;
using csv;
using System.Text.Json;
using csv.Models;
using csv.Services;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using TeachersGenerator.Services;
using TeachersGenerator.Models;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Select Generation Mode:");
            Console.WriteLine("1. Students (Original)");
            Console.WriteLine("2. Teachers (New)");
            Console.Write("Enter choice (1 or 2): ");
            var choice = Console.ReadLine();

            if (choice == "2")
            {
                Console.WriteLine("Generating Teachers...");

                var teacherNamesAr = new List<string>
                {
                    "محمد سعيد",
                    "مينا مدحت",
                    "سند اشرف",
                    "مجدي موسي",
                    "طه احمد",
                    "موسي محمد",
                    "سامي محمد",
                    "محسن محمد",
                    "محمود محمد",
                    "يوسف محمد",
                    "زياد احمد",
                    "شادي محمد",
                    "خالد احمد",
                    "فيصل محمد",
                    "احمد زيدان",
                    "ابو بكر رجب",
                    "عمرو احمد",
                    "مصطفي سامي",
                    "ابراهيم احمد",
                    "شريف احمد",
                    "حازم احمد",
                    "فهد محمد",
                    "ايمن زيدان",
                    "عمر محمد",
                    "حسام حسن",
                    "كريم ابراهيم",
                    "اشرف احمد",
                    "طارق مصطفي",
                    "سعود احمد",
                    "احمد طه",
                    "مازن محمد",
                    "ناصر ناصر",
                    "سيد احمد",
                    "محمد ابراهيم",
                    "مدحت احمد",
                    "سلمان الفرج"
                };


                var service = new TeacherGeneratorService();
                var teachers = service.GenerateTeachers(teacherNamesAr);

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string filePath = $"teachers_{teachers.Count}_{timestamp}.csv";
                TeacherCsvExporter.ExportTeachersToCsv(teachers, filePath);

                Console.WriteLine($"\n✓ Teachers CSV file created at: {Path.GetFullPath(filePath)}");
                Console.WriteLine($"✓ Total teachers generated: {teachers.Count}");
            }
            else
            {
                // Parse the JSON configuration
                var config = JsonSerializer.Deserialize<StudentsDistributionConfig>(
                    StudentsDistributionJson.Value,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                );
    
                if (config == null || config.Stages == null || config.Stages.Count == 0)
                {
                    Console.WriteLine("Error: Invalid JSON configuration.");
                    return;
                }
    
                // Generate students based on configuration
                List<Student> students = DataGenerator.GenerateStudentsFromConfig(config);
    
                // Create output file with total student count
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string filePath = $"students_{students.Count}_{timestamp}.csv";
    
                CsvExporter.ExportStudentsToCsv(students, filePath);
    
                // Only print these 3 lines
                Console.WriteLine($"\n✓ CSV file created at: {Path.GetFullPath(filePath)}");
                Console.WriteLine($"✓ Total students generated: {students.Count}");
                Console.WriteLine($"✓ Total families generated: {students.Select(s => s.Father.FatherId).Distinct().Count()}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }
}
