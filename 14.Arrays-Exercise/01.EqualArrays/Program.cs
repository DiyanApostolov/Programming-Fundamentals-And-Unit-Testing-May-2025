
int[] firstArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

int[] secondArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

bool isIdentical = true;

for (int index = 0; index < firstArray.Length; index++)
{
    if (firstArray[index] != secondArray[index])
    {
        isIdentical = false;
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else 
{
    Console.WriteLine("Arrays are not identical.");
}
