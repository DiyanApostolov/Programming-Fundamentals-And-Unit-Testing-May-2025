//1. входни данни
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());


//вариант 1: първото число да е най-голямо -> n1 > n2 и n1 > n3
//вариант 2: второто число да е най-голямо -> n2 > n1 и n2 > n3
//вариант 3: третото число да е най-голямо -> n3 > n2 и n3 > n1

if (n1 > n2 && n1 > n3)
{
    //първото число (n1) да е най-голямо
    Console.WriteLine(n1);
}
else if (n2 > n1 && n2 > n3)
{
    //второто число (n2) да е най-голямо
    Console.WriteLine(n2);
}
else if (n3 > n2 && n3 > n1)
{
    //третото число (n3) да е най-голямо
    Console.WriteLine(n3);
}


