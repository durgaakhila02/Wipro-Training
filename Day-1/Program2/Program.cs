using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Please enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Hello " + name + "!");

        Console.WriteLine("Enter the age:");
        string ageInput = Console.ReadLine();
        int age = int.Parse(ageInput);

        if (age > 0)
        {
            if (age >= 18)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
