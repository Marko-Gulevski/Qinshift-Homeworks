#region Exercise 05: Declare a new array of intergers with 5 elements and sum all the values and print the result in the console

Console.Write("Input the first number: ");
string takeFirstInput = Console.ReadLine();
bool isFirstInputLegit = int.TryParse(takeFirstInput, out int finalizedFirstInput);


Console.Write("Input the second number: ");
string takeSecondaryInput = Console.ReadLine();
bool isSecondInputLegit = int.TryParse(takeSecondaryInput, out int finalizedSecondInput);


Console.Write("Input the third number: ");
string takeThirdInput = Console.ReadLine();
bool isThirdInputLegit = int.TryParse(takeThirdInput, out int finalizedThirdInput);


Console.Write("Input the fourth number: ");
string takeFourthInput = Console.ReadLine();
bool isFourthInputLegit = int.TryParse(takeFourthInput, out int finalizedFourthInput);

Console.Write("Input the fifth number: ");
string takeFifthInput = Console.ReadLine();
bool isFifthInputLegit = int.TryParse(takeFifthInput, out int finalizedFifthInput);

if (!isFirstInputLegit || !isSecondInputLegit || !isThirdInputLegit || !isFourthInputLegit || isFifthInputLegit)
{
    Console.WriteLine("The input you have entered does not equate to an interger");
}

int result = 0;

int[] arrayOfInputedIntergers = {finalizedFirstInput,finalizedSecondInput,finalizedThirdInput,finalizedFourthInput,finalizedFifthInput};

for(int i = 0;i < arrayOfInputedIntergers.Length; i++)
{
    result += arrayOfInputedIntergers[i];
}
    
Console.WriteLine("The result is: " + result);

#endregion
