using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp;

public class RepeatingChecker
{
    //връща цяло число (първия повтарящ се елемент в масива)
    public static int FindFirstRepeatingElement(int[] nums)
    {
        HashSet<int> seenElements = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seenElements.Contains(num))
            {
                return num;
            }
            seenElements.Add(num);
        }
        //нямаме елемент, който се повтаря
        return -1;
    }

    //връща цяло число (последния повтарящ се елемент в масива)
    public static int FindLastRepeatingElement(int[] nums)
    {
        HashSet<int> seenElements = new HashSet<int>();
        int repeatingElement = -1;

        foreach (int num in nums)
        {
            if (seenElements.Contains(num))
            {
                repeatingElement = num;
            }
            seenElements.Add(num);
        }

        return repeatingElement;
    }
}
