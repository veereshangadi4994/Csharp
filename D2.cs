using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class D2
    {

         int result; //int result was not initialised
        D2()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)// exception e is initialised
            {
                Console.WriteLine("Exception caught:{0} ", e); // interpolation
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main()
        {
            D2 d = new D2();
            d.division(5, 0);//values
            Console.ReadKey();
        }
    }

}
