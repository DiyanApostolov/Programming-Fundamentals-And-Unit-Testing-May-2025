//1. въвеждаме входните данни
int number = int.Parse(Console.ReadLine());

//ако имаме валидно число -> не опечатваме нищо
//ако имаме невалидно число -> отпечатваме "invalid"

bool isValid = (number >= 100 && number <= 200) || number == 0;
//isValid = true -> числото е валидно
//isValid = false -> числото не е валидно

if (!isValid)
{
    //числото не е валидно
    Console.WriteLine("invalid");
}