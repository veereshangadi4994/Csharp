using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Paramsarray
    {
       public static int add(params int[] allnumber)
        {
            int sum = 0;
            foreach (int n in allnumber)
            {
                sum = sum + n;
            }
            return sum;
        }
       public static void Main(string[] args)
        {
            int sum;
            sum = Paramsarray.add(1,2,3,4,5,6,7,8,9,0);
            Console.WriteLine("Sum of Natural Numbers:\t{0}", sum);
        }
    }
}
