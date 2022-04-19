using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Ternarybrkcont
    {
		public static void Main()
		{
			int number = 2;
			bool isEven;

			isEven = (number % 2 == 0) ? true : false;
			Console.WriteLine(isEven);

            ///

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i+"\n");
                i++;
                if (i == 4)
                {
                    break;
                }
            }
            ///
            int j = 0;
            while (j < 10)
            {
                if (j == 4)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(j);
                j++;
            }

        }
	
	}
   
}

