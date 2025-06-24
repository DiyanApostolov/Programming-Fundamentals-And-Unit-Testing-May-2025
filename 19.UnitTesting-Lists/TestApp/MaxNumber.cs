using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp;

public class MaxNumber
{
    //връща най-голямото цяло число в подадения списък от цели числа
    public static int FindMax(List<int> numbers)
    {
        return numbers.Max();
    }
}
