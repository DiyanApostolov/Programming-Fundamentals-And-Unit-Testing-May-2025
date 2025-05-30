int countNumbers = int.Parse(Console.ReadLine());

//брой на числа, които се делят на 2
int countDivisible2 = 0;

//брой на числа, които се делят на 3
int countDivisible3 = 0;

//брой на числа, които се делят на 4
int countDivisible4 = 0;

for (int count = 1; count <= countNumbers; count++)
{
    int number = int.Parse(Console.ReadLine());

    //проверка в коя група попада
    //1. проверка дали попада в група 1 (числа, които се делят на 2)
    if (number % 2 == 0)
    {
        countDivisible2++;
    }

    //2. проверка дали попада в група 2 (числа, които се делят на 3)
    if (number % 3 == 0)
    {
        countDivisible3++;
    }

    //3. проверкда дали попада в група 3 (числа, които се делят на 4)
    if (number % 4 == 0)
    {
        countDivisible4++;
    }
}

//преминали сме през всички числа и сме ги разпределили по групите
//1. броя на числата в група 1 (числа, които се делят на 2) -> countDivisible2
//2. броя на числата в група 2 (числа, които се делят на 3) -> countDivisible3
//3. броя на числата в група 3 (числа, които се делят на 4) -> countDivisible4

double percentDivisible2 = (countDivisible2 * 1.0 / countNumbers) * 100;
double percentDivisible3 = (countDivisible3 * 1.0 / countNumbers) * 100;
double percentDivisible4 = (countDivisible4 * 1.0 / countNumbers) * 100;

Console.WriteLine($"{percentDivisible2:F2}%");
Console.WriteLine($"{percentDivisible3:F2}%");
Console.WriteLine($"{percentDivisible4:F2}%");