
List<int> train = Console.ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToList();

int wagonCapacity = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

while (command != "end")
{
    string[] cmdArg = command.Split(" ");

    if (cmdArg[0] == "Add")
    {
        int passengersToAdd = int.Parse(cmdArg[1]);

        train.Add(passengersToAdd);
    }
    else
    {
        int passengersToAdd = int.Parse(cmdArg[0]);

        for (int i = 0; i < train.Count; i++)
        {
            int currentPassangers = train[i];

            if(wagonCapacity - currentPassangers >= passengersToAdd)
            {
                train[i] = currentPassangers + passengersToAdd;
                break;
            }
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", train));
