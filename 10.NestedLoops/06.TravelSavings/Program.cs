
string destination = Console.ReadLine();

while (destination != "End")
{
    double neededMoney = double.Parse(Console.ReadLine());

    double savedMoney = 0;

    while (savedMoney < neededMoney)
    {
        double currentMoney = double.Parse(Console.ReadLine());
        savedMoney += currentMoney;

        Console.WriteLine($"Collected: {savedMoney:F2}");
    }

    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}
