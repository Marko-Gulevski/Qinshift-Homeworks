using ClassLibrary.Models.BaseEntity;

namespace ClassLibrary.Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavouriteFood { get; set; }

        public Dog(string name, string type, int age, bool isGoodBoy, string faveFood) : base(name, type, age)
        {
            Name = name;
            Type = type;
            Age = age;
            GoodBoy = isGoodBoy;
            FavouriteFood = faveFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nType:{Type}\nAge:{Age} years old\nGood Boy Status: {GoodBoy}\nFavourite Food: {FavouriteFood}");
        }
    }
}
