using System;
using System.Linq;

namespace TestApp;

public class Pattern
{
    public static int[] SortInPattern(int[]? arr)
    {   //arr = [1, 2, 1, 3, 4, 10, 12, 15 ]
        //премахваме дуплицираните елементи
        //arr = [1, 2, 3, 4, 10, 12, 15 ]
        //сортираме на зиг-заг
        //arr = [1, 15, 2, 12, 3, 10, 4]
        //връща [1, 15, 2, 12, 3, 10, 4]

        Array.Sort(arr);

        int[] distinctList = arr.Distinct().ToArray();

        int[] result = new int[distinctList.Length];
        int left = 0;
        int right = distinctList.Length - 1;
        bool isLeftTurn = true;

        for (int i = 0; i < distinctList.Length; i++)
        {
            if (isLeftTurn)
            {
                result[i] = distinctList[left];
                left++;
            }
            else
            {
                result[i] = distinctList[right];
                right--;
            }

            isLeftTurn = !isLeftTurn;
        }

        return result;
    }
}
