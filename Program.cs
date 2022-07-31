using System;

namespace Day4EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int EmpPresent = 1;

            Random random = new Random();
            int value = random.Next(0,2);

            if (value == EmpPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
