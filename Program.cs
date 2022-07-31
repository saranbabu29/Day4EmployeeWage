using System;

namespace Day4EmployeeWage
{
    class Program
    {
        public const int Wage_per_hour = 20;
        public const int is_FullTime = 0;
        public const int is_PartTime = 1;
        
        static void Main(string[] args)
        {
            int emphr;
            int dailyWage;
            int days=20;
            Random random = new Random();
            int value = random.Next(0,2);
           

            switch (value)
            {
                case is_FullTime:
                    emphr = 8;
                    dailyWage = emphr * Wage_per_hour;
                    Console.WriteLine("Employee is FullTime and Wage is " +( dailyWage * days));
                    break;
                case is_PartTime:
                    emphr = 4;
                    dailyWage = emphr * Wage_per_hour;
                    Console.WriteLine("Employee is PartTime and Wage is " + (dailyWage*days));
                    break;
                default:
                    emphr = 0;
                    break;
            }
        }
    }
}
