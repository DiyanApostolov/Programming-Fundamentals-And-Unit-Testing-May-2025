internal class Program
{
    private static void Main(string[] args)
    {
        string type = Console.ReadLine();
        string firstValue = Console.ReadLine();
        string secondValue = Console.ReadLine();

        CompareTwoValues(type, firstValue, secondValue);
    }

    private static void CompareTwoValues(string type, string? firstValue, string? secondValue)
    {
        if (type == "int")
        {
            int a = int.Parse(firstValue);
            int b = int.Parse(secondValue);

            Console.WriteLine(CompareTwoIntegers(a, b));
        }
        else if (type == "char")
        {
            char a = char.Parse(firstValue);
            char b = char.Parse(secondValue);

            Console.WriteLine(ComapeTwoChars(a, b));
        }
        else if (type == "string")
        {
            Console.WriteLine(CompareTwoStrings(firstValue, secondValue));
        }
    }

    private static string CompareTwoStrings(string? firstString, string? secondString)
    {
        int result = firstString.CompareTo(secondString);

        if (result > 0)
            return firstString;
        else
            return secondString;
    }

    private static char ComapeTwoChars(char a, char b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    private static int CompareTwoIntegers(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }
}