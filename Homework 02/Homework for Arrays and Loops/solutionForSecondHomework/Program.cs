#region Task 01: Make a console application called Sum of Even. Create an array of 6 ints. Get numbers from the input,find and print the sum of the even numbers from the array

// Setting up a counter
int counter = 0;

// Declaring the Array
int[] numbersArray = new int[counter];

int result = 0;

// Forming the input commands and looping only through the even numbers
for(int i = 0; i < counter; i++) {
    counter++;
    Console.Write("Enter a number: ");
    string inputedNum = Console.ReadLine();
    int convertedNumber = Convert.ToInt32(inputedNum);
    Array.Resize(ref numbersArray, counter);
    numbersArray[i] = convertedNumber;
    if (numbersArray[i] % 2==0) {
        result += numbersArray[i];
    }
        
    }

// Test results

Console.WriteLine("The result is: " + result);
Console.WriteLine(numbersArray[0]);
Console.WriteLine(numbersArray[1]);
Console.WriteLine(numbersArray[2]);
Console.WriteLine(numbersArray[3]);
Console.WriteLine(numbersArray[4]);
Console.WriteLine(numbersArray[5]);

#endregion