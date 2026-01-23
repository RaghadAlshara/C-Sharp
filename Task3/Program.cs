//Task 1: 3x3 array

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] matrix = new int[3, 3];



//        Console.WriteLine("Enter values for in a 3x3 array:");

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write($"Element [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }



//        Console.WriteLine("\n3x3 Array:");

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}










//Task 2: 4x4 array

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] array =
//        {
//            { 1,  2,  3,  4 },
//            { 5,  6,  7,  8 },
//            { 9, 10, 11, 12 },
//            {13, 14, 15, 16 }
//        };



//        Console.WriteLine("Row sums:");
//        for (int i = 0; i < 4; i++)
//        {
//            int RowSum = 0;

//            for (int j = 0; j < 4; j++)
//            {
//                RowSum += array[i, j];
//            }

//            Console.WriteLine($"Row {i + 1} sum: {RowSum}");
//        }

//        Console.WriteLine();




//        Console.WriteLine("Column sums:");
//        for (int j = 0; j < 4; j++)
//        {
//            int ColSum = 0;

//            for (int i = 0; i < 4; i++)
//            {
//                ColSum += array[i, j];
//            }

//            Console.WriteLine($"Column {j + 1} sum: {ColSum}");
//        }
//    }
//}






//Task 3: 5x5 array

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] array = new int[5, 5];
//        Random random = new Random();


//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                array[i, j] = random.Next(1, 51);
//            }
//        }



//        Console.WriteLine("5x5 Array:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(array[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }

//        Console.WriteLine();



//        Console.WriteLine("Largest value in each row:");
//        for (int i = 0; i < 5; i++)
//        {
//            int max = array[i, 0];

//            for (int j = 1; j < 5; j++)
//            {
//                if (array[i, j] > max)
//                {
//                    max = array[i, j];
//                }
//            }

//            Console.WriteLine($"Row {i + 1}: {max}");
//        }

//        Console.WriteLine();



//        Console.WriteLine("Smallest value in each column:");
//        for (int j = 0; j < 5; j++)
//        {
//            int min = array[0, j];

//            for (int i = 1; i < 5; i++)
//            {
//                if (array[i, j] < min)
//                {
//                    min = array[i, j];
//                }
//            }

//            Console.WriteLine($"Column {j + 1}: {min}");
//        }
//    }
//}







//Task 4: Jagged array of 3 rows

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {

//        int[][] JaggedArray = new int[3][];

//        JaggedArray[0] = new int[2]; 
//        JaggedArray[1] = new int[3]; 
//        JaggedArray[2] = new int[4]; 

//        Console.WriteLine("Enter values for the jagged array:");

//        for (int i = 0; i < JaggedArray.Length; i++)
//        {
//            for (int j = 0; j < JaggedArray[i].Length; j++)
//            {
//                Console.Write($"Row {i + 1}, Element {j + 1}: ");
//                JaggedArray[i][j] = int.Parse(Console.ReadLine());
//            }
//        }


//        Console.WriteLine("\nJagged Array:");

//        for (int i = 0; i < JaggedArray.Length; i++)
//        {
//            for (int j = 0; j < JaggedArray[i].Length; j++)
//            {
//                Console.Write(JaggedArray[i][j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}





// Task 5: Jagged array of random row numbers

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter the number of rows:");
//        int rows = int.Parse(Console.ReadLine());


//        int[][] JaggedArray = new int[rows][];


//        for (int i = 0; i < rows; i++)
//        {
//            Console.Write($"Enter number of elements for row {i + 1}: ");
//            int cols = int.Parse(Console.ReadLine());

//            JaggedArray[i] = new int[cols];

//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"Row {i + 1}, Element {j + 1}: ");
//                JaggedArray[i][j] = int.Parse(Console.ReadLine());
//            }
//        }



//        Console.WriteLine("\nJagged Array:");

//        for (int i = 0; i < JaggedArray.Length; i++)
//        {
//            for (int j = 0; j < JaggedArray[i].Length; j++)
//            {
//                Console.Write(JaggedArray[i][j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}







// Task 6: Jagged rray of 5 rows


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int rows = 5;
//        int[][] JaggedArray = new int[rows][];
//        Random random = new Random();      //an object of a c# class called Random to generate random numbers 


//        for (int i = 0; i < rows; i++)
//        {
//            JaggedArray[i] = new int[i + 1]; 

//            for (int j = 0; j < JaggedArray[i].Length; j++)
//            {
//                JaggedArray[i][j] = random.Next(1, 101);
//            }
//        }



//        for (int i = 0; i < rows; i++)
//        {
//            int sum = 0;

//            for (int j = 0; j < JaggedArray[i].Length; j++)
//            {
//                Console.Write(JaggedArray[i][j] + " ");
//                sum += JaggedArray[i][j];
//            }

//            Console.WriteLine($"        Sum of Row {i + 1}: {sum}");
//        }
//    }
//}






//Task 7: a list of 5 integers

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int>();

//        for (int i = 0; i < 5; i++)
//        {
//            Console.Write($"Enter number {i + 1}: ");
//            int num = int.Parse(Console.ReadLine());
//            numbers.Add(num);
//        }

//        Console.WriteLine("\nYou entered:");
//        foreach (int n in numbers)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}







//Task 8: list of strings (names)

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> studentNames = new List<string>
//        {
//            "Raghad",
//            "Ahmad",
//            "Sara",
//            "Alia",
//            "Jimmy"
//        };

//        studentNames.Sort();

//        Console.WriteLine("Student names in alphabetical order:");
//        foreach (string name in studentNames)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}







//Task 9: list of integers with calculations

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        while (true)
        {
            Console.Write("Enter a number (-1 to stop):");
            input = int.Parse(Console.ReadLine());

            if (input == -1)
                break;

            numbers.Add(input);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        Console.WriteLine("\nNumbers entered:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = sum / numbers.Count;

        int max = numbers[0];
        int min = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max) { 
                max = num; 
            }
            if (num < min) { 
                min = num; 
            }
        }

        numbers.Sort();

        Console.WriteLine("\n\nAverage:" + average);
        Console.WriteLine("Largest number:" + max);
        Console.WriteLine("Smallest number:" + min);

        Console.WriteLine("\nSorted list (ascending):");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
