using ClassLibrary.Models.BaseEntity;

namespace ClassLibrary.Models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and I do not have wheels");
        }
    }
}
