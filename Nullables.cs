using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Nullables
    {
        public static void Main()
        {
            int? n1 = null;
            int? n2 = 47;
            Nullable<int> n = null;
            Nullable<int> n3 = 457;
            Console.WriteLine("N1 is:{0}", n1 );
            Console.WriteLine("Null Values are:{0} and {1}", n2 + ("\n"), n3);

            //Colaesing operator
            string? a = null;
            string? b = "Dlithe";
            string? c;
            c = a ?? b;
            Console.WriteLine("C is:{0}", c);
            c = a ?? "Bootcamp";
            Console.WriteLine("C is:{0}", c);

        }

    }
}
