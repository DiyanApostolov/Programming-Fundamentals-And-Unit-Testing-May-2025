
int startRange = int.Parse(Console.ReadLine());
int endRange = int.Parse(Console.ReadLine());

for (int currNum = startRange; currNum <= endRange; currNum++)
{
	bool isPrime = true;

	for (int n = 2; n < currNum; n++) // search prime number
	{
		if (currNum % n == 0)
		{
			isPrime = false;
			break;
		}
	}

	if (isPrime)
		Console.Write(currNum + " ");
}