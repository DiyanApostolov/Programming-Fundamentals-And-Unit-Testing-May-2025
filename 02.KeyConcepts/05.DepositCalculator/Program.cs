// Input
double depositAmount = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double yearInterestRate = double.Parse(Console.ReadLine());

// Calculations
double yearIncome = depositAmount * yearInterestRate / 100;

double monthIncome = yearIncome / 12;

double finalIncome = depositAmount + months * monthIncome;

// Ouput
Console.WriteLine(finalIncome);