//входни данни
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

//вариант 1: нарастващ ред -> n1 < n2 < n3
//вариант 2: намаляващ ред -> n1 > n2 > n3
//вариант 3: не са сортирани

if (n1 < n2 && n2 < n3)
{
    //числата са подредени в нарастващ ред
    Console.WriteLine("Ascending");
}
else if (n1 > n2 && n2 > n3)
{
    //числата са подредени в намаляващ ред
    Console.WriteLine("Descending");
}
else
{
    //числата са произволни и не са сортирани
    Console.WriteLine("Not sorted");
}
