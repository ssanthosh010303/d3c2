/*
 * Author: Sakthi (Sandy) Santhosh
 * Created on: 11/04/2024
 *
 * Day-3 Challenge-2: Find the Largest Number
 */
namespace Challenge2;

class Program
{
    static void Main()
    {
        int largestNumber = int.MinValue;

        int number;
        string? inputData;

        Console.Write("Enter number(s): ");
        inputData = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputData)) return;

        foreach (string numberString in inputData.Split(' '))
        {
            number = int.Parse(numberString);
            if (number > largestNumber) largestNumber = number;
        }

        Console.WriteLine("\nResult");
        Console.WriteLine("  Largest number: " + largestNumber);
    }
}
