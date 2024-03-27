#region Method Format and Validation

Console.Write("Enter date: ");
string inputedDate = Console.ReadLine();
string[] allowedFormats =
{
    "MM/dd/yyyy",
    "MM/dd/yyyy hh:mm:ss",
    "dddd, dd MMMM yyyy HH:mm:ss",
    "MM.dd.yyyy"
};
Console.Write("Enter format: ");
string inputedFormat = Console.ReadLine();

static void formatDate(string dateInput, string formatInput)
{
    DateTime convertingDate = DateTime.Parse(dateInput);
    string formatToUse = convertingDate.ToString(formatInput);
    Console.Write(formatToUse);
}

formatDate(inputedDate, inputedFormat);

static bool verifyFormat(string input, string[] allowedFormats)
{
    bool isFormatValid = Array.IndexOf(allowedFormats, input) >= 0;
    if (isFormatValid)
    {
        Console.WriteLine("The format is valid");
    }
    else
    {
        Console.WriteLine("The format is invalid");
    }

    return isFormatValid;
}

verifyFormat(inputedFormat, allowedFormats);





#endregion