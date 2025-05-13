// Input
int countOfPensPackages = int.Parse(Console.ReadLine());
int countOfMarkersPackages = int.Parse(Console.ReadLine());
int litersBoardCleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

// Calculations

//•	Package of pens - 5.80 lv. 
//•	Package of markers - 7.20 lv. 
//•	Board cleaner - 1.20 BGN (per liter)

double priceForPens = countOfPensPackages * 5.80;
double priceForMarkers = countOfMarkersPackages * 7.20;
double priceForBoardCleaner = litersBoardCleaner * 1.20;
double priceForAllMaterilas = priceForPens + priceForMarkers + priceForBoardCleaner;

double discount = priceForAllMaterilas * discountPercentage / 100;

double finalPrice = priceForAllMaterilas - discount;

// Output
Console.WriteLine(finalPrice);



