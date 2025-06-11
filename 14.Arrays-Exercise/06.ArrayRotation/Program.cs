
int[] inputArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

int rotations = int.Parse(Console.ReadLine());

rotations = rotations % inputArray.Length; // <- оптимизация на ротациите

for (int i = 0; i < rotations; i++)
{
    // запазвам си първия елемент
    int firstElement = inputArray[0];

    // местя всички елементи от индекс 1, една позиция на ляво
    for (int j = 1; j < inputArray.Length; j++)
    {
        inputArray[j - 1] = inputArray[j];
    }

    // местя първият елемент като последен
    inputArray[inputArray.Length - 1] = firstElement;
}

Console.WriteLine(string.Join(" ", inputArray));