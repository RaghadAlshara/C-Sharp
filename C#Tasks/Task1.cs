using System;

class Task1
{
    static void Main(string[] args)
    {
        //1
        Console.Write("Enter a string:");
        string Input = Console.ReadLine();
        Console.WriteLine("You entered:" + Input);

        Console.WriteLine();

        //2
        double MyDouble = 7.5;
        string MyString = "Raghad";
        char MyChar = 'R';
        bool MyBool = false;
        int MyInt = 8;
        const int MyConst = 40;   

        Console.WriteLine("Double: " + MyDouble);
        Console.WriteLine("String: " + MyString);
        Console.WriteLine("Char: " + MyChar);
        Console.WriteLine("Bool: " + MyBool);
        Console.WriteLine("Int: " + MyInt);
        Console.WriteLine("Const: " + MyConst);

        Console.WriteLine();

        
        //3
        string[] cars = { "Honda", "BMW", "GMC", "BYD" };

        Console.WriteLine("Cars in the array:");

        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }

        Console.WriteLine("Array length:" + cars.Length);

        Console.WriteLine();

      //4
        Console.Write("Input your first name: ");
        string FirstName = Console.ReadLine();

        Console.Write("Input your last name: ");
        string LastName = Console.ReadLine();

        Console.Write("Input your year of birth: ");
        int YearOfBirth = int.Parse(Console.ReadLine());

        Console.WriteLine("Output: " + FirstName + " " + LastName + " " + YearOfBirth);

        Console.WriteLine();

       //5
        int[] numbers = new int[10];

        Console.WriteLine("Input 10 elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"element - {i} : ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Elements are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}
