using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();
        
        // Prompt the user to enter numbers until they type 0
        Console.WriteLine("Enter a list of number, type 0 when finished.");

        // Loop until the user types 0
        int number;
        do
        {
            Console.WriteLine("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);

        // Calculations of the numbers and display the results
        int sum = 0;
        foreach (int num in numbers)        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");
        int max = numbers[0];
        foreach (int num in numbers)        
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        int min = numbers[0];
        foreach (int num in numbers)        
        {
            if (num > 0 && num < min)
            {
                min = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {min}");
    }
}