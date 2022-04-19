using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class _1Darray
    {
        static void Main()
        {
            Console.WriteLine("Enter N for sum of Natural Numbers:");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int sum = 0;

            //calculating sum from 1 to n
            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Sum is: " + sum);
        }
    }
}
