// Input
double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

// Calculations
double bathroomArea = bathroomWidth * bathroomHeight;
double bathroomAreaWithSurplus = bathroomArea + (bathroomArea * 0.10);

double tileArea = tileWidth * tileHeight;

double neededTiles = bathroomAreaWithSurplus / tileArea;

// Output
Console.WriteLine(Math.Round(neededTiles)); // rounding to nearest integer value 

