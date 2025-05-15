
// Input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentageOccupiedSpace = double.Parse(Console.ReadLine());

// Calculations
double allVolumeInLiters = length * width * height / 1000;  // divide by double!!!

double occupiedSpace = percentageOccupiedSpace / 100;

double requiredLiters = allVolumeInLiters * (1 - occupiedSpace);

// Output
Console.WriteLine($"{requiredLiters:F2}");



