using System;

class Car
{
    //properties
    private string brand;
    private string model;
    private int year;

    //sets and gets
    public void SetBrand(string b)
    {
        brand = b;
    }

    public void SetModel(string m)
    {
        model = m;
    }

    public void SetYear(int y)
    {
        year = y;
    }

    public string GetBrand()
    {
        return brand;
    }

    public string GetModel()
    {
        return model;
    }

    public int GetYear()
    {
        return year;
    }

    // Methods
    public void Start()
    {
        Console.WriteLine($"{brand} {model} is starting.");
    }

    public void Drive()
    {
        Console.WriteLine($"{brand} {model} is driving.");
    }

    public void Stop()
    {
        Console.WriteLine($"{brand} {model} has stopped.");
    }
}

class Program
{
    static void Main()
    {
        // objects
        Car car1 = new Car();
        car1.SetBrand("Toyota");
        car1.SetModel("Corolla");
        car1.SetYear(2020);

        Car car2 = new Car();
        car2.SetBrand("BMW");
        car2.SetModel("X5");
        car2.SetYear(2023);

        // Call methods
        car1.Start();
        car1.Drive();
        car1.Stop();

        Console.WriteLine();

        car2.Start();
        car2.Drive();
        car2.Stop();

        Console.WriteLine("\nCar Details:");
        Console.WriteLine($"{car1.GetBrand()} {car1.GetModel()} - {car1.GetYear()}");
        Console.WriteLine($"{car2.GetBrand()} {car2.GetModel()} - {car2.GetYear()}");
    }
}
