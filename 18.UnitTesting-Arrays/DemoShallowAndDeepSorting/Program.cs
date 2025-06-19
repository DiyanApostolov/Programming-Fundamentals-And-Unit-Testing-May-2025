Console.WriteLine("Deep Sorting");

int[] numbers = { 3, 2, 1 };

Console.WriteLine(string.Join(", ", numbers));

Array.Sort(numbers);

Console.WriteLine(string.Join(", ", numbers));

//------------------------------------------------------

Console.WriteLine("Shallow Sorting");

int[] nums = { 3, 2, 1 };

Console.WriteLine(string.Join(", ", nums));

int[] shallowSortArray = nums.OrderBy(x => x).ToArray();

Console.WriteLine(string.Join(", ", nums));
Console.WriteLine(string.Join(", ", shallowSortArray));
