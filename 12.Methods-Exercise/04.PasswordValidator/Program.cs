string password = Console.ReadLine();

//проверка дали паролата е валидна

//валидна -> валидна дължина, валидно съдържание, валиден брой цифри
if (IsValidLength(password) && IsValidContent(password) && IsValidCountDigits(password))
{
    Console.WriteLine("Password is valid");
}
//невалидна
else
{
    //проверка защо не е валидна
    //1. дължината на паролата да не е валидна
    if (!IsValidLength(password))
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    //2. съдържанието на паролата не е валидно
    if (!IsValidContent(password))
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    //3. броя на цифрите в паролата не е валиден
    if (!IsValidCountDigits(password))
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}


//метод, който проверява дали дължината на паролата е валидна
//true -> ако дължината на паролата е валидна
//false -> ако дължината на паролата не е валидна
static bool IsValidLength (string password)
{
    if (password.Length >= 6 && password.Length <= 10)
    {
        //валидна дължина
        return true;
    }
    else
    {
        //невалидна дължина
        return false;
    }
}

//метод, който проверява дали съдържанието на паролата е валидно
//true -> ако съдържанието на паролата е валидно
//false -> ако съдържанието на паролата не е валидно
static bool IsValidContent (string password)
{
    //всеки един символ от паролата трябва да бъде проверен дали е буква или цифра

    foreach (char symbol in password)
    {
        //проверка дали е буква или цифра
        if (!char.IsLetterOrDigit(symbol))
        {
            //намерила съм символ в текста, който не е буква или цифра
            return false;
        }
    }

    //всички символи в паролата и всички са букви или цифри
    return true;
}

//метод, който проверява дали броя на цифрите в паролата е валиден
//true -> ако броя на цифрите в паролата е валиден (броя >= 2)
//false -> ако броя на цифрите в паролата не е валиден (броя < 2)
static bool IsValidCountDigits (string password)
{
    int count = 0; //броя на цифрите в паролата
    //pasword = "Abcd1234"

    foreach(char symbol in password)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }

    //преминали през всички символи в текста
    //проверили сме всеки символ дали е цифра и сме го преброили
    //знаем колко е броя на цифрите
    return count >= 2;
}