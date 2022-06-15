using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class EmpWage
    {
        public static void CheckEmpWage()
        {
            int FullTime = 1;
            int Absent = 0;
            int EmpWagePerHour = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            int Attendence = random.Next(0, 2);
            if (Attendence==FullTime)
            {
                Console.WriteLine("Employee is Present");
                EmpHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * EmpWagePerHour;
            Console.WriteLine("Employee Daily Wage is : " +EmpWage);
        }
    }
}
