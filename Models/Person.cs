using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMarcus_PersonStudentsTeacher.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old");
        }

    }
}
