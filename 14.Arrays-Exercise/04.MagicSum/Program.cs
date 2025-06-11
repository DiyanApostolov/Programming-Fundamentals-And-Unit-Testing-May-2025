
int[] inputArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

int controlNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < inputArray.Length - 1; i++) // минавам през всички елементи без последния
{
    int leftElement = inputArray[i];

    for (int j = i + 1; j < inputArray.Length; j++) // минавам всички елементи надясно от текущия
    {
        int rigthElement = inputArray[j];

        int sum = leftElement + rigthElement;

        if (sum == controlNumber)
        {
            Console.WriteLine($"{leftElement} {rigthElement}");
            break;
        }
    }
}

