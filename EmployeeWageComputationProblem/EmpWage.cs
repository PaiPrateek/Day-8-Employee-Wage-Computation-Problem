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
            int PartTime = 2;
            int EmpWagePerHour = 20;
            int WorkingDaysPerMonth = 20;
            int EmpHrs = 0;
            int EmpWage = 0;
            int TotaklEmpWage = 0;
            int TotalWorkingDays = 0;
            int FullDay=0, AbsentDay=0, PartDay=0;
            for (int day = 0; day < WorkingDaysPerMonth; day++)
            {
                Random random = new Random();
                int Attendence = random.Next(0, 3);
                switch (Attendence)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        EmpHrs = 0;
                        AbsentDay++;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present (Full Time)");
                        EmpHrs = 8;
                        FullDay++;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Present (Part Time) ");
                        EmpHrs = 4;
                        PartDay++;
                        break;
                }
                Console.WriteLine("...............................");
                EmpWage = EmpHrs * EmpWagePerHour;
                TotaklEmpWage += EmpWage;
                Console.WriteLine("Employee Daily Wage is : " + EmpWage);

            }
            Console.WriteLine("Full Day Presence is :"+FullDay);
            Console.WriteLine("Part Time Presnece is : " + PartDay);
            Console.WriteLine("Absent is :" + AbsentDay);
            Console.WriteLine("Total Employee Wage is :" + TotaklEmpWage);  

        }
    }
}
