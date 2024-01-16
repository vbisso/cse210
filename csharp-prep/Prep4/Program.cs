using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //Declaring variables and lists
        int number = 1;
        int sum = 0;
        int largestNumber = int.MinValue;
        int smallPositiveNumber = int.MaxValue;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //while loop
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
                sum += number;

                if (number > largestNumber)
                {
                    largestNumber = number;
                }
                if (number < smallPositiveNumber && number > 0)
                {
                    smallPositiveNumber = number;
                }

            }
        }

        //avg numb
        float avg = ((float)sum) / numbers.Count;
        numbers.Sort();

        //outputs
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallPositiveNumber}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}
