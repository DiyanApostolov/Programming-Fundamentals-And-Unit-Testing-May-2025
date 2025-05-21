//1. въвеждаме входните данни
string product = Console.ReadLine();


//ако продуктът е: "curry", "noodles", "sushi", "spaghetti" or "bread" -> "food"
//ако продуктът е: "tea", "water", "coffee" or "juice" -> "drink"
//ако продуктът не е нито един от изброените -> "unknown"

if (product == "curry"
    || product == "noodles"
    || product == "sushi"
    || product == "spaghetti"
    || product == "bread")
{
    Console.WriteLine("food");
}
else if (product == "tea"
      || product == "water"
      || product == "coffee"
      || product == "juice")
{
    Console.WriteLine("drink");
}
else
{
    Console.WriteLine("unknown");
}