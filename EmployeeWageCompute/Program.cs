using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    public class Program
    {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            const int MAX_HRS_IN_MONTH = 10;
            static void Main(string[] args)
            {


                int empHrs = 0;
                int totalworkingDays = 10;
                int totalEmpHrs = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalworkingDays < NUM_OF_WORKING_DAYS)
                {
                    //UC4 Switch Case
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;

                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day#:" + totalworkingDays + "Emp Hrs :" + empHrs);
                }
                int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Emp Wage :" + totalEmpWage);
                Console.ReadLine();
            }
        }
    }

