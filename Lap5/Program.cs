using System;

namespace Lap5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HighSchoolTeacher()
            {
                IdentityNumber = "ID001",
                    Name = "Strong Hero",
                    BaseSalary = 100,
                    Level = 1,
                    Bonus = 1,
                    IsSenior = false,
                    HighSchoolCode = "HS001"

                };
                Console.WriteLine(highSchoolTeacher.CalculateSalary());
                var universityTeacher = new UniversityTeacher
                {
                IdentityNumber = "ID002",
                Name = "Strong",
                BaseSalary = 120,
                Level = 2,
                Bonus = 9000,
                IsSenior = true,
                EnglishLevel = 2,
                UniversityCode = "UN001"
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());
            
        }
    }
}