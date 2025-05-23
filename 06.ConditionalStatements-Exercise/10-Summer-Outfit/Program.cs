int degree = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();
string outfit = "";
string shoes = "";

if (degree >= 10 && degree <= 18)
{
    switch (timeOfDay)
    {
        case "Morning":
            outfit = "Sweatshirt";
            shoes = "Sneakers";
            break;
        case "Afternoon":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;

    }
}
else if (degree > 18 && degree <= 24)
{
    switch (timeOfDay)
    {
        case "Morning":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;
        case "Afternoon":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;

    }

}
else if (degree >= 25)
{
    switch (timeOfDay)
    {
        case "Morning":
            outfit = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Afternoon":
            outfit = "Swim Suit";
            shoes = "Barefoot";
            break;
        case "Evening":
            outfit = "Shirt";
            shoes = "Moccasins";
            break;

    }

}
Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");