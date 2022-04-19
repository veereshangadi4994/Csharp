using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name:");
            string EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation");
            string EmpDesignation = Console.ReadLine();
            Console.WriteLine("Enter Employee ID:");
            int EmpID = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine("Employee Name is: " + EmpName);
            Console.WriteLine("Employee Designation is: " + EmpDesignation);
            Console.WriteLine("Employee ID is: " + EmpID);
        }
    }
}
