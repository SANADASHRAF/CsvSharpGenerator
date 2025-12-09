using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using csv.Models;

namespace csv.Services
{
    public class CsvExporter
    {
        public static void ExportStudentsToCsv(List<Student> students, string filePath)
        {
            using (var writer = new StreamWriter(filePath, false, new System.Text.UTF8Encoding(true)))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                var flattenedStudents = FlattenStudents(students);
                csv.WriteRecords(flattenedStudents);
            }
        }

        private static List<dynamic> FlattenStudents(List<Student> students)
        {
            var flattenedStudents = new List<dynamic>();

            foreach (var student in students)
            {
                flattenedStudents.Add(new
                {
                    student.StudentId,
                    student.StageName,
                    student.GradeName,
                    student.ClassName,
                    student.AcademicYear,
                    student.NationalId,
                    student.PassportNumber,
                    student.CommunicationLang,
                    student.FirstName,
                    student.MiddleName,
                    student.GrandName,
                    student.NickName,
                    student.NameInArabic,
                    student.Gender,
                    student.BirthDate,
                    student.BirthPlace,
                    student.Address,
                    student.CountryCode,
                    student.PhoneNumber,
                    student.Nationality,
                    student.Religion,
                    student.Email,
                    student.Password,

                    FatherId = student.Father?.FatherId,
                    FatherContactPhone = student.Father?.FatherContactPhone,
                    ISFatherResponsible = student.Father?.ISFatherResponsible,
                    FatherFirstName = student.Father?.FatherFirstName,
                    FatherMiddleName = student.Father?.FatherMiddleName,
                    FatherGrandName = student.Father?.FatherGrandName,
                    FatherNickName = student.Father?.FatherNickName,
                    FatherNameInArabic = student.Father?.FatherNameInArabic,
                    FatherGender = student.Father?.FatherGender,
                    FatherBirthDate = student.Father?.FatherBirthDate,
                    FatherBirthPlace = student.Father?.FatherBirthPlace,
                    FatherAddress = student.Father?.FatherAddress,
                    FatherCountryCode = student.Father?.FatherCountryCode,
                    FatherPhoneNumber = student.Father?.FatherPhoneNumber,
                    FatherNationality = student.Father?.FatherNationality,
                    FatherReligion = student.Father?.FatherReligion,
                    FatherPassword = student.Father?.Password,
                    FatherEmail = student.Father?.Email,

                    MotherId = student.Mother?.MotherId,
                    MotherContactPhone = student.Mother?.MotherContactPhone,
                    ISMotherResponsible = student.Mother?.ISMotherResponsible,
                    MotherFirstName = student.Mother?.MotherFirstName,
                    MotherMiddleName = student.Mother?.MotherMiddleName,
                    MotherGrandName = student.Mother?.MotherGrandName,
                    MotherNickName = student.Mother?.MotherNickName,
                    MotherNameInArabic = student.Mother?.MotherNameInArabic,
                    MotherGender = student.Mother?.MotherGender,
                    MotherBirthDate = student.Mother?.MotherBirthDate,
                    MotherBirthPlace = student.Mother?.MotherBirthPlace,
                    MotherAddress = student.Mother?.MotherAddress,
                    MotherCountryCode = student.Mother?.MotherCountryCode,
                    MotherPhoneNumber = student.Mother?.MotherPhoneNumber,
                    MotherNationality = student.Mother?.MotherNationality,
                    MotherReligion = student.Mother?.MotherReligion,
                    MotherEmail = student.Mother?.Email,
                    MotherPassword = student.Mother?.Password
                });
            }

            return flattenedStudents;
        }
    }
}
