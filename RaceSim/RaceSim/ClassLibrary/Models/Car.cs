using ClassLibrary.Models;

namespace ClassLibrary.Models
{
    public class Car
    {
        public string CarModel { get; set; }
        public int CarSpeed { get; set; }
        public Driver Driver { get; set; }

        public Car(string carModel, int carSpeed)
        {
            CarModel = carModel;
            CarSpeed = carSpeed;
        }

        public Car(string carModel, int carSpeed, Driver driver)
        {
            CarModel=carModel;
            CarSpeed = carSpeed;
            Driver = driver;
        }

        public int CalculateSpeed(Driver driver, int carSpeed)
        {
            int speed = driver.Skill * carSpeed;
            return speed;
        }
    }
}
