// See https://aka.ms/new-console-template for more information
#region Task 03: Swapping Numbers


Console.Write("Select first Number: ");
string numberOne = Console.ReadLine();
bool parsedOne = int.TryParse(numberOne, out int numOne);
Console.Write("Select second Number: ");
string numberTwo = Console.ReadLine();
bool parsedTwo = int.TryParse(numberTwo, out int numTwo);

Console.WriteLine("The values before the swap are: " + "A:" + numOne + " " + "B:" + numTwo);

numTwo = Convert.ToInt32(numberOne);
numOne = Convert.ToInt32(numberTwo);
Console.WriteLine(numTwo.GetType());

Console.WriteLine("The values after the swap are: " + "A:" + numOne + " " + "B:" + numTwo);


#endregion

Console.ReadLine();