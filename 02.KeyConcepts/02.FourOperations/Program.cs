// Input
double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

// Calculations
double sum = firstNumber + secondNumber;
double subtraction = firstNumber - secondNumber;
double multiply = firstNumber * secondNumber;
double divide = firstNumber / secondNumber;

// Output
Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {sum:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {subtraction:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {multiply:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {divide:F2}");

