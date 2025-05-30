//входни данни
int number = int.Parse(Console.ReadLine()); //число, което ще обработвам и ще му взимам цифрите
int startNumber = number; //първоначалната стойност на числото, която няма да променям

bool isSpecial = true;
//isSpecial = true -> числото е специално
//isSpecial = false -> числото не е специално

//взимаме цифрите на числото
//number > 0 -> има цифри в него -> продължаваме да ги взимаме
//number <= 0 -> няма цифри в него -> прекратяваме взимане
while (number > 0)
{
    //взимаме последната цифра от числото
    int lastDigit = number % 10;

    //проверка дали моето число се дели на тази цифра
    if (startNumber % lastDigit != 0)
    {
        //числото не се дели на някоя от цифрите му -> числото не е специално
        isSpecial = false;
        break;
    }

    //премахваме последната цифра от числото
    number = number / 10;
}



//отпечатване
if (isSpecial)
{
    //числото е специално
    Console.WriteLine(startNumber + " is special");
}
else
{
    //isSpecial == false
    //числото не е специално
    Console.WriteLine(startNumber + " is not special");
}

