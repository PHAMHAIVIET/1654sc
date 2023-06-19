using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV0
{
    internal class Teacher : Person
    {
       
        
           public string TeacherID { get; set; }

            public Teacher(string teacherID, string name, int age) : base(name, age)
            {
                TeacherID = teacherID;
            }

            public override void PrintInfo()
            {
                Console.WriteLine("Teacher ID: " + TeacherID);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
            }
        }
    };
