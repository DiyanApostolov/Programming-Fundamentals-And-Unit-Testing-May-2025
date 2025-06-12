//1. въведохме списък с цели числа
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

//2. премахвам отрицателните числа
//numbers = {3, -4, 5, 1 , -2}
numbers.RemoveAll(number => number < 0);
//RemoveAll -> премахва всички елементи, които отговарят на условието
//numbers = {3, 5, 1}

//3. обръщаме списъка наобратно
numbers.Reverse();
//numbers = {1, 5, 3}

//4. отпечатваме списъка
if (numbers.Count == 0)
{
    //списъкът е празен -> бр. елементи = 0
    Console.WriteLine("empty");
}
else
{
    //списъкът има елементи
    Console.WriteLine(string.Join(" ", numbers));
}


