using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class PascalTriangle
    {
        public static void Main()
        {
            int  c = 1, k, i, j;

          

            for (i = 0; i < 5; i++)
            {
                for (k = 1; k <= 5 - i; k++)
                    Console.Write("  ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - j + 1) / j;
                    Console.Write("{0}   ", c);
                }
                Console.Write("\n");
            }
        }
    }
}
