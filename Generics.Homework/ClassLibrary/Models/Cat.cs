using ClassLibrary.Models.BaseEntity;

namespace ClassLibrary.Models
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, string type, int age, bool isLazy, int lives) : base(name, type, age)
        {
            Name = name;
            Type = type;
            Age = age;
            IsLazy = isLazy;
            LivesLeft = lives;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nType: {Type}\nAge: {Age}\nLazy Status: {IsLazy}\nLives Left: {LivesLeft}");
        }
    }
}
