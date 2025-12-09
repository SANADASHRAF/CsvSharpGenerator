using System;
using System.Collections.Generic;
using System.Linq;
using csv.Models;
using csv.Utils;

namespace csv.Services
{
    public class DataGenerator
    {
        private static readonly Random rand = new Random();

        public static Name[] MaleNames = {
        new Name { En = "Mohammed", Ar = "محمد" },
        new Name { En = "Abdullah", Ar = "عبدالله" },
        new Name { En = "Fahad", Ar = "فهد" },
        new Name { En = "Salem", Ar = "سالم" },
        new Name { En = "Nasser", Ar = "ناصر" },
        new Name { En = "Yousef", Ar = "يوسف" },
        new Name { En = "Khalid", Ar = "خالد" },
        new Name { En = "Turki", Ar = "تركي" },
        new Name { En = "Saud", Ar = "سعود" },
        new Name { En = "Riyad", Ar = "رياض" },
        new Name { En = "Ahmed", Ar = "أحمد" },
        new Name { En = "Ali", Ar = "علي" },
        new Name { En = "Omar", Ar = "عمر" },
        new Name { En = "Hassan", Ar = "حسن" },
        new Name { En = "Hussein", Ar = "حسين" },
        new Name { En = "Ibrahim", Ar = "إبراهيم" },
        new Name { En = "Ismail", Ar = "إسماعيل" },
        new Name { En = "Hamza", Ar = "حمزة" },
        new Name { En = "Zaid", Ar = "زيد" },
        new Name { En = "Tariq", Ar = "طارق" },
        new Name { En = "Abdulaziz", Ar = "عبدالعزيز" },
        new Name { En = "Sultan", Ar = "سلطان" },
        new Name { En = "Abdulrahman", Ar = "عبدالرحمن" },
        new Name { En = "Sulaiman", Ar = "سليمان" },
        new Name { En = "Mahdi", Ar = "مهدي" },
        new Name { En = "Akram", Ar = "أكرم" },
        new Name { En = "Salman", Ar = "سلمان" },
        new Name { En = "Idris", Ar = "إدريس" },
        new Name { En = "Zayne", Ar = "زين" },
        new Name { En = "Bilal", Ar = "بلال" }
        };

        public static Name[] FemaleNames = {
        new Name { En = "Fatimah", Ar = "فاطمة" },
        new Name { En = "Aisha", Ar = "عائشة" },
        new Name { En = "Noor", Ar = "نور" },
        new Name { En = "Sara", Ar = "سارة" },
        new Name { En = "Layla", Ar = "ليلى" },
        new Name { En = "Haya", Ar = "هيا" },
        new Name { En = "Reem", Ar = "ريم" },
        new Name { En = "Lama", Ar = "لمى" },
        new Name { En = "Nora", Ar = "نورا" },
        new Name { En = "Dana", Ar = "دانا" },
        new Name { En = "Maryam", Ar = "مريم" },
        new Name { En = "Khadijah", Ar = "خديجة" },
        new Name { En = "Zainab", Ar = "زينب" },
        new Name { En = "Amal", Ar = "أمل" },
        new Name { En = "Salma", Ar = "سلمى" },
        new Name { En = "Hanan", Ar = "حنان" },
        new Name { En = "Maha", Ar = "مها" },
        new Name { En = "Lina", Ar = "لينا" },
        new Name { En = "Rania", Ar = "رانيا" },
        new Name { En = "Yasmin", Ar = "ياسمين" },
        new Name { En = "Aaliyah", Ar = "عالية" },
        new Name { En = "Zahra", Ar = "زهرة" },
        new Name { En = "Safiyyah", Ar = "صفية" },
        new Name { En = "Nadia", Ar = "نادية" },
        new Name { En = "Ruqaya", Ar = "رقية" },
        new Name { En = "Atika", Ar = "عاتكة" },
        new Name { En = "Sedra", Ar = "سدرة" },
        new Name { En = "Tamadur", Ar = "تماضر" },
        new Name { En = "Lubaba", Ar = "لبابة" },
        new Name { En = "Assiya", Ar = "أسيا" }
    };

