//1. въвеждаме входните данни
string fruit = Console.ReadLine(); //"Banana", "Apple", "Kiwi"
string day = Console.ReadLine();  //"Weekday", "Weekend"

//2. проверка какъв плод сме си купили -> серия от проверки if - else if
if (fruit == "Banana")
{
    //проверка в какъв ден сме го купили
    if (day == "Weekday")
    {
        Console.WriteLine("2.50");
    }
    else if (day == "Weekend")
    {
        Console.WriteLine("2.70");
    }
}
else if (fruit == "Apple")
{
    //проверка в какъв ден сме я купили
    if (day == "Weekday")
    {
        Console.WriteLine("1.30"); 
    }
    else if (day == "Weekend")
    {
        Console.WriteLine("1.60");
    }
}
else if (fruit == "Kiwi")
{
    //проверка в какъв ден сме го купили
    if (day == "Weekday")
    {
        Console.WriteLine("2.20");
    }
    else if (day == "Weekend")
    {
        Console.WriteLine("3.00");
    }
}

