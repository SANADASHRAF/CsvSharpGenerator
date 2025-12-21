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
            new Name { En = "Sultan", Ar = "سلطان" },
            new Name { En = "Sulaiman", Ar = "سليمان" },
            new Name { En = "Mahdi", Ar = "مهدي" },
            new Name { En = "Akram", Ar = "أكرم" },
            new Name { En = "Salman", Ar = "سلمان" },
            new Name { En = "Idris", Ar = "إدريس" },
            new Name { En = "Zain", Ar = "زين" },
            new Name { En = "Bilal", Ar = "بلال" },
            new Name { En = "Adam", Ar = "آدم" },
            new Name { En = "Anas", Ar = "أنس" },
            new Name { En = "Ameer", Ar = "أمير" },
            new Name { En = "Asim", Ar = "عاصم" },
            new Name { En = "Aalam", Ar = "عالم" },
            new Name { En = "Aqil", Ar = "عاقِل" },
            new Name { En = "Aarif", Ar = "عارف" },
            new Name { En = "Aashir", Ar = "أشير" },
            new Name { En = "Aasif", Ar = "عاصف" },
            new Name { En = "Abbas", Ar = "عباس" },
            new Name { En = "Adnan", Ar = "عدنان" },
            new Name { En = "Affan", Ar = "عفان" },
            new Name { En = "Ahsan", Ar = "أحسن" },
            new Name { En = "Aaron", Ar = "هارون" },
            new Name { En = "Arif", Ar = "عارف" },
            new Name { En = "Ayaan", Ar = "أيان" },
            new Name { En = "Azan", Ar = "أذان" },
            new Name { En = "Afeef", Ar = "عفيف" },
            new Name { En = "Aadil", Ar = "عادل" },
            new Name { En = "Basil", Ar = "باسل" },
            new Name { En = "Bashir", Ar = "بشير" },
            new Name { En = "Bassam", Ar = "بسام" },
            new Name { En = "Badr", Ar = "بدر" },
            new Name { En = "Daniyal", Ar = "دانيال" },
            new Name { En = "Dawoud", Ar = "داوود" },
            new Name { En = "Fahim", Ar = "فاهيم" },
            new Name { En = "Faisal", Ar = "فيصل" },
            new Name { En = "Farzan", Ar = "فرزان" },
            new Name { En = "Farhan", Ar = "فرحان" },
            new Name { En = "Ghazi", Ar = "غازي" },
            new Name { En = "Ghaith", Ar = "غيث" },
            new Name { En = "Ghalib", Ar = "غالب" },
            new Name { En = "Haris", Ar = "حارث" },
            new Name { En = "Habeeb", Ar = "حبيب" },
            new Name { En = "Haneef", Ar = "حنيف" },
            new Name { En = "Hammad", Ar = "حمد" },
            new Name { En = "Imran", Ar = "عمران" },
            new Name { En = "Imad", Ar = "عماد" },
            new Name { En = "Ishaq", Ar = "إسحاق" },
            new Name { En = "Isam", Ar = "عصام" },
            new Name { En = "Irfan", Ar = "عرفان" },
            new Name { En = "Jaabir", Ar = "جابر" },
            new Name { En = "Jalaal", Ar = "جلال" },
            new Name { En = "Jamaal", Ar = "جمال" },
            new Name { En = "Junaid", Ar = "جنيد" },
            new Name { En = "Jawad", Ar = "جواد" },
            new Name { En = "Kamal", Ar = "كمال" },
            new Name { En = "Kashif", Ar = "كاشف" },
            new Name { En = "Khalil", Ar = "خليل" },
            new Name { En = "Kamil", Ar = "كامل" },
            new Name { En = "Luqman", Ar = "لقمان" },
            new Name { En = "Muhsin", Ar = "محسن" },
            new Name { En = "Muneeb", Ar = "منيب" },
            new Name { En = "Mahmood", Ar = "محمود" },
            new Name { En = "Moazzam", Ar = "معظم" },
            new Name { En = "Moosa", Ar = "موسى" },
            new Name { En = "Mumin", Ar = "مؤمن" },
            new Name { En = "Marwan", Ar = "مروان" },
            new Name { En = "Nabeel", Ar = "نبيل" },
            new Name { En = "Naseem", Ar = "نسيم" },
            new Name { En = "Nuh", Ar = "نوح" },
            new Name { En = "Nadeem", Ar = "نديم" },
            new Name { En = "Osama", Ar = "أسامة" },
            new Name { En = "Qasim", Ar = "قاسم" },
            new Name { En = "Qamar", Ar = "قمر" },
            new Name { En = "Rashid", Ar = "راشد" },
            new Name { En = "Rafee", Ar = "رافي" },
            new Name { En = "Rayhan", Ar = "ريحان" },
            new Name { En = "Rayan", Ar = "ريان" },
            new Name { En = "Ridwan", Ar = "رضوان" },
            new Name { En = "Saleem", Ar = "سليم" },
            new Name { En = "Saif", Ar = "سيف" },
            new Name { En = "Sadiq", Ar = "صادق" },
            new Name { En = "Sabur", Ar = "صبور" },
            new Name { En = "Tahir", Ar = "طاهر" },
            new Name { En = "Waleed", Ar = "وليد" },
            new Name { En = "Waseem", Ar = "وسيم" },
            new Name { En = "Yasir", Ar = "ياسر" },
            new Name { En = "Yunus", Ar = "يونس" },
            new Name { En = "Yaqub", Ar = "يعقوب" },
            new Name { En = "Zubair", Ar = "زبير" },
            new Name { En = "Bandar", Ar = "بندر" },
            new Name { En = "Majed", Ar = "ماجد" },
            new Name { En = "Mansour", Ar = "منصور" },
            new Name { En = "Meshal", Ar = "مشعل" },
            new Name { En = "Naif", Ar = "نايف" },
            new Name { En = "Nawaf", Ar = "نواف" },
            new Name { En = "Obaid", Ar = "عبايد" },
            new Name { En = "Rakan", Ar = "ركان" },
            new Name { En = "Saad", Ar = "سعد" },
            new Name { En = "Talal", Ar = "طلال" },
            new Name { En = "Thamer", Ar = "ثامر" },
            new Name { En = "Wael", Ar = "وائل" },
            new Name { En = "Yahya", Ar = "يحيى" },
            new Name { En = "Zakaria", Ar = "زكريا" },
            new Name { En = "Abdul", Ar = "عبد" },
            new Name { En = "Aziz", Ar = "عزيز" },
            new Name { En = "Bander", Ar = "بندر" },
            new Name { En = "Faleh", Ar = "فالح" },
            new Name { En = "Gassem", Ar = "قاسم" },
            new Name { En = "Hadi", Ar = "هادي" },
            new Name { En = "Jaber", Ar = "جابر" },
            new Name { En = "Kareem", Ar = "كريم" },
            new Name { En = "Lutfi", Ar = "لطفي" },
            new Name { En = "Mansoor", Ar = "منصور" },
            new Name { En = "Nasser", Ar = "ناصر" },
            new Name { En = "Qais", Ar = "قيس" },
            new Name { En = "Raad", Ar = "رعد" },
            new Name { En = "Sami", Ar = "سامي" },
            new Name { En = "Tareq", Ar = "طارق" },
            new Name { En = "Umar", Ar = "عمر" },
            new Name { En = "Vahid", Ar = "وحيد" },
            new Name { En = "Wahid", Ar = "واحد" },
            new Name { En = "Yasser", Ar = "ياسر" },
            new Name { En = "Zaid", Ar = "زيد" }
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
            new Name { En = "Assiya", Ar = "أسيا" },
            new Name { En = "Amira", Ar = "أميرة" },
            new Name { En = "Dina", Ar = "دينا" },
            new Name { En = "Farah", Ar = "فرح" },
            new Name { En = "Iman", Ar = "إيمان" },
            new Name { En = "Samira", Ar = "سميرة" },
            new Name { En = "Asma", Ar = "أسماء" },
            new Name { En = "Basma", Ar = "بسمة" },
            new Name { En = "Halima", Ar = "حليمة" },
            new Name { En = "Shaima", Ar = "شيماء" },
            new Name { En = "Amani", Ar = "أماني" },
            new Name { En = "Nawal", Ar = "نوال" },
            new Name { En = "Hiba", Ar = "هبة" },
            new Name { En = "Rana", Ar = "رنا" },
            new Name { En = "Arwa", Ar = "أروى" },
            new Name { En = "Hala", Ar = "هالة" },
            new Name { En = "Marwa", Ar = "مروة" },
            new Name { En = "Sahar", Ar = "سحر" },
            new Name { En = "Tasnim", Ar = "تسنيم" },
            new Name { En = "Warda", Ar = "وردة" },
            new Name { En = "Lulu", Ar = "لولو" },
            new Name { En = "Isra", Ar = "إسراء" },
            new Name { En = "Dima", Ar = "ديمة" },
            new Name { En = "Arij", Ar = "أريج" },
            new Name { En = "Suad", Ar = "سعاد" },
            new Name { En = "Na'ima", Ar = "نعيمة" },
            new Name { En = "Janan", Ar = "جنان" },
            new Name { En = "Basima", Ar = "باسمة" },
            new Name { En = "Fajr", Ar = "فجر" },
            new Name { En = "Aziza", Ar = "عزيزة" },
            new Name { En = "Adila", Ar = "عديلة" },
            new Name { En = "Wafiya", Ar = "وفية" },
            new Name { En = "Sultana", Ar = "سلطانة" },
            new Name { En = "Rashida", Ar = "رشيدة" },
            new Name { En = "Mumtaz", Ar = "ممتاز" },
            new Name { En = "Kubra", Ar = "كبرى" },
            new Name { En = "Ikram", Ar = "إكرام" },
            new Name { En = "Basira", Ar = "بصيرة" },
            new Name { En = "Amina", Ar = "أمينة" },
            new Name { En = "Naila", Ar = "نائلة" },
            new Name { En = "Samar", Ar = "سمر" },
            new Name { En = "Rubab", Ar = "رباب" },
            new Name { En = "Rawiya", Ar = "رواية" },
            new Name { En = "Fayruz", Ar = "فيروز" },
            new Name { En = "Yara", Ar = "يارا" },
            new Name { En = "Abla", Ar = "أبلة" },
            new Name { En = "Husniya", Ar = "حسنية" },
            new Name { En = "Shula", Ar = "شولة" },
            new Name { En = "Zulaykha", Ar = "زليخا" },
            new Name { En = "Taliba", Ar = "طالبة" },
            new Name { En = "Munira", Ar = "منيرة" },
            new Name { En = "Nermin", Ar = "نرمين" },
            new Name { En = "Zaahira", Ar = "ظاهرة" },
            new Name { En = "Fikriyya", Ar = "فكرية" },
            new Name { En = "Khalilah", Ar = "خليلة" },
            new Name { En = "Shakira", Ar = "شكيرة" },
            new Name { En = "Uzma", Ar = "عظمى" },
            new Name { En = "Aida", Ar = "عايدة" },
            new Name { En = "Ruba", Ar = "ربى" },
            new Name { En = "Hadil", Ar = "هديل" },
            new Name { En = "Rawda", Ar = "روضة" },
            new Name { En = "Abeer", Ar = "عابر" },
            new Name { En = "Bushra", Ar = "بشرى" },
            new Name { En = "Dalal", Ar = "دلال" },
            new Name { En = "Fawzia", Ar = "فوزية" },
            new Name { En = "Ghada", Ar = "غادة" },
            new Name { En = "Huda", Ar = "هدى" },
            new Name { En = "Intisar", Ar = "انتصار" },
            new Name { En = "Jamila", Ar = "جميلة" },
            new Name { En = "Kawthar", Ar = "كوثر" },
            new Name { En = "Mais", Ar = "ميس" },
            new Name { En = "Najla", Ar = "نجلاء" },
            new Name { En = "Omayma", Ar = "أميمة" },
            new Name { En = "Qamar", Ar = "قمر" },
            new Name { En = "Sawsan", Ar = "سوسن" },
            new Name { En = "Thana", Ar = "ثناء" },
            new Name { En = "Umayma", Ar = "أميمة" },
            new Name { En = "Widad", Ar = "وداد" },
            new Name { En = "Yumn", Ar = "يمن" },
            new Name { En = "Zoya", Ar = "زويا" },
            new Name { En = "Joud", Ar = "جود" },
            new Name { En = "Muna", Ar = "منى" },
            new Name { En = "Nada", Ar = "ندى" },
            new Name { En = "Ola", Ar = "أولى" },
            new Name { En = "Saja", Ar = "سجى" },
            new Name { En = "Tala", Ar = "تالة" },
            new Name { En = "Wafa", Ar = "وفاء" },
            new Name { En = "Zahira", Ar = "زاهرة" },
            new Name { En = "Afaf", Ar = "عفاف" },
            new Name { En = "Bahija", Ar = "بهيجة" },
            new Name { En = "Dua", Ar = "دعاء" },
            new Name { En = "Eman", Ar = "إيمان" },
            new Name { En = "Fatin", Ar = "فاتن" },
            new Name { En = "Ghalia", Ar = "غالية" },
            new Name { En = "Hoor", Ar = "حور" },
            new Name { En = "Inas", Ar = "إناس" },
            new Name { En = "Jihan", Ar = "جهان" },
            new Name { En = "Khadra", Ar = "خضراء" },
            new Name { En = "Laili", Ar = "ليلى" },
            new Name { En = "Mays", Ar = "ميّس" },
            new Name { En = "Naima", Ar = "نعيمة" },
            new Name { En = "Ola", Ar = "عُلا" },
            new Name { En = "Pari", Ar = "باري" },
            new Name { En = "Qadira", Ar = "قادرة" },
            new Name { En = "Rima", Ar = "ريم" },
            new Name { En = "Safa", Ar = "صفا" },
            new Name { En = "Tayiba", Ar = "طيبة" },
            new Name { En = "Ula", Ar = "عُلا" },
            new Name { En = "Vian", Ar = "فيان" },
            new Name { En = "Wajd", Ar = "وجد" },
            new Name { En = "Yola", Ar = "يولا" },
            new Name { En = "Zaina", Ar = "زينة" }
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
