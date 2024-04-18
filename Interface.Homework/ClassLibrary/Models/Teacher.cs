using ClassLibrary.Interfaces;
using ClassLibrary.Models.BaseEntity;

namespace ClassLibrary.Models
{
    public class Teacher : User, ITeacher
    {
        public string[] Subjects { get; set; }
        public Teacher(int id, string name, string username, string[] subjects) : base(id, name, username)
        {
            Id = id;
            Name = name;
            Username = username;
            Subjects = subjects;
        }

        public void PrintSubjects()
        {
            foreach (string subject in Subjects)
            {
                Console.WriteLine($"Subject: {subject}");
            }
        }

        public override void PrintUser()
        {
            Console.WriteLine($"There are currently {Subjects.Length} subjects");
        }
    }
}
