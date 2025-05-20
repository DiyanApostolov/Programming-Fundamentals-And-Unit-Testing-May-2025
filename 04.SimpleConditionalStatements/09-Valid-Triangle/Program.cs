int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool isValidTriangle = true;
if (a + b <= c)
	isValidTriangle = false;
else if (a + c <= b)
	isValidTriangle = false;
else if (b + c <= a)
	isValidTriangle = false;

if (isValidTriangle)
	Console.WriteLine("Valid Triangle");
else
	Console.WriteLine("Invalid Triangle");