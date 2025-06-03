using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        double inputGrade = double.Parse(Console.ReadLine());

        PrintGradeInWords(inputGrade);
    }

    static void PrintGradeInWords(double grade)
    {
        string word = "";

        if (grade >= 2.00 && grade <= 2.99)
            word = "Fail";
        else if (grade >= 3.00 && grade <= 3.49)
            word = "Average";
        else if (grade >= 3.50 && grade <= 4.49)
            word = "Good";
        else if (grade >= 4.50 && grade <= 5.49)
            word = "Very good";
        else if (grade >= 5.50 && grade <= 6)
            word = "Excellent";
        
        Console.WriteLine(word);
    }



}