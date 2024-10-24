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
            // Созданием список студентов с именами и оценками
            List<Student> students = new List<Student>
            {
                new Student { Name = "Valeria Allik", Grades = new List<int> { 5, 4, 4, 5 } },
                new Student { Name = "Daria Halchenko", Grades = new List<int> { 4, 5, 4, 4 } },
                new Student { Name = "Sasha Semjonova", Grades = new List<int> { 4, 4, 3, 5 } },
                new Student { Name = "Maria Gorbunova", Grades = new List<int> { 4, 3, 3, 5 } }
            };
            // Список для хранения имен студентов, которые могут получить стипендию
            List<string> stipendStudents = new List<string>();
            // Проходим по каждому студенту в списке
            foreach (var student in students)
            {
                // Проверяем, все ли оценки студента 4 или выше
                bool allGradesAreGood = student.Grades.All(grade => grade >= 4);
                // Если все оценки подходят условию, добавляем имя студента в список стипендиатов
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
