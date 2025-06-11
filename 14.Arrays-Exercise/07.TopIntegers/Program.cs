
int[] inputArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

for (int i = 0; i < inputArray.Length; i++)
{
    int currentElement = inputArray[i];
    bool isBigger = true;

    // започвам от следващия десен елемент
    for (int j = i + 1; j < inputArray.Length; j++)
    {
        // вземам един по един елементите надясно
        int nextRigthElement = inputArray[j];

        // ако текущия елемент е <= на някой отдясно, прекъсвам цикъла
        if (currentElement <= nextRigthElement)
        {
            isBigger = false;
            break;
        }
    }

    if (isBigger)
    {
        Console.Write(currentElement + " ");
    }
}