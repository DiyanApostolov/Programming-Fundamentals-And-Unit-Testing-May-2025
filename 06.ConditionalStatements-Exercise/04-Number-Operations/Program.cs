double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();

//аритметични операции (operation)
//"+" -> събиране на двете въведени числа
//"-" -> изваждане на двете въведени числа
//"*" -> умножение на двете въведени числа
//"/" -> деление на двете въведени числа

switch (operation)
{
    case "+":
        //събиране на двете въведени числа
        double sum = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber} + {secondNumber} = {sum:F2}");
        break;

    case "-":
        //изваждане на двете въведени числа
        double diff = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber} - {secondNumber} = {diff:F2}");
        break;

    case "*":
        //умножение на двете въведени числа
        double product = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {product:F2}");
        break;

    case "/":
        //деление на двете въведени числа
        double division = firstNumber / secondNumber;
        Console.WriteLine($"{firstNumber} / {secondNumber} = {division:F2}");
        break;
}



