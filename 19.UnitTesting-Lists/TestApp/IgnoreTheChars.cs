using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp;

public class IgnoreTheChars
{
    //получаваме изречение и списък със забранени символи
    //премахваме от изречението забранените символи
    //връщаме новото изречение, което е без забранените символи
    public static string IgnoreChars(string sentence, List<char> ignoredChars)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in sentence)
        {
            if (ignoredChars.Contains(c))
            {
                continue;
            }
            sb.Append(c);
        }

        return sb.ToString().TrimEnd();
    }
}
