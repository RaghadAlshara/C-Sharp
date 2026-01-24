using System;

abstract class Person
{
    // Private Fields
    private int id;
    private string name;

    // Getters and Setters
    public int GetId()
    {
        return id;
    }

    public void SetId(int value)
    {
        if (value > 0)
            id = value;
        else
            Console.WriteLine("Error: Id must be greater than 0.");
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    // Constructor
    public Person(int id, string name)
    {
        SetId(id);
        SetName(name);
    }

    // Methods
    public abstract string GetRole();   // Abstract method

    public virtual void GetInfo()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Name: {name}");
    }
}


class Student : Person
{
    // Private Fields
    private string major;
    private double gpa;

    // Constructor
    public Student(int id, string name, string major, double gpa)
        : base(id, name)
    {
        this.major = major;
        this.gpa = gpa;
    }

    // Override GetRole (Polymorphism)
    public override string GetRole()
    {
        return "Student";
    }

    // Optional override
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Role: {GetRole()}");
        Console.WriteLine($"Major: {major}");
        Console.WriteLine($"GPA: {gpa}");
    }
}


class Instructor : Person
{
    // Private Fields
    private string department;
    private double salary;

    // Constructor
    public Instructor(int id, string name, string department, double salary)
        : base(id, name)
    {
        this.department = department;
        this.salary = salary;
    }

    // Override GetRole (Polymorphism)
    public override string GetRole()
    {
        return "Instructor";
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Role: {GetRole()}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Salary: {salary}");
    }
}



class Program
{
    static void Main()
    {
        // Polymorphism
        Person p1 = new Student(1, "Raghad Alshare", "Biomedical Engineering", 4.0);
        Person p2 = new Instructor(2, "Raghad Alshare, PhD", "Bioengineering", 92000);

        Console.WriteLine("      Student Info      ");
        p1.GetInfo();
        Console.WriteLine();

        Console.WriteLine("      Instructor Info      ");
        p2.GetInfo();
    }
}




