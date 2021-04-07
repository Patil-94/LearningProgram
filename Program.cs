using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int Full_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;

            //local variables
            int empHrs = 0;
            int empWage = 0;

            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);

            Console.WriteLine("random value " + employeeCheck);
            //selection statements

            if (employeeCheck == Full_TIME)
            {
                empHrs = 8;
            }
            else
             if (employeeCheck  == PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            //computation
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Emp wage per day " + empWage);
            Console.Read(); ;
        }
    }
}
