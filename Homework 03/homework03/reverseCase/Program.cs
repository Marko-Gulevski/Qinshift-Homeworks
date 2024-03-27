#region Reverse the Case

static string ReverseCase(string stringToRevert)
{
    char[] allChars = stringToRevert.ToCharArray();
    char[] collectUpper = stringToRevert.ToUpper().ToCharArray();
    char[] collectLower = stringToRevert.ToLower().ToCharArray();

    for (int i = 0; i < allChars.Length; i++)
    {
        if (allChars[i] == collectUpper[i])
        {
            allChars[i] = collectLower[i];
        }
        else if (allChars[i] == collectLower[i])
        {
            allChars[i] = collectUpper[i];
        }
    }
    return new string(allChars);
}

Console.Write("Enter text to convert: ");
string someReversed = ReverseCase(Console.ReadLine());
Console.WriteLine(someReversed);

#endregion