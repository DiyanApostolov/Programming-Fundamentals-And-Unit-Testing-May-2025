using System;
using System.Linq;

namespace TestApp;

public class Fake
{
    public static char[] RemoveStringNumbers(char[]? arr)
    {
        //arr = []
        //метод, който премахва символите, които са цифри
        return arr.Where(c => !char.IsDigit(c)).ToArray();
        //[]
    }
}
