
string input = Console.ReadLine();

while (input != "End")
{
    int number = int.Parse(input);

    int sum = 0;

    while (number > 0)
    {
        int lastDigit = number % 10; // take the last digit

        sum += lastDigit;

        number /= 10; // remove the last digit
    }

    Console.WriteLine($"Sum of digits = {sum}");

    input = Console.ReadLine();
}

Console.WriteLine("Goodbye");
