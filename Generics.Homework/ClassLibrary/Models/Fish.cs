using ClassLibrary.Models.BaseEntity;

namespace ClassLibrary.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public Fish(string name, string type, int age, string color, string size) : base(name, type, age)
        {
            Name = name;
            Type = type;
            Age = age;
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nType:{Type}\nAge:{Age} years old\nColor: {Color}\nSize: {Size}");
        }
    }
}
