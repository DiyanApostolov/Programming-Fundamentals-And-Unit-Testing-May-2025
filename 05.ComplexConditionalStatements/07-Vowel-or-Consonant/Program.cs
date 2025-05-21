//1. въвеждаме входни данни
char letter = char.Parse(Console.ReadLine());

//2. проверка дали буквата е гласна
//A, a, E, e, I, i, O, o, U, u

if (letter == 'A' || letter == 'a' || letter == 'E' || letter == 'e'
    || letter == 'I' || letter == 'i' || letter == 'O' || letter == 'o'
    || letter == 'U' || letter == 'u')
{
    //гласна буква
    Console.WriteLine("Vowel");
}
else
{
    //съгласна буква
    Console.WriteLine("Consonant");
}