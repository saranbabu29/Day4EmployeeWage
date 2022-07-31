using System;

namespace Day4EmployeeWage
{
    class Program
    {
        public const int Wage_per_hour = 20;
        public const int WageFor100hr = 0;
        public const int WageForMonth = 1;
        
        static void Main(string[] args)
        {
            int emphr;
            int WagePerDay;
            int days=20;
            Random random = new Random();
            int value = random.Next(0,2);
           

            switch (value)
            {
                case WageFor100hr:
                    emphr = 100;
                    WagePerDay = emphr * Wage_per_hour;
                    Console.WriteLine("Wage for 100hr is " +WagePerDay);
                    break;
                case WageForMonth:
                    days = 20;
                    emphr = 8;
                    WagePerDay = emphr * Wage_per_hour;
                    Console.WriteLine("Wage for 20days is " + ( WagePerDay *days ));
                    break;
                default:
                    emphr = 0;
                    break;
            }
        }
    }
}