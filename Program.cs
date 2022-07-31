using System;

namespace Day4EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int EmpPresent = 1;
            int Wage_per_hour = 20;
            int Emphr = 8;

            Random random = new Random();
            int value = random.Next(0,2);

            if (value == EmpPresent)
            {
                Console.WriteLine("Employee is Present and Wage is " +(Emphr*Wage_per_hour));
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
