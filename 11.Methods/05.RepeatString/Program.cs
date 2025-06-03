internal class Program
{
    private static void Main(string[] args)
    {
        string inputStr = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine(RepeatString(inputStr, count));

    }

    static string RepeatString(string str, int count)
    {
        string result = "";

        for (int i = 0; i < count; i++)
        {
            result += str;
        }

        return result;
    }
}