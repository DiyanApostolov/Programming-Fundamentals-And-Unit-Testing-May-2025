//1. въвеждаме температурата на водата
int temperature = int.Parse(Console.ReadLine());

//2. проверка за температурата
if (temperature > 100)
{
    Console.WriteLine("The water is boiling");
}
else
{
    //противен случай: temperature <= 100
    Console.WriteLine("The water is not hot enough");
}

