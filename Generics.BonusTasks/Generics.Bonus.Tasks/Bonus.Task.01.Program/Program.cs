using Bonus.Task._01.Library;

int num = 15;
double doubleNum = 15.55;
string sentence = "Bla bla";
bool trueOrFalse = false;
char letter = 'a';

List<string> words = new List<string>()
{
    "Brat",
    "Sestra",
    "Mushka Tetka"
};

List<int> nums = new List<int>()
{
    16,12,55,23,2555
};

List<bool> bools = new List<bool>()
{
    true,false,false,false,false,false,true
};

List<char> letters = new List<char>()
{
    'W','O','H','O'
};

List<double> doubles = new List<double>()
{
    155.55,235.125,505.65,2.52
};

PrintInConsole<int>.Print(num);
PrintInConsole<double>.Print(doubleNum);
PrintInConsole<string>.Print(sentence);
PrintInConsole<bool>.Print(trueOrFalse);
PrintInConsole<char>.Print(letter);

Console.WriteLine("\n\n");
PrintInConsole<string>.PrintCollection(words);
PrintInConsole<int>.PrintCollection(nums);
PrintInConsole<bool>.PrintCollection(bools);
PrintInConsole<char>.PrintCollection(letters);
PrintInConsole<double>.PrintCollection(doubles);
