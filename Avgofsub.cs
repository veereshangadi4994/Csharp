using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Avgofsub
    {
        public static void Main(string[] args)
        {
            double rl, per, phy, che, ca, total;
            string grade;

            Console.Write("Input  the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application : ");
            ca = Convert.ToInt32(Console.ReadLine());

            total = phy + che + ca;
            per = total / 3.0;
            if (per >= 60)
                grade = "First";
            else
            if (per < 60 && per >= 48)
                grade = "Second";
            else
                if (per < 48 && per >= 36)
                grade = "Pass";
            else
                grade = "Fail";

            Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, ca);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nGrade = {2}\n", total, per, grade);

        }
    }
}