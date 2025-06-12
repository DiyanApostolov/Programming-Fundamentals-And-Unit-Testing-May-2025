List<int> numbers = Console.ReadLine() //"1 2 3 4 5 6"
                    .Split()           //["1", "2", "3", "4", "5", "6"]
                    .Select(int.Parse) //[1, 2, 3, 4, 5, 6]
                    .ToList();         //{1, 2, 3, 4, 5, 6}

string command = Console.ReadLine();
//command -> входни данни
//command == "end" -> прекратяваме въвеждането на входни данни
//command != "end" -> продължаваме с въвеждането на входни данни

while (command != "end")
{
    //command е валидна команда, която трябва да изпълня
    //1. command = "Delete 5".Split()    -> commandParts = ["Delete", "5"]
    //2. command = "Insert 10 1".Split() -> commandParts = ["Insert", "10", "1"]
    string[] commandParts = command.Split();
    string commandName = commandParts[0]; // "Delete" или "Insert"

    if (commandName == "Delete")
    {
        int numberToBeRemoved = int.Parse(commandParts[1]); //"5" => int.Parse -> 5
        numbers.RemoveAll(number => number == numberToBeRemoved);
    }
    else if (commandName == "Insert")
    {
        int numberToInsert = int.Parse(commandParts[1]); //"10" -> int.Parse -> 10
        int positionToInsert = int.Parse(commandParts[2]); //"1" -> int.Parse -> 1
        numbers.Insert(positionToInsert, numberToInsert);
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));