using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class instance
    {
        public class Constructors
        {
            public int Stdid;
            public string Stdname;

            public Constructors()
            {
                Stdid = 101;
                Stdname = "Mahesh";

            }
            public void Display()
            {
                Console.WriteLine("Student id is:{0}", Stdid);
                Console.WriteLine("Student Name is:{0}", Stdname);
            }
            public static void Main()
            {
                Constructors c = new Constructors();

                c.Display();

            }


        }
    }
}