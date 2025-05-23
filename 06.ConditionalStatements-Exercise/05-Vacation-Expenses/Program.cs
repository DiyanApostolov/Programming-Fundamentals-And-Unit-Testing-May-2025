//1. входни данни
string season = Console.ReadLine(); //"Spring", "Summer", "Autumn", "Winter"
string type = Console.ReadLine(); //"Hotel", "Camping"
int days = int.Parse(Console.ReadLine());

//2. намираме цената за една нощувка
double pricePerNight = 0;

//проверка за сезона
switch (season)
{
    case "Spring":
        //през пролетта -> проверка къде отсядам
        if (type == "Hotel")
        {
            //30 - 20% = 24
            pricePerNight = 24;
        }
        else if (type == "Camping")
        {
            //10 - 20% = 8
            pricePerNight = 8;
        }
        break;

    case "Summer":
        //през лятото -> проверка къде отсядам
        if (type == "Hotel")
        {
            //50 - 0% = 50
            pricePerNight = 50;
        }
        else if (type == "Camping")
        {
            //30 - 0% = 30
            pricePerNight = 30;
        }
        break;

    case "Autumn":
        //през есента -> проверка къде отсядам
        if (type == "Hotel")
        {
            //20 - 30% = 14
            pricePerNight = 14;
        }
        else if (type == "Camping")
        {
            //15 - 30% = 10.50
            pricePerNight = 10.50;
        }
        break;

    case "Winter":
        //през зимата -> проверка къде отсядам
        if (type == "Hotel")
        {
            //40 - 10% = 36
            pricePerNight = 36;
        }
        else if (type == "Camping")
        {
            //10 - 10% = 9
            pricePerNight = 9;
        }
        break;
}

//3. обща сума = цена за нощувка * days
double totalSum = pricePerNight * days;
Console.WriteLine($"{totalSum:F2}");
