
// Input
int trainingFee = int.Parse(Console.ReadLine());

// Calculations
double sneakers = trainingFee - (trainingFee * 0.4); // -40%
double uniform = sneakers * 0.8;                     // -20% - short way
double ball = uniform / 4;                           // -75% -> * 0.25 - short way
double accessories = ball / 5;                       // -80% -> * 0.2 - short way

double finalPrice = trainingFee + sneakers + uniform + ball + accessories;

// Output
Console.WriteLine(finalPrice);