//входни данни
string product = Console.ReadLine();
//всички възможни продукти: "coffee",  "water", "coke" or "snacks"
int quantity = int.Parse(Console.ReadLine());

PrintFinalPrice(product, quantity);


//метод, който приема продукт и количество
//изчислява крайната сума на поръчката
//отпечатва крайната сума

static void PrintFinalPrice (string product, int quantity)
{
    double productPrice = 0; //цена за продукта (зависи от вида на продукта)
    //проверка кой е продукта
    //всички възможни продукти: "coffee",  "water", "coke" or "snacks"
    switch (product)
    {
        case "coffee":
            productPrice = 1.50;
            break;
        case "water":
            productPrice = 1.00;
            break;
        case "coke":
            productPrice = 1.40;
            break;
        case "snacks":
            productPrice = 2.00;
            break;
    }


    //крайна сума = цена на продукт * количество
    double finalPrice = productPrice * quantity;
    Console.WriteLine($"{finalPrice:F2}");
}
