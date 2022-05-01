using System;

namespace EmpWageComputationUsingMethods
{
    internal class Program
    {
        int isPresent = 1;
        int randomCheck;
        public void EmpAttendance()
        {
            Random random = new Random();
            randomCheck = random.Next(2);
            if (randomCheck == isPresent)
            {
                Console.WriteLine("The Employee is Present ");
            }
            else
            {
                Console.WriteLine("The Employee is Absent ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("----------------- WELCOME TO THE EMPLOYEE WAGE COMPUTATION IN CLASSES AND METHODS --------------");
            Console.WriteLine();
            Program prog = new Program();
            prog.EmpAttendance();
        }
    }
}
