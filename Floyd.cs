using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Floyd
    {

        public static void Main()
        {
            int num = 0;
           

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num + "\t");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}
