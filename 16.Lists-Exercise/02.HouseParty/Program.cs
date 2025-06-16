
List<string> guesList = new List<string>();

int countOfCommands = int.Parse(Console.ReadLine());

for (int i = 0; i < countOfCommands; i++)
{
    string[] commandArguments = Console.ReadLine().Split(" ");

    string name = commandArguments[0];
    string goingOrNot = commandArguments[2];

    if (goingOrNot == "going!") // ще добавям някого в списъка
    {
        if (guesList.Contains(name)) // проверяваме дали го има в списъка
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guesList.Add(name);
        }
    }
    else if (goingOrNot == "not") // ще премахвам някой от списъка
    {
        if (guesList.Contains(name))  // проверяваме дали го има в списъка
        {
            guesList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

foreach (var guestName in guesList)
{
    Console.WriteLine(guestName);
}
