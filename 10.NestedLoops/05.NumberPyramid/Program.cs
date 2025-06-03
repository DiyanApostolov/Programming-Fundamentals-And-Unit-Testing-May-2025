
int end = int.Parse(Console.ReadLine());

int counter = 0;

bool isReach = false;

for (int row = 1; row <= end; row++)
{
	for (int col = 1; col <= row; col++)
	{
		counter++;
        Console.Write(counter + " ");

		if (counter == end)
		{
			isReach = true;
			break;
		}
	}

	if (isReach)
		break;

    Console.WriteLine();
}

