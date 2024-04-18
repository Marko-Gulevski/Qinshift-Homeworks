using ClassLibrary.Interfaces;
using ClassLibrary.Models.BaseEntity;

namespace ClassLibrary.Models
{
    public class Student : User, IStudent
    {
        public int[] Grades { get; set; }

        public Student(int id, string name, string username, int[] grades) : base(id, name, username)
        {
            Id = id;
            Name = name;
            Username = username;
            Grades = grades;
        }

        public void PrintGrades()
        {
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }

        public static double AverageGrades(int[] grades)
        {
            double gradeAverage = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                gradeAverage += grades[i];
            }
            return gradeAverage / grades.Length;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"ID: {Id}\n Name: {Name}\n Username: {Username}\n Average Grade: {AverageGrades(Grades)}");
        }
    }
}
