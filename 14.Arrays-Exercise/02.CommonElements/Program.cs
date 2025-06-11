
int[] firstArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

int[] secondArray = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

for (int a = 0; a < firstArray.Length; a++)
{
    for (int b = 0; b < secondArray.Length; b++)
    {
        if (firstArray[a] == secondArray[b])
        {
            Console.Write(firstArray[a] + " ");
            break;
        }
    }
}


// Second solution with foreach loop

//foreach (var element in firstArray)
//{
//    if (secondArray.Contains(element))
//    {
//        Console.Write(element + " ");
//    }
//}
