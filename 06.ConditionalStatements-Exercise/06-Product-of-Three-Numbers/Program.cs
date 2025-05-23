double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
double thirdNumber = double.Parse(Console.ReadLine());

//начин 1:
/* double product = firstNumber * secondNumber * thirdNumber;
if (product <  0)
{
    Console.WriteLine("negative");
}
else if (product > 0)
{
    Console.WriteLine("positive");
}
else if (product == 0)
{
    Console.WriteLine("zero");
} */


//начин 2:
//произведението = 0
if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
{
    Console.WriteLine("zero");
}
else
{
    //произведението < 0 -> броя на отрицателните числа да е нечетен
    //произведението > 0 -> броя на отрицателните числа да е четен

    int countNegativeNumbers = 0; //брой на отрицателните числа

    //проверка за всяко едно число
    if (firstNumber < 0)
    {
        countNegativeNumbers += 1;
    }

    if (secondNumber < 0)
    {
        countNegativeNumbers += 1;
    }

    if (thirdNumber < 0)
    {
        countNegativeNumbers += 1;
    }

    //знаем колко е броя на отрицателните числа
    if (countNegativeNumbers % 2 == 0)
    {
        //четен брой отрицателни числа -> положително произведение
        Console.WriteLine("positive");
    }
    else
    {
        //нечетен брой отрицателни числа -> отрицателно произведение
        Console.WriteLine("negative");
    }
} 