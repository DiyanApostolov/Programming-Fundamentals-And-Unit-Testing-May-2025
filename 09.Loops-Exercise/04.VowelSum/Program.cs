int countCharacters = int.Parse(Console.ReadLine());

int sum = 0; //сума от точките на символите

for (int count = 1; count <= countCharacters; count++)
{
    char symbol = char.Parse(Console.ReadLine());

    //проверка дали е: a, e, i, o, u
    if (symbol == 'a')
    {
        sum += 1; //sum++;
    }
    else if (symbol == 'e')
    {
        sum += 2;
    }
    else if (symbol == 'i')
    {
        sum += 3;
    }
    else if (symbol == 'o')
    {
        sum += 4;
    }
    else if (symbol == 'u')
    {
        sum += 5;
    }
}

Console.WriteLine(sum);