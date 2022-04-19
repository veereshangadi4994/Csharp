﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Jagged
    {
        public static void Main()
        {

            // Declare the Jagged Array of four elements:
            int[][] jagged_arr = new int[4][];

            // Initialize the elements
            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 11, 34, 67 };
            jagged_arr[2] = new int[] { 89, 23 };
            jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

            // Display the array elements:
            for (int n = 0; n < jagged_arr.Length; n++)
            {

                // Print the row number
               Console.WriteLine("Row({0}): ", n);

                for (int k = 0; k < jagged_arr[n].Length; k++)
                {

                    // Print the elements in the row
                  Console.WriteLine("{0} ", jagged_arr[n][k]);
                }
                Console.WriteLine();
            }
        }
    }


        
}
