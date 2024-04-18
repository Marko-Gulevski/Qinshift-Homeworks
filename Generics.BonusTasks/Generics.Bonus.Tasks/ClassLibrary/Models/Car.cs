using ClassLibrary.Models.BaseEntity;

namespace ClassLibrary.Models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a car and I drive on 4 wheels");
        }
        
    }
}
