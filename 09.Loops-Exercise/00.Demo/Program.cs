//цикли - повтаряме блок от код

//for цикъл - знаем колко точно пъти искаме да повтаряме
//while цикъл - не знаем колко пъти повтаряме

//АЛГОРИТЪМ ЗА НАМИРАНЕ НА НАЙ-МАЛКА СТОЙНОСТ

int countNumbers = int.Parse(Console.ReadLine());

int minNumber = int.MaxValue; //най-малкот число

for (int count = 1; count <= countNumbers; count++)
{
    //за всяко едно число от първото до последното:
    //1. въвеждаме стойността на числото
    int number = int.Parse(Console.ReadLine());

    //2. проверка дали текущото число е най-малко
    if (number < minNumber)
    {
        minNumber = number;
    }

}

Console.WriteLine(minNumber);


