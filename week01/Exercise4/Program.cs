using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished:");

        while(true)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            if(input == 0)
            {
                break;
            }

            numbers.Add(input);
        }

        int sum = 0;
        int max = numbers[0];

        foreach(int number in numbers)
        {
            sum += number;

            if(number > max)
            {
                max = number;
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        int smallestPositive = int.MaxValue;
        bool foundPositive = false;

        foreach(int number in numbers)
        {
            if(number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
                foundPositive = true;
            }
        }

        if(foundPositive)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        } 
    }
}