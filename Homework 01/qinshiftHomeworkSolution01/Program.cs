// See https://aka.ms/new-console-template for more information

#region Task 01: Real Calculator
// First Number Generation
Console.Write("Enter first number: ");
string firstInput = Console.ReadLine();
bool selectedNumberOne = int.TryParse(firstInput, out int firstNumber);

// Second Number Generation

Console.Write("Enter second number: ");
string secondInput = Console.ReadLine();
bool selectedNumberTwo = int.TryParse(secondInput, out int secondNumber);

// Operation Confirmation

Console.Write("Enter what operation you would like executed: ");

string chosenOperation = Console.ReadLine();

switch (chosenOperation)
{
    case "+":
        Console.WriteLine("The Result is: " + (firstNumber + secondNumber));
        break;
    case "-":
        Console.WriteLine("The Result is: " + (firstNumber - secondNumber));
        break;
    case "*":
        Console.WriteLine("The Result is: " + (firstNumber * secondNumber));
        break;
    case "/":
        if(secondNumber != 0) {
        
            Console.WriteLine("The Result is: " + (firstNumber / secondNumber));
        }
        else
        {
            Console.WriteLine("It is strictly prohibited to divide with zero!");
        }
        break;
        
    default:
        Console.WriteLine("No proper operation has been selected");
        break;


        #region Alternative with If/Else statements

        Console.Write("Select a number: ");
        string primaryNum = Console.ReadLine();
        bool chosenOne = int.TryParse(primaryNum, out int selectedOne);

        Console.Write("Select a number: ");
        string secondaryNum = Console.ReadLine();
        bool chosenSecond = int.TryParse(secondaryNum, out int selectedSecond);

        Console.Write("Select the operation you would like executed: ");
        string selectedOperation = Console.ReadLine();

        if (selectedOperation == "+")
        {
            Console.WriteLine("The result is: " + (selectedOne + selectedSecond));
        }
        else if (selectedOperation == "-")
        {
            Console.WriteLine("The result is: " + (selectedOne - selectedSecond));
        }
        else if (selectedOperation == "*")
        {
            Console.WriteLine("The result is: " + (selectedOne * selectedSecond));
        }
        else if (selectedOperation == "/" && selectedSecond != 0)
        {
            Console.WriteLine("The result is: " + (selectedOne / selectedSecond));
        }
        else
        {
            Console.WriteLine("You have either not selected a proper operand or you attemptted to divide with 0");
        }

        #endregion

}
#endregion


Console.ReadLine();