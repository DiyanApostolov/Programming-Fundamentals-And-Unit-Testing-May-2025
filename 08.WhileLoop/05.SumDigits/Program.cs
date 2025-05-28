
int number = int.Parse(Console.ReadLine());

int sum = 0;

while (number > 0)
{
    // take the last digit from number
    int lastDigit = number % 10;

    sum += lastDigit;

    // remove the last digit from number
    number /= 10;
}

Console.WriteLine(sum);


