//създаваме празен списък
List<int> numbersList = new List<int>();

//създаваме списък с предварително зададени елементи
List<string> names = new() { "Peter", "Ana", "Maria" };

//размер на списъка = броя на елементите в него
Console.WriteLine(names.Count);
int count = names.Count;

//достъп до елементите на списъка
Console.WriteLine(names[0]); //първия елемент в списъка
Console.WriteLine(names[names.Count - 1]); //последния елемент в списъка
string firstName = names[1];

//добавяне на елемент в края на списъка
names.Add("Desi");

//добавяме елемент на произволно място в списъка - вмъкване
names.Insert(1, "Ivan");

//премахвам първото срещане на елемент от списъка
names.Remove("Ana");

//премахваме елемент от дадена позиция
names.RemoveAt(0);

//проверка дали в списъка се съдържа даден елемент
Console.WriteLine(names.Contains("Desi")); //True
bool isContains = names.Contains("Georgi"); //False
if (names.Contains("Desi"))
{
    Console.WriteLine("Desi is coming!");
}

//oбхождане на списък
//1 начин: for цикъл
for (int position = 0; position <= names.Count - 1; position++)
{
    string name = names[position];
    Console.WriteLine(name);
}

//2 начин: foreach цикъл
foreach (string name in names)
{
    Console.WriteLine(name);
}

//прочитане на списък от конзолата
//"45 67 23 12 98".Split()
//-> ["45", "67", "23", "12", "98"].Select(int.Parse)
//-> [45, 67, 23, 12, 98].ToList()
//-> {45, 67, 23, 12, 98}


List<int> numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

List<double> grades = Console.ReadLine() //"3.45 7.65 8.12 9.14"
                    .Split(' ')          //["3.45", "7.65", "8.12", "9.14"]
                    .Select(double.Parse)//[3.45, 7.65, 8.12, 9.14]
                    .ToList();           //{3.45, 7.65, 8.12, 9.14}

List<string> towns = Console.ReadLine()  //"Rome, Sofia, Belgrade"
                     .Split(", ")        //["Rome", "Sofia", "Belgrade"]
                     .ToList();          //{"Rome", "Sofia", "Belgrade"}


//премахваме всички елементи в списъка
names.Clear();

//сортиране на списък
//нарастващ ред (ascending order)
List<int> nums = new() { 4, 5, 12, 1, -5, 76, 34 };
nums.Sort(); //подрежда / сортира елементите в нарастващ ред
//nums = {-5, 1, 4, 5, 12, 34, 76}


//намаляващ ред (descending order)
List<int> numsList = new() { 4, 5, 12, 1, -5, 76, 34 };
numsList.Sort();//подрежда / сортира елементите в нарастващ ред
//numsList = {-5, 1, 4, 5, 12, 34, 76}
numsList.Reverse(); //обръща списъка наобратно
//numsList =  {76, 34, 12, 5, 4, 1, -5}
//получаваме списъка сортиран / подреден в намаляващ ред

