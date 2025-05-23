int hour = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

//open -> 10:00 до 18:00 / от понеделник до събота
//closed -> преди 10, след 18, неделя


if (hour >= 10 && hour <= 18)
{
    //отиваме във валиден час

    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday"
        || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday"
        || dayOfWeek == "Friday" || dayOfWeek == "Saturday")
    {
        Console.WriteLine("open");
    }
    else if (dayOfWeek == "Sunday")
    {
        //dayOfWeek = "Sunday"
        Console.WriteLine("closed");
    }
}
else
{
    //hour < 10 || hour > 18
    Console.WriteLine("closed");
}