
internal class Program
{
    private static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        int area = CalculateRectangeArea(width, length);

        Console.WriteLine(area);
    }

    private static int CalculateRectangeArea(int width, int length)
    {
        return width * length;
    }
}