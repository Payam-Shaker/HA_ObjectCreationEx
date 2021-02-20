using System;
using System.Collections.Generic;
using System.Text;
using OOPMarcus_PersonStudentsTeacher.Enums;

namespace OOPMarcus_PersonStudentsTeacher.Models
{
    public class Student : Person
    {
        public Grades Grades { get; set; }

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine($"My new grade is {Grades}");
        }
    }
}
