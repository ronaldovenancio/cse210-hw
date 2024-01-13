using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        List<int> numbersSorted = new List<int>();
        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");          
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);
            //This part of code will add numbers differents of zero
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        
        // This part of code will compute the sum of the list numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // This part of the code will compute the average of the list numbers
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // This part of the code will find the maxint of the list numbers
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The min is: {min}");

        //This part of the code will show the ordered list numbers
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        Console.WriteLine(string.Join(",", numbers));

    }
}