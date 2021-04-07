using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    class Program
    {
        //constants
        public const  int Full_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        static void Main(string[] args)
        {
           //local variables
            int empHrs = 0;
            int empWage = 0;

            //inbuilt class
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);

            Console.WriteLine("random value " + employeeCheck);
            //selection statements

            switch (employeeCheck)
            {
                case Full_TIME:
                    empHrs = 8;
                    break;

                case PART_TIME:
                    empHrs = 4;
                    break;

                default:
                    empHrs = 0;
                    break;
            }
            //computation
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Emp wage per day " + empWage);
            Console.Read(); ;
        }
    }
}
