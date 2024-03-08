#region Exercise 06: Create an array with names. Give an option to the user to enter a name from the keyboard. After add the name in an array and ask the user if they want to enter another name

// Forming a counter to take into account the length of the array
int keepingCounter = 1;

string[] arrayWithNames = new string[keepingCounter];

// First inputed name
Console.Write("Enter a name: ");
string firstInputedName = Console.ReadLine();
arrayWithNames[0] = firstInputedName;


// For Loop that will either ask for more names or just print them if given a negative response
for(int i = 1; i <= arrayWithNames.Length; i++)
{
    Console.Write("Add another name? (Y/N): ");
    string answerYesOrNo = Console.ReadLine();
    if(answerYesOrNo == "Y" || answerYesOrNo == "y")
    {
        Console.Write("Enter name to add: ");
        string addedName = Console.ReadLine();
        keepingCounter++;
        Array.Resize(ref arrayWithNames, keepingCounter);
        arrayWithNames[i] = addedName;
        
    }else if(answerYesOrNo == "N" || answerYesOrNo == "n")
    {
        foreach(string name in arrayWithNames)
        {
            Console.WriteLine("The person: "+name+" has been added");
        }
        break;
    }
    else
    {
        Console.WriteLine("You have entered an invalid input");
    }
}


#endregion


/*#region Solution with while

int counter = 0;

string[] arrayWithNames = new string[counter];

Console.Write("Enter a name: ");
string addFirstName = Console.ReadLine();
Array.Resize(ref arrayWithNames, counter+1);
arrayWithNames[0] = addFirstName;



while (arrayWithNames != null)
{
    Console.Write("Would you like to add another name? (Y/N): ");
    string confirmChoice = Console.ReadLine();
    if(confirmChoice == "Y" || confirmChoice == "y")
    {
        Console.Write("Enter name to add: ");
        counter++;
        string nameAdded = Console.ReadLine();
        Array.Resize(ref arrayWithNames, counter+1);
        arrayWithNames[counter] = nameAdded;
    }else if(confirmChoice == "N" ||  confirmChoice == "n")
    {
        foreach (string name in arrayWithNames)
        {
            Console.WriteLine(name);
        }
            break;
    }
    else { Console.WriteLine("You have not made a proper selection! Please answer with either Y or N"); }
    

}


#endregion
*/