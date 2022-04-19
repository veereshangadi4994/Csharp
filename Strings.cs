using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Strings
    {
        public static void Main()
        {
            stringMethods();
        }
        public static void stringMethods()
        {
            string s1 = "Hello";
            string s2 = "Welcome";

            //Length
            Console.WriteLine("Length " + s1.Length);
            //ToUpper
            Console.WriteLine("ToUpper " + s2.ToUpper());
            //ToLower
            Console.WriteLine("ToLower " + s1.ToLower());
            //concat
            string s = string.Concat(s1, s2);
            Console.WriteLine("Concat " + s);

            char[] ch = { 'D', 'L', 'I', 'T','H','E' };
            string s3 = new string(ch);
            Console.WriteLine(s3);

            string s4 = "Welocome to Dlithe BootCamp";
            Console.WriteLine("IndexOf " + s4.IndexOf('l'));

            string s5 = "Welcome";
            //equlas
            bool s6 = s2.Equals(s5);
            Console.WriteLine("Equals " + s6);




        }
    }
}
