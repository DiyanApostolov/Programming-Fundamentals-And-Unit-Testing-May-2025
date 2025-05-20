//булева променлива

bool isValid = 5 < 6; //true
Console.WriteLine(isValid);

// if конструкция -> искаме да проверим дали едно нещо е вярно
// if-else конструкция -> искаме да проверим дали едно нещо е вярно или грешно
// серия от проверки if-else if -> искаме за една променлива да направим повече от една
//                                 проверки, от които искаме само една да е изпълнена


//при съзадаване на променлива -> тип, име стойност

string currentDay = "Monday";
if (currentDay == "Monday")
{
    double salary = double.Parse(Console.ReadLine());
    Console.WriteLine(salary);
    {
        salary += 50;
        {
            Console.WriteLine(salary);
        }
    }
}
//Console.WriteLine(salary); променливата не може да бъде използвана във външен блок от код