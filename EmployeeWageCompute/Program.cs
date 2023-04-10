using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    public class Program
    {
            static void Main(string[] args)
            {

                const int IS_PART_TIME = 1;
                const int IS_FULL_TIME = 2;
                const int EMP_RATE_PER_HOUR = 20;
                const int NUM_OF_WORKING_DAYS = 20;
                int empHrs = 0;
                int empWage = 0;
                int totalEmpWage = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
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
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    totalEmpWage += empWage;
                    Console.WriteLine("Employee wage is:" + empWage);
                }
                Console.WriteLine("Total Emp Wage :" + totalEmpWage);
                Console.ReadLine();
            }
        }
    }
