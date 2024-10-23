using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevToo_ValeriaAllikTARpv23
{
    internal class Ulesanne3
    {
        public class Student
        {
            public string Name { get; set; }
            public List<int> Grades { get; set; }
        }

        public static void Ulesanne_3()
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Valeria Allik", Grades = new List<int> { 5, 4, 4, 5 } },
                new Student { Name = "Daria Halchenko", Grades = new List<int> { 4, 3, 4, 4 } },
                new Student { Name = "Sasha Semjonova", Grades = new List<int> { 4, 4, 5, 5 } },
                new Student { Name = "Maria Gorbunova", Grades = new List<int> { 5, 5, 5, 5 } }
            };

            List<string> stipendStudents = new List<string>();
            foreach (var student in students)
            {
                bool allGradesAreGood = student.Grades.All(grade => grade >= 4);
                if (allGradesAreGood)
                {
                    stipendStudents.Add(student.Name);
                }
            }

            Console.WriteLine("Õpilased, kes saavad stipendiumi: ");
            foreach (var name in stipendStudents)
            {
                Console.WriteLine(name);
            }
        }
    }
}

