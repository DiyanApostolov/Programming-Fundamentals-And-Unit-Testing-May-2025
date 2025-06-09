
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n]; // нов масив с n на брой елементи

for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

// обикаляме масива от последния елемент към първия 
// (от последния индекс към нулевия)
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
