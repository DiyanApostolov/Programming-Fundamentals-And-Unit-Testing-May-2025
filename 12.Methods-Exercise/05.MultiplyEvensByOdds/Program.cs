int number = Math.Abs(int.Parse(Console.ReadLine()));

//number = 123456
//сума от четните цифри на числото -> създаваме метод GetSumOfEvenDigits
//сума от нечетни цифри на числото -> създаваме метод GetSumOfOddDigits
//умножаваме сумата от четните цифри със сумата от нечетни цифри -> създаваме метод GetMultipleOfEvenAndOdds

//отпечатваме резултата от умножението
Console.WriteLine(GetMultipleOfEvenAndOdds(number));



//метод (GetSumOfEvenDigits), който намира сумата на четните цифри в едно число
static int GetSumOfEvenDigits(int number)
{
    int sum = 0; //сума от четните цифри на числото
    //number <= 0 => нямаме цифри в него
    //number > 0 => имаме цифри в него
    while (number > 0)
    {
        //последната цифра на числото
        int lastDigit = number % 10;
        //проверявам дали взетата цифра е четна
        if (lastDigit % 2 == 0)
        {
            sum += lastDigit;
        }
        //премахвам цифрата от числото
        number /= 10;
    }

    //приключваме, когато number <= 0 => нямаме цифри в него
    return sum;
}




//метод (GetSumOfOddDigits), който намира сумата на нечетните цифри в едно число
static int GetSumOfOddDigits(int number)
{
    int sum = 0; //сума от нечетни цифри на числото
    //number <= 0 => нямаме цифри в него
    //number > 0 => имаме цифри в него
    while (number > 0)
    {
        //последната цифра на числото
        int lastDigit = number % 10;
        //проверявам дали взетата цифра е нечетна
        if (lastDigit % 2 != 0)
        {
            sum += lastDigit;
        }
        //премахвам цифрата от числото
        number /= 10;
    }

    //приключваме, когато number <= 0 => нямаме цифри в него
    return sum;
}


//метод (GetMultipleOfEvenAndOdds), който изчислява умножението от сумата на четните цифри и сумата на нечетните цифри
static int GetMultipleOfEvenAndOdds(int number)
{
    return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
}