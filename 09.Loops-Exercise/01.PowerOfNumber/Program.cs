//входни данни
int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

//number да го повдигнем на степен = power

//начин 1: без цикъл, Math.Pow
//Console.WriteLine(Math.Pow(number, power));

//начин 2: for цикъл
//2 ^ 6 = 2 * 2 * 2 * 2 * 2 * 2 = 64
int result = 1;

for (int count = 1; count <= power; count++)
{
    //броя повторения = power
    result = result * number;
}

Console.WriteLine(result);