
int[] inputArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();


while(inputArray.Length > 1) 
{
    // правим нов масив с един елемент по-къс от предната итерация
    int[] condensedArray = new int[inputArray.Length - 1];

    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        // събираме всеки два съседни елемента
        condensedArray[i] = inputArray[i] + inputArray[i + 1];
    }

    // презаписвам кондензирания масив върху оригиналния от входа
    inputArray = condensedArray;
}

Console.WriteLine(inputArray[0]);

