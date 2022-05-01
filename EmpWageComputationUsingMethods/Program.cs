using System;

namespace EmpWageComputationUsingMethods
{
    internal class Program
    {
        int isPresent = 1;
        int isPartTime = 1;
        int isFullTime = 2;
        int empRatePerHrs = 20;
        int empHr = 0;
        int empDailyWage = 0;
        int randomCheck;
        Random random = new Random();
        public void UC_1_EmpAttendance()
        {
            Console.WriteLine("UC 1 Employee Attendance ::");
            randomCheck = random.Next(2);
            if (randomCheck == isPresent)
            {
                Console.WriteLine("The Employee is Present ");
            }
            else
            {
                Console.WriteLine("The Employee is Absent ");
            }
            Console.WriteLine();
        }
        public void UC_2_EmpDailyWage()
        {
            Console.WriteLine("UC 2 Employee Daily Waage ::");
            randomCheck = random.Next(2);
            if (randomCheck == isPresent)
            {
                Console.WriteLine("The Employee is Present ");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("The Employee is Absent ");
                empHr = 0;
            }
            empDailyWage = empHr * empRatePerHrs;
            Console.WriteLine("Employee Daily Wage = "+empDailyWage);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("----------------- WELCOME TO THE EMPLOYEE WAGE COMPUTATION IN CLASSES AND METHODS --------------");
            Console.WriteLine();

            Program prog = new Program();
            prog.UC_1_EmpAttendance();
            prog.UC_2_EmpDailyWage();
        }
    }
}
