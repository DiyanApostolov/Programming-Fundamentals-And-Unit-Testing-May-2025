//1. въвеждаме входни данни
int number = int.Parse(Console.ReadLine());

//2. серия от проверки за стойността на променливата number
//number == 1 -> "Monday"
//number == 2 -> "Tuesday"
//number == 3 -> "Wednesday"
//number == 4 -> "Thursday"
//number == 5 -> "Friday"
//number == 6 -> "Saturday"
//number == 7 -> "Sunday"

//switch конструкция -> серия от проверки за ТОЧНИ СТОЙНОСТИ на една променлива

switch (number)
{
    case 1: //number == 1
        Console.WriteLine("Monday");
        break; //прекратява switch конструкцията

    case 2: //number == 2
        Console.WriteLine("Tuesday");
        break;

    case 3: //number == 3
        Console.WriteLine("Wednesday");
        break;

    case 4: //number == 4
        Console.WriteLine("Thursday");
        break;

    case 5: //number == 5
        Console.WriteLine("Friday");
        break;

    case 6: //number == 6
        Console.WriteLine("Saturday");
        break;

    case 7: //number == 7
        Console.WriteLine("Sunday");
        break;

    default: //когато нито един от горните case-ове не е изпълнен
        Console.WriteLine("Error");
        break;
}

