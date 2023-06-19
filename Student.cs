using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV0
{
    internal class Student : Person
    {
        public string ID { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student(string id, string name) : base(name, 0)
        {
            ID = id;
            Subjects = new List<Subject>();
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
            Console.WriteLine("Subject " + subject.Name + " added for student " + Name);
        }

        public void RemoveSubject(Subject subject)
        {
            Subjects.Remove(subject);
            Console.WriteLine("Subject " + subject.Name + " removed for student " + Name);
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Student ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Subjects:");
            foreach (var subject in Subjects)
            {
                Console.WriteLine("- " + subject.Name);
            }
        }

    }
}
