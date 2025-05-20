//1. въвеждаме тип на билет
string ticketType = Console.ReadLine();

//2. проверка за типа на билета
if (ticketType == "student")
{
    //студентски билет
    Console.WriteLine("$1.00");
}
else if (ticketType == "regular")
{
    //редовен билет
    Console.WriteLine("$1.60");
}
else
{
    //билетът ми да не е нито студентски, нито редовен
    Console.WriteLine("Invalid ticket type!");
}

