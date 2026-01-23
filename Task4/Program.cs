using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "C:\\Users\\Raghad\\source\\repos\\C#Tasks\\Task4\\Employees.txt";

        string outputFile = Path.Combine(
            Path.GetDirectoryName(inputFile),
            "result.txt"
        );

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Employees.txt file not found.");
            return;
        }

        string[] lines = File.ReadAllLines(inputFile);

        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (string line in lines)
            {
                string[] parts = line.Split('\\');

                string name = parts[0];
                string salary = parts[1];
                string department = parts[2];

                string resultLine = $"{name} works in {department} and earns {salary}";

                Console.WriteLine(resultLine);

                writer.WriteLine(resultLine);
            }
        }

        Console.WriteLine("\nData written successfully to result.txt");
    }
}
