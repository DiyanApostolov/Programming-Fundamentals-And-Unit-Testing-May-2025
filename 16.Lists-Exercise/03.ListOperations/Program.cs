
List<int> numbers = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToList();

string input = Console.ReadLine();

while (input != "End")
{
    string[] cmdArg = input.Split(" ");
    string command = cmdArg[0];

    if (command == "Add")
    {
        int number = int.Parse(cmdArg[1]);

        numbers.Add(number);
    }
    else if (command == "Insert")
    {
        int number = int.Parse(cmdArg[1]);
        int index = int.Parse(cmdArg[2]);

        if (index >= 0 && index < numbers.Count) // проверяваме дали индекса е валиден
        {
            numbers.Insert(index, number);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (command == "Remove")
    {
        int index = int.Parse(cmdArg[1]);

        if (index >= 0 && index < numbers.Count) // проверяваме дали индекса е валиден
        {
            numbers.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (command == "Shift")
    {
        string leftOrRight = cmdArg[1];
        int count = int.Parse(cmdArg[2]);

        if (leftOrRight == "left")
        {
            for (int i = 0; i < count; i++)
            {
                int firstElement = numbers[0]; // взимаме първия елемент
                numbers.Add(firstElement);     // добавяме го последен
                numbers.RemoveAt(0);           // премахваме пъривя елемент
            }
        }
        else if (leftOrRight == "right")
        {
            for (int i = 0; i < count; i++)
            {
                int lastElement = numbers[numbers.Count - 1]; // взимаме последния елемент
                numbers.Insert(0, lastElement);               // вкарваме го като първи елемент
                numbers.RemoveAt(numbers.Count - 1);          // премахваме последния елемент
            }
        }
    }

        input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
