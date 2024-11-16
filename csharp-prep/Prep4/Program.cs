using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userNumber;
        int number = -1;

        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            userNumber = Console.ReadLine();
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}