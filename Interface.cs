using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class interface1
    {
       
      
        interface calc3
        {
            int arearect(int l, int b);
        }
       
        class Calculation :  calc3
        {
            
           
            public int area;
            public int arearect(int l, int b)
            {
                return area = l * b;
            }
         
     
            class Program
            {
                static void Main()
                {
                    Calculation c = new Calculation();
                   
                    c.arearect(5, 2);
                   
                    Console.WriteLine("concept Using Interfaces :\n ");
                     Console.WriteLine(" Area :" + c.area);
                       Console.ReadKey();
                }
            }
        }
    }
}

