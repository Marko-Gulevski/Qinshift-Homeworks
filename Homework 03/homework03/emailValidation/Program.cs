#region Email Validation
Console.Write("Enter e-mail: ");
string inputedEmail = Console.ReadLine();

static bool isMailValid(string email)
{
    char[] charEmail = email.ToCharArray();
    int indexOfDot = email.IndexOf('.', Array.IndexOf(charEmail, '@'));
    int indexOfAt = email.IndexOf('@', 0);
    if (email.Contains('@') && email.Contains('.') && indexOfDot > indexOfAt && indexOfAt >= 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine(isMailValid(inputedEmail));

#endregion