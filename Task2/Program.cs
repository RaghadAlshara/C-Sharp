using System;

class Program
{
    static void Main(string[] args)
    {
        int even = 0;
        int odd = 0;

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("You entered zero; input was stopped.");
                break;
            }

            if (number < 0)
            {
                continue;
            }

            if (number % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Number of even numbers: " + even);
        Console.WriteLine("Number of odd numbers: " + odd);
    }
}
