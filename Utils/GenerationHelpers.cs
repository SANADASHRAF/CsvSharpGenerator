using System;
using System.Linq;

namespace csv.Utils
{
    public static class GenerationHelpers
    {
        private static HashSet<string> GeneratedEmails = new HashSet<string>();
        private static HashSet<string> GeneratedSaudiIds = new HashSet<string>();


        private static readonly Random rand = new Random();

        public static string GenerateSaudiPhoneNumber()
        {
            int firstDigit = 5;
            int remaining = rand.Next(100000000, 999999999);
            return  firstDigit + remaining.ToString();
        }

        public static string GeneratePassword(int length = 10)
        {
            //const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //const string lower = "abcdefghijklmnopqrstuvwxyz";
            //const string digits = "0123456789";
            //const string special = "!@#$%^&*()";

            //char[] password = new char[length];
            //password[0] = upper[rand.Next(upper.Length)];
            //password[1] = lower[rand.Next(lower.Length)];
            //password[2] = digits[rand.Next(digits.Length)];
            //password[3] = special[rand.Next(special.Length)];

            //string allChars = upper + lower + digits + special;
            //for (int i = 4; i < length; i++)
            //    password[i] = allChars[rand.Next(allChars.Length)];

            //return new string(password.OrderBy(x => rand.Next()).ToArray());
            return new string("Soft@1234");
        }

        //public static string GenerateEmail(string firstName, string lastName)
        //{
        //    string domain = "@example.com";
        //    return $"{firstName.ToLower()}.{lastName.ToLower()}{rand.Next(100, 999)}{domain}";
        //}
        public static string GenerateEmail(string firstName, string lastName)
        {
            string domain = "@example.com";
            string email;

            do
            {
                email = $"{firstName.ToLower()}.{lastName.ToLower()}{rand.Next(100, 999)}{domain}";
            }
            while (!GeneratedEmails.Add(email)); // Add returns false if exists ? loop again

            return email;
        }
        //public static string GenerateSaudiNationalId()
        //{
        //    var first = Random.Shared.Next(1, 3).ToString();

        //    var rest = Random.Shared.NextInt64(100000000, 999999999).ToString();

        //    return first + rest;
        //}
        public static string GenerateSaudiNationalId()
        {
            string nationalId;

            do
            {
                string first = Random.Shared.Next(1, 3).ToString();
                string rest = Random.Shared.NextInt64(100000000, 999999999).ToString();
                nationalId = first + rest;
            }
            while (!GeneratedSaudiIds.Add(nationalId)); // ???? ???????

            return nationalId;
        }
    }
}
