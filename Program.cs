using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(isAdmin);

        // Task 2
        Console.WriteLine("Enter an integer:");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        if (inputNumber % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }

        // Task 3
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Task 4
        int[] numbers = { 2, 4, 6, 8, 10 };
        int sum = 0;
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            sum += number;
        }
        Console.WriteLine(sum);

        // Task 5
        Greet("Alice");
    }

    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}

