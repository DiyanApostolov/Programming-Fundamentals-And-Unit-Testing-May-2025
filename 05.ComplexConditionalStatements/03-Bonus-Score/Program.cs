//1. въвеждаме входните данни
int points = int.Parse(Console.ReadLine());

//2. проверка за стойността на точките
if (points >= 0 && points <= 3)
{
    //точките са в диапазона [0; 3]
    points = points + 5; //points += 5;

}
else if (points >= 4 && points <= 6)
{
    //точките са в диапазона [4; 6]
    points = points + 15; //points += 15;
}
else if (points >= 7 && points <= 9)
{
    //точките са в диапазона [7; 9]
    points = points + 20; //points += 20;
}

//3. отпечатваме крайните точки
Console.WriteLine(points);