//Task 1: Even and Odd Number Counter

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int even = 0;
//        int odd = 0;

//        Console.WriteLine("Enter 10 numbers:");

//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Number {i + 1}: ");
//            int number = int.Parse(Console.ReadLine());

//            if (number == 0)
//            {
//                Console.WriteLine("You entered zero; input was stopped.");
//                break;
//            }

//            if (number < 0)
//            {
//                continue;
//            }

//            if (number % 2 == 0)
//            {
//                even++;
//            }
//            else
//            {
//                odd++;
//            }
//        }

//        Console.WriteLine();
//        Console.WriteLine("Number of even numbers: " + even);
//        Console.WriteLine("Number of odd numbers: " + odd);
//    }
//}



// Task 2: Grade Evaluation

/*using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;

        Console.Write("Enter a grade (0–100):");
        grade = int.Parse(Console.ReadLine());

        while (grade < 0 || grade > 100)
        {
            Console.Write("Invalid grade. Please enter a number between 0 and 100:");
            grade = int.Parse(Console.ReadLine());
        }

        if (grade >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }
}
*/


//Task 3: Simple Calculator

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("+  Addition");
            Console.WriteLine("-  Subtraction");
            Console.WriteLine("*  Multiplication");
            Console.WriteLine("/  Division");

            Console.Write("Enter your choice: ");
            char operation = Console.ReadLine()[0];

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                case '/':
                    if (num2 != 0)
                        Console.WriteLine("Result: " + (num1 / num2));
                    else
                        Console.WriteLine("Error: Division by zero");
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.Write("\nDo you want to continue? (y/n): ");
            char choice = Console.ReadLine().ToLower()[0];

            if (choice == 'n')
            {
                Console.WriteLine("Program ended.");
                break;
            }

            Console.WriteLine();
        }
    }
}


