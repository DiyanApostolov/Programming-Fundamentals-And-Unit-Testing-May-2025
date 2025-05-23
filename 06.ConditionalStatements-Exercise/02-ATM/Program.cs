int balance = int.Parse(Console.ReadLine());
int withdraw = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

//вариант 1: успешно теглим парите -> имаме достатъчен баланс и не сме достигнали лимита
//вариант 2: надвишаваме лимита -> теглена сума > лимит
//вариант 3: нямаме достатъчен баланс -> теглена сума > баланс

if (balance >= withdraw && withdraw <= limit)
{
    //успешно сме изтеглили парите
    Console.WriteLine("The withdraw was successful.");
}
else if (withdraw > limit)
{
    //неуспешно теглене -> достигнали лимита
    Console.WriteLine("The limit was exceeded.");
}
else if (withdraw > balance)
{
    //неуспешно теглене -> нямаме достатъчен баланс
    Console.WriteLine("Insufficient availability.");
}
