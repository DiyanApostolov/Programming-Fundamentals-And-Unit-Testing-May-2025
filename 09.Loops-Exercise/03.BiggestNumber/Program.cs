int countNumbers = int.Parse(Console.ReadLine());

int maxNumber = int.MinValue; //най-голямо число

for (int count = 1; count <= countNumbers; count++)
{
    //за всяко едно число от първото до последното:
    //1. въвеждаме стойността на числото
    int number = int.Parse(Console.ReadLine());

    //2. проверка дали текущото число е най-голямо
    if (number > maxNumber)
    {
        maxNumber = number;
    }

}

Console.WriteLine(maxNumber);

