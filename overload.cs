using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class overload
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
                Console.WriteLine("Employee id is:{0}", Stdid);
                Console.WriteLine("Employee Name is:{0}", Stdname);
            }
           
            public Constructors(int a, int b) 
            {
                Console.WriteLine("Sum is:{0}", a + b);
            }
            public Constructors(int id, string name)
            {
                Console.WriteLine($"ID is {id} and Name is {name}");
            }
            public Constructors(string name, int id)
            {
                Console.WriteLine($"ID is {id} and Name is {name}");
            }
            public Constructors(string name, string id)
            {
                Console.WriteLine($"ID is {id} and Name is {name}");
            }
            public static void Main()
            {
                
                Constructors c = new Constructors();
                
                Constructors c1 = new Constructors(50, 30);
                
                Constructors c2 = new Constructors(50, "Ramesh");
                
                Constructors c3 = new Constructors("Rohit", 101);

                Constructors c4 = new Constructors("Ramesh", "Cs 101");
                
                c.Display();


            }



        }
    }
}
