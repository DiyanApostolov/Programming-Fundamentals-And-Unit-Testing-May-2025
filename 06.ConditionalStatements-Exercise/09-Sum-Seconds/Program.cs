//1. входни данни
int time1 = int.Parse(Console.ReadLine());
int time2 = int.Parse(Console.ReadLine());
int time3 = int.Parse(Console.ReadLine());

//2. общото време в секунди
int totalTimeInSeconds = time1 + time2 + time3;

//3. преобразуваме в минути и секунди
int minutes = totalTimeInSeconds / 60;
int seconds = totalTimeInSeconds % 60;


//4. отпечатваме
//начин 1: форматиране на цяло число
//Console.WriteLine($"{minutes}:{seconds:D2}");

//начин 2: проверки
if (seconds >= 10)
{
    //двуцифрено число
    Console.WriteLine($"{minutes}:{seconds}");
}
else
{
    //seconds < 10 -> едноцифрено число
    Console.WriteLine($"{minutes}:0{seconds}");
}