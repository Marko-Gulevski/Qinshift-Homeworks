namespace Bonus.Task._01.Library
{
    public static class PrintInConsole<T>
    {
        public static void Print(T item)
        {
            Console.WriteLine(item);
        }

        public static void PrintCollection(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
