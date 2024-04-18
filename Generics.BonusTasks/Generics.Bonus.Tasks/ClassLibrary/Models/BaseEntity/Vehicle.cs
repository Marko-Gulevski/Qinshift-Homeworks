namespace ClassLibrary.Models.BaseEntity
{
    public abstract class Vehicle
    {
        public abstract void DisplayInfo();
    }

    public static class FunctionalityClass
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("The car is driving");
        }

        public static void Wheelie(this MotorBike bike)
        {
            Console.WriteLine("The bike is doing a wheelie");
        }

        public static void Sail(this Boat boat)
        {
            Console.WriteLine("The boat is sailing");
        }

        public static void Fly(this Airplane plane)
        {
            Console.WriteLine("The airplane is flying");
        }
    }
}
