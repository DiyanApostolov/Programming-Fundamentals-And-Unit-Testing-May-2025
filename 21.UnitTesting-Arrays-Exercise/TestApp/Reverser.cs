using System.Linq;

namespace TestApp;

public class Reverser
{
    public static string[] ReverseStrings(string[] arr)
    {
        //arr = ["Hello!", "#Desi?", "*Ivan)"]
        return arr.Select(s => new string(s.Reverse().ToArray())).ToArray();
        //["!olleH", "?iseD#", ")navI*"]
    }
}
