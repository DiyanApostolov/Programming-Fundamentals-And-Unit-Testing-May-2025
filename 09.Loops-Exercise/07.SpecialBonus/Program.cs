int stopNumber = int.Parse(Console.ReadLine());
//ако от конзолата се въведе число = stopNumber -> прекратяваме въвеждането на числа

//while цикъл
//повтаряме: въвеждаме цяло число
//стоп: въведеното число == stopNumber
//продължаваме: въведено число != stopNumber

int previousNumber = 0;
int enteredNumber = int.Parse(Console.ReadLine());

while (enteredNumber != stopNumber)
{
    previousNumber = enteredNumber;
    enteredNumber = int.Parse(Console.ReadLine());
}

//enteredNumber == stopNumber
//1. намеря предишното въведено
//2. предишно въведено + 20%
//3. отпечатвам
Console.WriteLine(previousNumber * 1.20);