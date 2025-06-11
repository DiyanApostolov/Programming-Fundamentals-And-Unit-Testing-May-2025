
int n = int.Parse(Console.ReadLine());

int[] firstArray = new int[n];
int[] secondArray = new int[n];


for (int i = 0; i < n; i++)
{
    int[] rowData = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

    if(i % 2 == 0) // четна итерация
    {
        firstArray[i] = rowData[0];
        secondArray[i] = rowData[1];
    }
    else // нечетна итерация
    {
        firstArray[i] = rowData[1];
        secondArray[i] = rowData[0];
    }
}

Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));
