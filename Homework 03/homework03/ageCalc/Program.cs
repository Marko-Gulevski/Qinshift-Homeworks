#region Age Calculator

// Note for user: The input should go month/day/year

Console.WriteLine("Enter your date of birth: ");
string inputedDate = Console.ReadLine();

static int AgeCalc(string birthDate)
{
    DateTime currentDate = DateTime.Now;
    string dateOfBirth = birthDate;
    DateTime finalizedDate = DateTime.Parse(dateOfBirth);
    int result = 0;
    if (finalizedDate.Month > currentDate.Month && finalizedDate.Year == currentDate.Year)
    {
        result += (currentDate.Year - finalizedDate.Year) - 1;
        Console.WriteLine("You are " + result + " years old");
    }
    else if (finalizedDate.Day == currentDate.Day && finalizedDate.Month == currentDate.Month)
    {
        result += currentDate.Year - finalizedDate.Year;
        Console.WriteLine("Congratulations! Today you are turning " + result + "! Happy Birthday!");
    }
    else if (finalizedDate.Month == currentDate.Month && finalizedDate.Day == (currentDate.Day + 1))
    {
        result += currentDate.Year - finalizedDate.Year;
        Console.WriteLine("Tomorrow you will be " + result + " years old! You must be really excited!");

    }
    else if (finalizedDate.Month == currentDate.Month && finalizedDate.Day == (currentDate.Day - 1))
    {
        result += currentDate.Year - finalizedDate.Year;
        Console.WriteLine("Yesterday you turned " + result + " years old! Congratulations on making it so far <3");
    }
    else
    {
        result += currentDate.Year - finalizedDate.Year;
        Console.WriteLine("You are " + result + " years old");
    }
    return result;
}

AgeCalc(inputedDate);

#endregion