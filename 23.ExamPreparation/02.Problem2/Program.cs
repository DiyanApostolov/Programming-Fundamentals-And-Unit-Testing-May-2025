
int[] number = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();

int rigthMiddleIndex = number.Length / 2;
int leftMiddleIndex = number.Length / 2 - 1;

int rigthMiddleElement = number[rigthMiddleIndex];
int leftMiddleElement = number[leftMiddleIndex];

double average = (rigthMiddleElement + leftMiddleElement) / 2.0;

Console.WriteLine($"{average:F2}");

    
