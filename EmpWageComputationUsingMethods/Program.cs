using System;

namespace EmpWageComputationUsingMethods
{
    internal class Program
    {
        int isPresent = 1;
        int isPartTime = 1;
        int isFullTime = 2;
        int empRatePerHrs = 20;
        int totalWorkingDays = 20;
        int totalWorkingHrs = 100;
        int empHr = 0;
        int empDailyWage = 0;
        int workingDays = 0;
        int totalSalary = 0;
        int totalHrs = 0;
        int workingDay = 0;
        int workingHr = 0;
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
        public void UC_3_PartTimeEmpWage()
        {
            Console.WriteLine("UC 3 Part time Employee wages ::");
            Random random = new Random();
            randomCheck = random.Next(3);
            if (isPartTime == 1)
            {
                Console.WriteLine("Employee is present part time ");
                empHr = 4;
            }
            else if (isFullTime == 2)
            {
                Console.WriteLine("Employee is present full time ");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent ");
                empHr = 0;
            }
            empDailyWage = empHr * empRatePerHrs;
            Console.WriteLine("Employee Daily Wage = " + empDailyWage);
            Console.WriteLine();
        }
        public void UC_4_SwitchCase()
        {
            Console.WriteLine("UC 4 Employee Daily Wage Using Switch case :: ");
            int randomCheck = random.Next(3);
            switch (randomCheck)
            {
                case 1:
                    empHr = 8;
                    break;
                case 2:
                    empHr = 4;
                    break;
                default:
                    empHr = 0;
                    break;
            }
            empDailyWage = empRatePerHrs * empHr;
            Console.WriteLine("By Switch Case salary is = " + empDailyWage);
            Console.WriteLine();
        }
        public void UC_5_EmpWagesForMonth()
        {
            Console.WriteLine("UC 5 Employee Wage For Month :: ");
            for (int day = 1; day <= totalWorkingDays; day++)
            {
                randomCheck = random.Next(3);
                switch (randomCheck)
                {
                    case 1:
                        Console.WriteLine("Full Day : ");
                        empHr = 8;
                        break;
                    case 2:
                        Console.WriteLine("Half Day : ");
                        empHr = 4;
                        break;
                    default:
                        Console.WriteLine("Absent : ");
                        empHr = 0;
                        break;
                }
                empDailyWage = empRatePerHrs * empHr;
                totalSalary = totalSalary + empDailyWage;
                Console.WriteLine("Day : " + day +" Employee Wage  = "+totalSalary);
                Console.WriteLine();
            }
            Console.WriteLine("Employee Wage For Month = "+totalSalary);
            Console.WriteLine();
        }
        public void UC_6_WorkingHrsAndDayForMonth()
        {
            Console.WriteLine("UC 6 Employee Wage Till a Condition :: ");
            while (workingHr <= totalWorkingHrs && workingDays < totalWorkingDays)
            {
                workingDays++;
                int randomCheck = random.Next(3);
                switch (randomCheck)
                {
                    case 1:
                        Console.WriteLine("full day  : ");
                        empHr = 8;
                        break;
                    case 2:
                        Console.WriteLine("Half day  : ");
                        empHr = 4;
                        break;
                    default:
                        Console.WriteLine("Absent : ");
                        empHr = 0;
                        break;
                }
                workingHr = workingHr + empHr;
                Console.WriteLine("Days : " + workingDays + " - Emp Working hours : " + workingHr);
                totalHrs += empHr;
            }
            Console.WriteLine("Total Hours = "+totalHrs);
            totalSalary = workingHr * empRatePerHrs;
            Console.WriteLine("Total Salary For Month = " + totalSalary);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("----------------- WELCOME TO THE EMPLOYEE WAGE COMPUTATION IN CLASSES AND METHODS --------------");
            Console.WriteLine();

            Program prog = new Program();
            prog.UC_1_EmpAttendance();
            prog.UC_2_EmpDailyWage();
            prog.UC_3_PartTimeEmpWage();
            prog.UC_4_SwitchCase();
            prog.UC_5_EmpWagesForMonth();
            prog.UC_6_WorkingHrsAndDayForMonth();
        }
    }
}
