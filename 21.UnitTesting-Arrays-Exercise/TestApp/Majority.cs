using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp;

public class Majority
{
    //връща
    //1. положително цяло число, ако броя на четни числа в масива > броя на нечетни числа в масива
    //2. отрицателно цяло число, ако броя на четни числа в масива < броя на нечетни числа в масива
    //3. нула, ако броя на четни числа в масива == броя на нечетни числа в масива
    public static int IsEvenOrOddMajority(int[] nums)
    {
        //nums = [1, 2, 3, 4, 5, 7, 9]
        //четни = 2 бр.
        //нечетни = 5 бр.

        int even = 0; //броя на четни
        int odd = 0; //броя не нечетни

        foreach (int num in nums)
        {
            if (num == 0)
            {
                continue;
            }

            if (num % 2 == 0)
            {
                even++; //увеличаваме броя на четните числа
            }
            else
            {
                odd++; //увеличаваме броя на нечетните
            }
        }

        //знаем броя на четните и броя на нечетните
        return even - odd;
    }
}
