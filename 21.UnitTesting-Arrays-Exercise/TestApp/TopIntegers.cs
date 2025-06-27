using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp;

public class TopIntegers
{
    //връщаме текст с всички top integer (по-големи от елементите си в дясно) разделени с интервал
    public string FindTopIntegers(int[] nums)
    {
        //nums = [14, 24, 3, 19, 15, 17]
        //връща "24 19 17"
        //!!!! НЕ Е СТАТИЧЕН МЕТОДА!!!!!
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < nums.Length; i++)
        {
            bool topInt = true;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] <= nums[j])
                {
                    topInt = false;
                    break;
                }
            }
            if (topInt)
                sb.Append(nums[i] + " ");
        }

        return sb.ToString().TrimEnd();
    }
}
