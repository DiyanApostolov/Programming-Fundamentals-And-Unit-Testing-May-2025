//1. въвеждаме паролата (текст)
string password = Console.ReadLine();

//2. проверка за паролата

if (password == "s3cr3t!")
{
    Console.WriteLine("Welcome");
}
else
{
    //противен случай: password != "s3cr3t!"
    Console.WriteLine("Wrong password!");
}

