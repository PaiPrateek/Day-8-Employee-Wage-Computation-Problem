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
            Random random = new Random();
            int Attendence = random.Next(0, 2);
            if (Attendence==FullTime)
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
