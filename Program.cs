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
            int present = 1;
            Random random = new Random();
            int employeecheck = random.Next(0, 2);
            Console.WriteLine("random value" + employeecheck);
            if (employeecheck == present)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.Read();
        }
    }
}
