using System;

namespace Day4EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Wage_per_hour = 20;
            int is_partTime = 1;
            int Emphr;
            Random random = new Random();
            int value = random.Next(0,2);

            if (value == is_partTime)
            {
                Emphr = 8;
                Console.WriteLine("Employee is FullTime and Wage is " +(Emphr*Wage_per_hour));
            }
            else
            {
                Emphr = 4;
                Console.WriteLine("Employee is PartTime and Wage is " + (Emphr * Wage_per_hour));
            }
        }
    }
}
