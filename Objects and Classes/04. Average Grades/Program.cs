using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace _04._Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
    
        public double AverageGrade // => Grades.Average();
        {
            get
            {
                double average = Grades.Average();
                return average;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());

            List<Student> studentsList = new List<Student>();

            while (studentCount-- > 0)
            {
                Student student = new Student();

                string[] studentsInfo = Console.ReadLine().Split();
                string studentName = studentsInfo[0];

                student.Name = studentName;
                student.Grades = studentsInfo.Skip(1).Select(double.Parse).ToList();

                studentsList.Add(student);
            }

            studentsList
                .Where(stud => stud.AverageGrade >= 5.00)
                .OrderBy(stud => stud.Name)
                .ThenByDescending(stud => stud.AverageGrade)
                .ToList()
                .ForEach(stud =>
                {
                    Console.WriteLine($"{stud.Name} -> {stud.AverageGrade:f2}");
                });


        }
    }
}
