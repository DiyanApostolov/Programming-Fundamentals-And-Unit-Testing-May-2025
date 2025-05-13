// Input
int numberOfPagesToRead = int.Parse(Console.ReadLine());
int pagesReadPerHour = int.Parse(Console.ReadLine());
int countOfDays = int.Parse(Console.ReadLine());

// Calculations
int totalHoursToRead = numberOfPagesToRead / pagesReadPerHour;
int readHoursPerDay = totalHoursToRead / countOfDays;

// Output
Console.WriteLine(readHoursPerDay);