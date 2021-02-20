using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMarcus_PersonStudentsTeacher.Models
{
    public class Teacher : Person
    {
        public School School { get; set; }

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine($"I am teaching in {School.Name} in {School.City}");
        }
    }
}
