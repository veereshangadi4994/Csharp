﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Debug1
    {
        public static void Main() // M is upper case
        {
            int i, j;
            int[,] arr1 = new int[3, 3]; //Missing a comma in Array

            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
            Console.Write("-----------------------------------------\n");


            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)//Missing semicolon before for loop and condition should be i<3
            {
                for (j = 0; j < 3; j++)// condition should be j<3
                {
                    Console.Write("element - [{0}] : ", i, j); // for Console uppercase C
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine()); // To Seperate a rows & columns Variable using  Single Square bracket
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++) // initialization is required for variable i
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");// Missing Semicolon
        
   }
    }

}

