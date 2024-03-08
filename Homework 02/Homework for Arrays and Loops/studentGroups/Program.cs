#region Make a new console app for Student Groups

// Form the Strings
string[] studentsG1 = { "Milorad", "Velimir", "Bogoslav", "Stanka", "Zorana" };
string[] studentsG2 = { "Marko", "Simeon", "Murat", "Radica", "Anastasija" };

Console.Write("What group of students would you like displayed? ");
string selectGroup = Console.ReadLine();
bool groupSelected = int.TryParse(selectGroup, out int confirmedGroupSelection);

if (!groupSelected)
{
    Console.WriteLine("You must select a group by inputing either 1 or 2");
}

// Check which group is the selected one and print out their values

if(confirmedGroupSelection == 1)
    {
        Console.WriteLine("The students in G1 are:");
        foreach (string student in studentsG1)
        {
           
            Console.WriteLine(student);
        }
    }else if(confirmedGroupSelection == 2)
    {
        Console.WriteLine("The students in G2 are:");
        foreach (string student in studentsG2)
        {
            
            Console.WriteLine(student);
        }
    }
    else
    {
        Console.WriteLine("You have selected an invalid group number");
    }
    

#endregion
