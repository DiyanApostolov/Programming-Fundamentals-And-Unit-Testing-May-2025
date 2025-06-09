//входни данни
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

//Изчисляваме факториел на първото число
int factFirstNumber = CalculateFactorial(firstNumber);

//Изчисляваме факториел на второто число
int factSecondNumber = CalculateFactorial(secondNumber);

//Разделяме факториел на първото число на факториел на второто число
int result = factFirstNumber / factSecondNumber;

//отпечатваме резултата при делението
Console.WriteLine(result);




//метод, който приема цяло число
//изчислява факториела му
//връща стойността на факториела
static int CalculateFactorial (int number)
{
    //number = 5
    //5! = 1 * 2 * 3 * 4 * 5
    int fact = 1; //факториела на числото
    for (int i = 1; i <= number; i++)
    {
        //i -> съхранявам всяко едно число от 1 до моето
        fact = fact * i;
    }
    //изчислен факториел в променлива fact
    return fact;

}