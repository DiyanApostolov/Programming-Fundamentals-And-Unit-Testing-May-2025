int countProducts = int.Parse(Console.ReadLine());
List<string> products = new List<string>(); //списък, в който ще съхраняваме въведените продукти


for (int product = 1; product <= countProducts; product++)
{
    //какво искам да повторя за всеки един продукт от първия до последния
    string productName = Console.ReadLine();
    products.Add(productName);
}

//products = {"Potatoes", "Tomatoes", "Onions", "Apples"}

products.Sort(); //подрежда продуктите по име в нарастващ ред

//products = {"Apples", "Onions", "Potatoes", "Tomatoes"}

int number = 1; //поредния номер на продукта
foreach (string product in products)
{
    Console.WriteLine(number + "." + product);
    number++;
}

