//1. въвеждаме две цели числа

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

//2. проверка кое число е по-голямо
if (firstNumber >= secondNumber)
{
    Console.WriteLine("Greater number: " + firstNumber);
}
else
{
    //обратното условие: firstNumber < secondNumber
    Console.WriteLine("Greater number: " + secondNumber);
}
