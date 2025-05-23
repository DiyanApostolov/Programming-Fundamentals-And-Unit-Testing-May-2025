int n1 = int.Parse(Console.ReadLine()); //първо число
int n2 = int.Parse(Console.ReadLine()); //второ число
int n3 = int.Parse(Console.ReadLine()); //трето число
int n4 = int.Parse(Console.ReadLine()); //четвърто число
int n5 = int.Parse(Console.ReadLine()); //пето число

//вариант 1: най-голямото число да е първото число (n1)
//вариант 2: най-голямото число да е второто число (n2)
//вариант 3: най-голямото число да е третото число (n3)
//вариант 4: най-голямото число да е четвъртото число (n4)
//вариант 5: най-голямото число да е петото число (n5)

if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
{
    //първото число е най-голямо
    Console.WriteLine(n1);
}
else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
{
    //второто число е най-голямо
    Console.WriteLine(n2);
}
else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
{
    //третото число е най-голямо
    Console.WriteLine(n3);
}
else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
{
    //четвъртото число е най-голямо
    Console.WriteLine(n4);
}
else if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4)
{
    //петото число е най-голямо
    Console.WriteLine(n5);
}