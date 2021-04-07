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
            int PRESENT = 1;
            int EMP_RATE_PER_HR = 20;

            //local variables
            int empHrs = 0;
            int empwage = 0;

            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 2);

            Console.WriteLine("random value " + employeeCheck);
            //selection statements

            if (employeeCheck == PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            //computation
            empwage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("emp wage per day " + empwage);
            Console.Read(); ;
        }
    }
}
