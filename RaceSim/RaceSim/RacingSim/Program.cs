using ClassLibrary.Models;
#region Think you got what it takes to be the Downhill Champ?
// Car Objects
Car[] cars =
new Car[]{
   new Car("Mazda Speed 3", 225),
   new Car("Toyota Corolla", 235),
   new Car("Mitsubushi Lancer EVO", 255),
   new Car("Volkswagen Polo", 220)
};
// Driver Objects
Driver[] drivers = new Driver[]
{
        new Driver("Gojo Satoru", 92),
        new Driver("Geto Suguru", 89),
        new Driver("Kento Nanami", 85),
        new Driver("Mei Mei", 87),
};

static void RaceSim(Car[] cars, Driver[] drivers)
{
    while (true)
    {
        Console.Write($"Select a car: \n 1) {cars[0].CarModel}\n 2) {cars[1].CarModel}\n 3) {cars[2].CarModel}\n 4) {cars[3].CarModel}\n");
        string selectedCar = Console.ReadLine();
        bool selectedCarValidation = int.TryParse(selectedCar, out int pickedCar);
        if (!selectedCarValidation || pickedCar > 4 || pickedCar < 0)
        {
            Console.WriteLine("Input error");
            continue;
        }
        Console.Write($"Select a driver: \n 1) {drivers[0].Name}\n 2) {drivers[1].Name}\n 3) {drivers[2].Name}\n 4) {drivers[3].Name}\n");
        string selectedDriver = Console.ReadLine();
        bool selectedDriverValidation = int.TryParse(selectedDriver, out int pickedDriver);
        if (!selectedDriverValidation || pickedDriver > 4 || pickedDriver < 0)
        {
            Console.Clear();
            Console.WriteLine("Input error");
            continue;
        }
        Car firstCar = new Car(cars[pickedCar - 1].CarModel, cars[pickedCar - 1].CarSpeed, drivers[pickedDriver - 1]);

        Console.Write($"Select a rival car: \n 1) {cars[0].CarModel}\n 2) {cars[1].CarModel}\n 3) {cars[2].CarModel}\n 4) {cars[3].CarModel}\n");
        string selectedRivalCar = Console.ReadLine();
        bool validateRivalCar = int.TryParse(selectedRivalCar, out int rivalCar);
        if (!validateRivalCar)
        {
            Console.Clear();
            Console.WriteLine("Input error");
            continue;
        }
        Console.Write($"Select a rival: \n 1) {drivers[0].Name}\n 2) {drivers[1].Name}\n 3) {drivers[2].Name}\n 4) {drivers[3].Name}\n");
        string selectedRival = Console.ReadLine();
        bool validateRival = int.TryParse(selectedRival, out int rival);
        if (!validateRival || rival > 4 || rival < 0)
        {
            Console.WriteLine("Input error");
            continue;
        }
        Car secondCar = new Car(cars[rivalCar - 1].CarModel, cars[rivalCar - 1].CarSpeed, drivers[rival - 1]);
        if (CarAndDriverEligibility(firstCar, secondCar))
        {
            Console.Clear();
            Console.WriteLine("You have either selected the same Car Model or the same Driver for both cars. Please try again!\n");
            continue;
        }
        RaceWinner(firstCar, secondCar);
        Console.Write("Hit the streets one more time? (Y/N): ");
        string answerYesOrNo = Console.ReadLine();
        if (answerYesOrNo.ToLower() == "y")
        {
            Console.Clear();
            RaceSim(cars, drivers);
        }
        else if (answerYesOrNo.ToLower() == "n")
        {
            break;
        }
    }
}

RaceSim(cars, drivers);


// Making sure that we don't have the same driver or same car
static bool CarAndDriverEligibility(Car firstCar, Car secondCar)
{
    if (firstCar.CarModel == secondCar.CarModel || firstCar.Driver == secondCar.Driver)
    {
        return true;
    }
    return false;
}

// Getting the race winner

static void RaceWinner(Car firstCar, Car secondCar)
{
    if (firstCar.CalculateSpeed(firstCar.Driver, firstCar.CarSpeed) > secondCar.CalculateSpeed(secondCar.Driver, secondCar.CarSpeed))
    {
        Console.WriteLine($"The {firstCar.CarModel} driven by {firstCar.Driver.Name} at a pace of {firstCar.CarSpeed}km/h beat the {secondCar.CarModel} driven by {secondCar.Driver.Name} at a pace of {secondCar.CarSpeed}km/h");
    }
    else if (firstCar.CalculateSpeed(firstCar.Driver, firstCar.CarSpeed) < secondCar.CalculateSpeed(secondCar.Driver, secondCar.CarSpeed))
    {
        Console.WriteLine($"The {secondCar.CarModel} driven by {secondCar.Driver.Name} at a pace of {secondCar.CarSpeed}km/h beat the {firstCar.CarModel} driven by {firstCar.Driver.Name} at a pace of {firstCar.CarSpeed}km/h");
    }
    else
    {
        Console.WriteLine("The race is a draw! Not even the finish line could match these drivers' burnout!");
    }
}


#endregion