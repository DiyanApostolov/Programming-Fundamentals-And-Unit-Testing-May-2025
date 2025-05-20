//1. въвеждаме скорост (дробно число)
double speed = double.Parse(Console.ReadLine());

//2. проверка за скоростта
if (speed <= 30)
{
    Console.WriteLine("Slow");
}
else
{
    //противен случай: speed > 30
    Console.WriteLine("Fast");
}

