using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Nnatural
    {
        static void Main()
        {
            int i, num = 10, sum = 0;

            i = 1;
            while (i <= num)
            {
                sum = sum + i;
                i++;
            }

            Console.WriteLine("Sum of first " + num +
            " natural numbers = " + sum);
        }
    }
}
