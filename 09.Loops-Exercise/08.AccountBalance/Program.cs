double balance = 0.0;
while (true)
{
    string input = Console.ReadLine();
    if (input == "End") break;
    double amount = double.Parse(input);
    balance += amount;
    if (amount >= 0)
        Console.WriteLine($"Increase: {amount:F2}", amount);
    else
        Console.WriteLine($"Decrease: {Math.Abs(amount):F2}");
}
Console.WriteLine($"Balance: {balance:F2}");