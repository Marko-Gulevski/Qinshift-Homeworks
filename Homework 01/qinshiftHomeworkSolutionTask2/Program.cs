// See https://aka.ms/new-console-template for more information


#region Task 02: Average Number

// Setting up the input numbers
Console.Write("Select the first number: ");
string firstNum = Console.ReadLine();
bool parsedOne = int.TryParse(firstNum, out int numberOne);

Console.Write("Select the second number: ");
string secondNum = Console.ReadLine();
bool parsedTwo = int.TryParse(secondNum, out int numberTwo);

Console.Write("Select the third number: ");
string thirdNum = Console.ReadLine();
bool parsedThree = int.TryParse(thirdNum, out int numberThree);

Console.Write("Select the fourth number: ");
string fourNum = Console.ReadLine();
bool parsedFour = int.TryParse(fourNum, out int numberFour);

Console.WriteLine("The average of the four inputed numbers is: " + ((numberOne + numberTwo + numberThree + numberFour) / 4));

#endregion

Console.ReadLine();