using System;

public class Person
{
    // Fields
    private string name;
    private int age;

    // Constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of the Person class
        Person person = new Person("John Doe", 30);

        // Accessing properties
        person.Name = "Jane Doe";
        person.Age = 25;

        // Calling a method
        person.Introduce();
    }
}
