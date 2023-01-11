using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        append(numbers);
        int total = sum(numbers);
        average(numbers, total);
        largest(numbers);
        smallest(numbers);
        print_sorted_list(numbers);
    }
    public static void append(List<int> numbers)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            string number = Console.ReadLine();
            int valid = int.Parse(number);
            if (valid == 0)
            {
                break;
            }
            else
            {
                numbers.Add(valid);
            }
        }
    }
    public static void print_sorted_list(List<int> numbers)
    {
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
    public static int sum(List<int> numbers)
    {
        int x = 0;
        foreach (int number in numbers)
        {
            x += number;
        }

        Console.WriteLine($"The sum is: {x}");
        return x;
    }
    public static void average(List<int> numbers, int sum)
    {
        float avrg = ((float)sum) / numbers.Count;
        //Math.Round(avrg);  dont know how to roud with two decimal points!
        Console.WriteLine($"The average is: {avrg}");
    }
    public static void largest(List<int> numbers)
    {
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
    public static void smallest(List<int> numbers)
    {
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The smallest number is {min}");
    }

}