using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class matrix2D
    {
        public static void Main()
        {
            int i, j, n;
            int[,] arr1 = new int[20, 20];
            int[,] arr2 = new int[20, 20];
            int[,] arr3 = new int[20, 20];
           
            n = 3;
            Console.WriteLine("Enter elements in the first matrix:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements in the second matrix:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
          
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
            Console.WriteLine("\nAdding two matrices: \n");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < n; j++)
                    Console.WriteLine("{0}\t", arr3[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}
