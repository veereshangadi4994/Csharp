using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Bitwise
    {
        static void Main(string[] args)
        {
            int a = 2;           
            int b = 3;          
            int c = 0;

            c = a & b;           
            Console.WriteLine("Value of c after A and B is {0}", c);

            c = a | b;          
            Console.WriteLine(" Value of c after A OR B is {0}", c);

            c = a ^ b;         
            Console.WriteLine(" Value of c after A Xor B is {0}", c);

            c = a << 2;    
            Console.WriteLine("Value of c after left shift is {0}", c);

            c = a >> 2;     
            Console.WriteLine("Value of c after right shift is {0}", c);
            Console.ReadLine();
        }
    }
}

