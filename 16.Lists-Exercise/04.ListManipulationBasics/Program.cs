
List<int> numbers = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToList();

string input = Console.ReadLine();

while (input != "end")
{
    string[] cmdArg = input.Split(" ");
    string command = cmdArg[0];

    if (command == "Add") // добавяме елемент в края на списъка
    {
        int number = int.Parse(cmdArg[1]);
        numbers.Add(number);
    }
    else if (command == "Remove") // премахваме елемент ако го намери
    {
        int number = int.Parse(cmdArg[1]);
        numbers.Remove(number);
    }
    else if (command == "RemoveAt") // премахваме елемент на даден индекс
    {
        int index = int.Parse(cmdArg[1]);
        numbers.RemoveAt(index);
    }
    else if (command == "Insert") // вмъкваме елемент на даден индекс
    {
        int number = int.Parse(cmdArg[1]);
        int index = int.Parse(cmdArg[2]);
        numbers.Insert(index, number);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));