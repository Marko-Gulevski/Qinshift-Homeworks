using ClassLibrary.Models;
using ClassLibrary.Models.BaseEntity;

Vehicle car = new Car();
car.DisplayInfo();
Vehicle motorBike = new MotorBike();
motorBike.DisplayInfo();
Vehicle boat = new Boat();
boat.DisplayInfo();
Vehicle plane = new Airplane();
plane.DisplayInfo();

#region Bonus Task 03
((Car)car).Drive();
((MotorBike)motorBike).Wheelie();
((Boat)boat).Sail();
((Airplane)plane).Fly();
#endregion