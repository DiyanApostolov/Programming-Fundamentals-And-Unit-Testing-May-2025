
// решение на задачата с int и while

int number = int.Parse(Console.ReadLine());
int sumAllFactorials = 0;

while (number > 0)
{
    int lastDigit = number % 10; // take last digit
    number /= 10;                // remove last digit

    if (lastDigit % 2 == 0)
    {
        int factorial = 1;

        for (int i = 1; i <= lastDigit; i++)
        {
            factorial = factorial * i;
        }

        sumAllFactorials += factorial;
    }
}

Console.WriteLine(sumAllFactorials);

// Решение на задачата със string и foreach

string number = Console.ReadLine();
int sumAllFactorials = 0;

foreach (char digit in number)
{
    // обръщаме char в integer
    int currentDigit = int.Parse(digit.ToString());

    if (currentDigit % 2 == 0)
    {
        int factorial = 1;

        for (int i = 1; i <= currentDigit; i++)
        {
            factorial = factorial * i;
        }

        sumAllFactorials += factorial;
    }
}

Console.WriteLine(sumAllFactorials);