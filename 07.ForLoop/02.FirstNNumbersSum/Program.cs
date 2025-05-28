
int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write(i);
    sum += i;

    if (i < n)
    {
        Console.Write('+');
    }
}

Console.Write($"={sum}");

