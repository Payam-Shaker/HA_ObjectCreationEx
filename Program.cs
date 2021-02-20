using System;
using System.Collections.Generic;
using OOPMarcus_PersonStudentsTeacher.Enums;
using OOPMarcus_PersonStudentsTeacher.Models;

namespace OOPMarcus_PersonStudentsTeacher
{
    /// <summary>
    /// This class defines obj creatione using collection and methods.
    /// </summary>
    class Program
    {
        private static List<Person> People = new List<Person>();
        private static List<School> Schools = new List<School>();



        static void Main()
        {

            NewStudent("Peter Parker", 15, Grades.VG);
            NewStudent("Flash Thompson", 17, Grades.Superhacker);
            NewStudent("Liz Allan", 17, Grades.G);
            NewStudent("Sally Avril", 16, Grades.VG);
            NewStudent("Jessica Jones", 15, Grades.VG);

            NewTeacher("Ms. Carlyle", 37, "Midtown High School", "Queens, New York");
            NewTeacher("Stanley Lieber", 42, "Midtown High School", "Queens, New York");


            foreach (var person in People)
            {

                //Console.WriteLine(person.Name + "(" + person.Age + ")");
                //if (person is Teacher)
                //{
                //    var tmp = person as Teacher;
                //    Console.WriteLine(" Jobbar på " + tmp.School.Name + ", " + tmp.School.City);
                //}
                //if (person is Student)
                //{
                //    var tmp = person as Student;
                //    Console.WriteLine(" och har betyg " + tmp.Grades.ToString());
                //}
                person.Greet();

            }

        }

        private static School GetSchool(string school, string city)
        {
            school = school.Trim();
            city = city.Trim();

            foreach (var item in Schools)
            {
                //if (item.City.ToLower() == city.ToLower() && item.Name.ToLower() == school.ToLower())
                
                // another way to compair between caps and lower cases. 
                if (string.Equals(item.City, city, StringComparison.OrdinalIgnoreCase) && 
                    string.Equals(item.Name, school, StringComparison.OrdinalIgnoreCase))
                {
                     return item;
                }
                    
            }
            var newSchool = new School { City = city, Name = school };
            Schools.Add(newSchool);
            return newSchool;
        }

        private static void NewTeacher(string name, int age, string school, string city)
        {
            People.Add(
                new Teacher {
                    Name = name,
                    Age = age,
                    School = new School { Name = school, City = city }
                });
        }

        private static void NewStudent(string name, int age, Grades grades)
        {
            People.Add(
                new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                }
                );
        }

    }

}
