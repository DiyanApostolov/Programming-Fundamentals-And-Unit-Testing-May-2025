internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        Console.WriteLine(MathPower(number, power));
    }

    static int MathPower(int number, int power)
    {
        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        return result;
    }
}