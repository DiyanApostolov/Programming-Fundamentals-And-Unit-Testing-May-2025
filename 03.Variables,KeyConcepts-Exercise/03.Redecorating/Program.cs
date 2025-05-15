
// Input
int amountOfNylon = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int quantityOfThinner  = int.Parse(Console.ReadLine());
int hoursNeededForWork   = int.Parse(Console.ReadLine());

// Calculations
//•	Protective nylon - 1.50 BGN per square meter
//•	Paint - 14.50 BGN per liter
//•	Paint thinner - 5.00 BGN per liter

double priceForNylon = (amountOfNylon + 2) * 1.50;
double priceForPaint = amountOfPaint * 1.1 * 14.50;  // * 1.1 -> add 10%
double priceForThinner = quantityOfThinner * 5;
double priceForBags = 0.40;

double priceForAllMaterials = priceForNylon + priceForPaint + priceForThinner + priceForBags;

double oneHourWork = priceForAllMaterials * 0.3;    // 30%
double priceForCraftsmen = hoursNeededForWork * oneHourWork;

double finalPrice = priceForAllMaterials + priceForCraftsmen;

// Output
Console.WriteLine(finalPrice);