        public static string[] GradeNames = { "المرحلة الاولى", "المرحلة الثانية", "المرحلة الثالثة" };
        public static string[] ClassNames = { "ب", "ه", "د", "ا", "و", "ج", "0" };
        public static string[] Langs = { "ar", "en" };
        public static string[] BirthPlaces = { "Riyadh", "Jeddah", "Dammam", "Mecca", "Medina" };
        public static string[] Addresses = { "Street 1", "Street 2", "Street 3", "Street 4", "Street 5" };
        public static string[] Religions = { "Muslim", "Christian" };

        public static Father GenerateRandomFather(string religion)
        {
            Name first = MaleNames[rand.Next(MaleNames.Length)];
            Name middle = MaleNames[rand.Next(MaleNames.Length)];
            Name grand = MaleNames[rand.Next(MaleNames.Length)];
            string phone = GenerationHelpers.GenerateSaudiPhoneNumber();

            return new Father
            {
                FatherId = GenerationHelpers.GenerateSaudiNationalId(),
                FatherContactPhone = phone,
                ISFatherResponsible = rand.Next(2) == 0,
                FatherFirstName = first.En,
                FatherMiddleName = middle.En,
                FatherGrandName = grand.En,
                FatherNickName = first.En,
                FatherNameInArabic = $"{first.Ar} {middle.Ar} {grand.Ar}",
                FatherGender = "Male",
                FatherBirthDate = DateTime.Now.AddYears(-rand.Next(30, 50)),
                FatherBirthPlace = BirthPlaces[rand.Next(BirthPlaces.Length)],
                FatherAddress = Addresses[rand.Next(Addresses.Length)],
                FatherCountryCode = "+966",
                FatherPhoneNumber = phone,
                FatherNationality = "Saudi",
                FatherReligion = religion,
                Email = GenerationHelpers.GenerateEmail(first.En, grand.En),
                Password = GenerationHelpers.GeneratePassword()
            };
        }

        public static Mother GenerateRandomMother(bool fatherResponsible, string religion)
        {
            Name first = FemaleNames[rand.Next(FemaleNames.Length)];
            Name middle = MaleNames[rand.Next(MaleNames.Length)];
            Name grand = MaleNames[rand.Next(MaleNames.Length)];
            string phone = GenerationHelpers.GenerateSaudiPhoneNumber();

            return new Mother
            {
                MotherId = GenerationHelpers.GenerateSaudiNationalId(),
                MotherContactPhone = phone,
                ISMotherResponsible = !fatherResponsible,
                MotherFirstName = first.En,
                MotherMiddleName = middle.En,
                MotherGrandName = grand.En,
                MotherNickName = first.En,
                MotherNameInArabic = $"{first.Ar} {middle.Ar} {grand.Ar}",
                MotherGender = "Female",
                MotherBirthDate = DateTime.Now.AddYears(-rand.Next(28, 45)),
                MotherBirthPlace = BirthPlaces[rand.Next(BirthPlaces.Length)],
                MotherAddress = Addresses[rand.Next(Addresses.Length)],
                MotherCountryCode = "+966",
                MotherPhoneNumber = phone,
                MotherNationality = "Saudi",
                MotherReligion = religion,
                Email = GenerationHelpers.GenerateEmail(first.En, grand.En),
                Password = GenerationHelpers.GeneratePassword()
            };
        }

