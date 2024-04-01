#region Task 01
Queue<int> randomNumbers = new Queue<int>();
AddNumbers(randomNumbers);
#endregion

#region Method Region
static void AddNumbers(Queue<int> queue)
{
    while (true)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        bool convertInput = int.TryParse(input, out int number);
        queue.Enqueue(number);
        Console.Write("Add another num? (Y/N): ");
        string confirmAddition = Console.ReadLine();
        if (confirmAddition.ToLower() == "y")
        {
            AddNumbers(queue);
        }
        else if (confirmAddition.ToLower() == "n")
        {
            foreach (var num in queue)
            {
                Console.WriteLine(num);
            }
        }
        break;
    }
}
#endregion