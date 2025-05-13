// Input
double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

// Calculations
double tomatoFinalPrice = tomatoPrice * tomatoQuantity;
double cucumberFinalPrice = cucumberPrice * cucumberQuantity;

double totalCost = tomatoFinalPrice + cucumberFinalPrice;

// Output
Console.WriteLine($"{totalCost:F2}");