        public static Student GenerateStudent(Father father, Mother mother, string religion)
        {
            string gender = rand.Next(2) == 0 ? "Male" : "Female";
            Name firstName = gender == "Male" ? MaleNames[rand.Next(MaleNames.Length)] : FemaleNames[rand.Next(FemaleNames.Length)];

            string middleName = father.FatherFirstName;
            string grandName = father.FatherGrandName;

            return new Student
            {
                StudentId = rand.Next(1000, 9999).ToString(),
                SchoolName = "Saudi International School",
                StageName = "ابتدائية الجامعة صغار",
                GradeName = GradeNames[rand.Next(GradeNames.Length)],
                ClassName = ClassNames[rand.Next(ClassNames.Length)],
                AcademicYear = "2025-2026",
                NationalId = GenerationHelpers.GenerateSaudiNationalId(),
                PassportNumber = "P" + GenerationHelpers.GenerateSaudiNationalId(),
                CommunicationLang = Langs[rand.Next(Langs.Length)],
                FirstName = firstName.En,
                MiddleName = middleName,
                GrandName = grandName,
                NickName = firstName.En,
                NameInArabic = $"{firstName.Ar} {father.FatherNameInArabic.Split(' ')[0]} {father.FatherNameInArabic.Split(' ')[2]}",
                Gender = gender,
                BirthDate = DateTime.Now.AddYears(-rand.Next(6, 12)),
                BirthPlace = BirthPlaces[rand.Next(BirthPlaces.Length)],
                Address = Addresses[rand.Next(Addresses.Length)],
                CountryCode = "+966",
                PhoneNumber = GenerationHelpers.GenerateSaudiPhoneNumber(),
                Nationality = "Saudi",
                Religion = religion,
                Father = father,
                Mother = mother,
                Email = GenerationHelpers.GenerateEmail(firstName.En, grandName),
                Password = GenerationHelpers.GeneratePassword(),
            };
        }

        public static Family GenerateFamily()
        {
            string religion = Religions[rand.Next(Religions.Length)];

            var father = GenerateRandomFather(religion);
            var mother = GenerateRandomMother(father.ISFatherResponsible, religion);

            int numberOfStudents;
            int chance = rand.Next(100);
            if (chance < 70) numberOfStudents = 1;
            else if (chance < 90) numberOfStudents = 2;
            else numberOfStudents = 3;

            var students = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                students.Add(GenerateStudent(father, mother, religion));
            }

            return new Family
            {
                Father = father,
                Mother = mother,
                Students = students
            };
        }

        public static List<Student> GenerateStudentsWithFamilies(int numberOfFamilies)
        {
            var allStudents = new List<Student>();

            for (int i = 0; i < numberOfFamilies; i++)
            {
                var family = GenerateFamily();
                allStudents.AddRange(family.Students);
            }

            return allStudents;
        }

      
        public static List<Student> GenerateStudentsFromConfig(StudentsDistributionConfig config)
        {
            var allStudents = new List<Student>();
            var familyPool = new List<Family>();

            // First, calculate total students needed
            int totalStudentsNeeded = 0;
            foreach (var stage in config.Stages)
            {
                foreach (var grade in stage.Grades)
                {
                    foreach (var classItem in grade.Classes)
                    {
                        totalStudentsNeeded += classItem.StudentCount;
                    }
                }
            }

            // Generate families until we have enough students
            // We'll generate slightly more families to ensure we have enough students
            while (allStudents.Count < totalStudentsNeeded)
            {
                var family = GenerateFamily();
                familyPool.Add(family);
                allStudents.AddRange(family.Students);
            }

            // Now assign students to specific stages/grades/classes according to config
            var assignedStudents = new List<Student>();
            int studentIndex = 0;

            foreach (var stage in config.Stages)
            {
                foreach (var grade in stage.Grades)
                {
                    foreach (var classItem in grade.Classes)
                    {
                        for (int i = 0; i < classItem.StudentCount; i++)
                        {
                            if (studentIndex < allStudents.Count)
                            {
                                var student = allStudents[studentIndex];
                                
                                // Update student's stage, grade, and class information
                                student.StageName = stage.StageName;
                                student.GradeName = grade.GradeName;
                                student.ClassName = classItem.ClassName;
                                
                                assignedStudents.Add(student);
                                studentIndex++;
                            }
                        }
                    }
                }
            }

            return assignedStudents;
        }
    }
}
