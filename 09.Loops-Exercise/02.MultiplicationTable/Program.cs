//входни данни

int n = int.Parse(Console.ReadLine());

//for цикъл
//повтаряме: n го умножавам и го отпечатвам
//начало: 1
//край: 10
//промяна: +1

for (int number = 1; number <= 10; number++)
{
    int result = n * number;
    Console.WriteLine($"{n} x {number} = {result}");
}

