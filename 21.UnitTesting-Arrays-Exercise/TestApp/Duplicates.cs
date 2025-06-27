using System.Collections.Generic;
using System.Linq;

namespace TestApp;

public class Duplicates
{
    public static int[] RemoveDuplicates(int[] numbers)
    {
        //numbers = [ 1, 1, 1, 1 ]
        List<int> uniqueNumbers = new();
        //HashSet -> съхраняваме еднотипни уникални елементи

        foreach (int number in numbers)
        {
            if (!uniqueNumbers.Contains(number))
            {
                uniqueNumbers.Add(number);
            }
            
        }
        //uniqueNumbers = {1}
        return uniqueNumbers.ToArray(); //[1]
    }
}
