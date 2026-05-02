using System;

class Program
{
    static void Main(string[] args)
    {
        // Add values to list
        string userInput;
        int newListValue;
        List<int> numList = new();
        do
        {
            Console.Write("Enter a series of numbers (type 0 to stop): ");
            userInput = Console.ReadLine();
            newListValue = int.Parse(userInput);
            if (newListValue == 0)
            {
                // Do nothing
            }
            else
            {
                numList.Add(newListValue);
            }
        }
        while (newListValue != 0);

        // Compute sum and largest number
        int sumTotal = 0;
        int largestNumber = 0;
        foreach (int num in numList)
        {
            sumTotal += num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        Console.WriteLine($"The sum is: {sumTotal}");

        // Compute average
        double listAverage = ((double)sumTotal / numList.Count);
        Console.WriteLine($"The average is: {listAverage}");

        // Print largest number
        Console.WriteLine($"The largest number is: {largestNumber}");
        
    }
}