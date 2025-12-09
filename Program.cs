using System;
using System.Collections.Generic;
using System.IO;
using csv;
using System.Text.Json;
using csv.Models;
using csv.Services;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //Console.WriteLine("Generating students based on JSON configuration...");
            //Console.WriteLine();

            //// Parse the JSON configuration
            //var config = JsonSerializer.Deserialize<StudentsDistributionConfig>(
            //    StudentsDistributionJson.Value,
            //    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            //);

            //if (config == null || config.Stages == null || config.Stages.Count == 0)
            //{
            //    Console.WriteLine("Error: Invalid JSON configuration.");
            //    return;
            //}

            //// Display configuration summary
            //Console.WriteLine("Configuration Summary:");
            //Console.WriteLine("======================");
            //foreach (var stage in config.Stages)
            //{
            //    Console.WriteLine($"\nStage: {stage.StageName}");
            //    foreach (var grade in stage.Grades)
            //    {
            //        Console.WriteLine($"  Grade: {grade.GradeName}");
            //        foreach (var classItem in grade.Classes)
            //        {
            //            Console.WriteLine($"    Class {classItem.ClassName}: {classItem.StudentCount} students");
            //        }
            //    }
            //}
            //Console.WriteLine();

            //// Generate students based on configuration
            //List<Student> students = DataGenerator.GenerateStudentsFromConfig(config);

            //// Create output file with total student count
            //string filePath = $"students_{students.Count}.csv";

            //CsvExporter.ExportStudentsToCsv(students, filePath);

            //Console.WriteLine($"\n✓ CSV file created at: {Path.GetFullPath(filePath)}");
            //Console.WriteLine($"✓ Total students generated: {students.Count}");
            //Console.WriteLine($"✓ Total families generated: {students.Select(s => s.Father.FatherId).Distinct().Count()}");
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
            string filePath = $"students_{students.Count}.csv";

            CsvExporter.ExportStudentsToCsv(students, filePath);

            // Only print these 3 lines
            Console.WriteLine($"\n✓ CSV file created at: {Path.GetFullPath(filePath)}");
            Console.WriteLine($"✓ Total students generated: {students.Count}");
            Console.WriteLine($"✓ Total families generated: {students.Select(s => s.Father.FatherId).Distinct().Count()}");



        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"Stack trace: {ex.StackTrace}");
        }
    }
}
