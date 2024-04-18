using ClassLibrary.Models.BaseEntity;

namespace ClassLibrary.Models
{
    public class MotorBike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a motorbike and I drive on 2 wheels");
        }
    }
}
