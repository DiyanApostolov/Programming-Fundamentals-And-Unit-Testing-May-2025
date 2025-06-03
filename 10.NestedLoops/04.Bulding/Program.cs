
int countOfFloors = int.Parse(Console.ReadLine());
int countOfRooms = int.Parse(Console.ReadLine());

for (int floor = countOfFloors; floor >= 1; floor--)
{
	for (int room = 0; room < countOfRooms; room++)
	{
        if(countOfFloors == floor) // last floor -> Large apartment
		{
			Console.Write($"L{floor}{room} ");
		}
		else if (floor % 2 == 0)  // even floor -> Office
		{
            Console.Write($"O{floor}{room} ");
        }
		else if (floor % 2 != 0)  // odd floor -> Apartment
		{
            Console.Write($"A{floor}{room} ");
        }
	}

    Console.WriteLine();
}

//L60 L61 L62 L63
//A50 A51 A52 A53
//O40 O41 O42 O43
//A30 A31 A32 A33
//O20 O21 O22 O23
//A10 A11 A12 A13

