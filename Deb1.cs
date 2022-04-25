using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Deb1
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Value for A : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value for B : ");// Write line is added
            b = Convert.ToInt32(Console.ReadLine()); // Readline for a and b added
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            b = a / b;// varaible b was missing 
            a = a / b;

            Console.Write("After swap a= " + a + " b= " + b); // inspace of a b should there inspace of b a should there


        }
    }
}