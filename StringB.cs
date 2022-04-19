using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class StringB
    {
        public static void Main()
        {

           
            StringBuilder s = new StringBuilder("Hello Everyone "+"\n");
         
           
            //Append 
            s.Append(" Welcome To C# " + "\n");

          //Append Line
            s.AppendLine("End of Append Line" + "\n");




            //Insert
            s.Insert(15, "\n"+ " Welcome to Dlithe BootCamp");


            //Remove
            s.Remove(5, 11);
           
            //Display
            Console.WriteLine(s);
        }
    }
}
