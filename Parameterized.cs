using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Parameterized
    {
        struct Student
        {
            public int stdid;
            public string stdname;
            
            public void GetDetails()
            {
                Console.WriteLine("Enter the STID and STDName");
                stdid = Convert.ToInt32(Console.ReadLine());
                stdname = Console.ReadLine();
            }
           
            public void DisplayDetails()
            {
                Console.WriteLine("Student ID is:{0}", stdid);
                Console.WriteLine("Student Name is:{0}", stdname);
            }
            
            public Student(int id, string name)
            {
                stdid = id;
                stdname = name;
                Console.WriteLine("Student details are:{0} and {1}", stdid, stdname);
            }
        }

            public static void Main()
            {
            Student std = new Student();
            Student std2 = new Student(1001, "Chetan");
            std.GetDetails();
            std.DisplayDetails();
            }
        }
    }

