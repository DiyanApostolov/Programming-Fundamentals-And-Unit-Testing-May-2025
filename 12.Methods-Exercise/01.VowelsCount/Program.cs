string text = Console.ReadLine();
int countVowels = GetVowelsCount(text);
Console.WriteLine(countVowels);


//метод, който приема текст
//намира броя на гласните букви в текста
//като резултат от метода връщаме изчисления брой

//създаване на методи
//1. static -> статичен метод - може да се използва директно чрез неговото име в рамките на файла
//2. вид на метода -> void / return
//3. име на метода -> EN, Pascal case, one action, what is this method doing?
//4. параметри -> ()
static int GetVowelsCount (string text)
{
    //гласни букви: A, a, E, e, I, i, O, o, U, u
    //text = "Palidrome"

    int count = 0; //броя на гласните букви
    //обхождаме всеки един символ в текста
    for (int position = 0; position <= text.Length - 1; position++)
    {
        char currentSymbol = text[position];
        //проверка дали символа е гласна буква
        if (currentSymbol == 'A' || currentSymbol == 'a'
            || currentSymbol == 'E' || currentSymbol == 'e'
            || currentSymbol == 'O' || currentSymbol == 'o'
            || currentSymbol == 'I' || currentSymbol == 'i'
            || currentSymbol == 'U' || currentSymbol == 'u')
        {
            count++; //увеличаваме броя на гласните букви с 1
        }

    }

    //знаем броя на гласните букви -> count
    return count;
}

