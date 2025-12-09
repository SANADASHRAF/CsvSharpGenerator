using System;

namespace csv.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string SchoolName { get; set; }
        public string StageName { get; set; }
        public string GradeName { get; set; }
        public string ClassName { get; set; }
        public string AcademicYear { get; set; }
        public string NationalId { get; set; }
        public string PassportNumber { get; set; }
        public string CommunicationLang { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string GrandName { get; set; }
        public string NickName { get; set; }
        public string NameInArabic { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Address { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Father Father { get; set; }
        public Mother Mother { get; set; }
    }
}
