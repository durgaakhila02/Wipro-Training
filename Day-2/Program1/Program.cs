using System;

internal class Program
{
    static void Main()
    {
        // Number of students and subjects
        int stu = 3, sub = 4;
        int[,] m = new int[stu, sub];

        // Input marks for each student
        for (int i = 0; i < stu; i++)
        {
            Console.WriteLine($"Enter marks for Student {i + 1}:");
            for (int j = 0; j < sub; j++)
            {
                Console.Write($"Subject {j + 1}: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Average marks per student
        Console.WriteLine("\nAverage marks per student:");
        for (int i = 0; i < stu; i++)
        {
            int sum = 0;
            for (int j = 0; j < sub; j++)
            {
                sum += m[i, j];
            }
            double avgStudent = (double)sum / sub;
            Console.WriteLine($"Student {i + 1}: {avgStudent}");
        }

        // Average marks per subject
        Console.WriteLine("\nAverage marks per subject:");
        for (int j = 0; j < sub; j++)
        {
            int sum = 0;
            for (int i = 0; i < stu; i++)
            {
                sum += m[i, j];
            }
            double avgSubject = (double)sum / stu;
            Console.WriteLine($"Subject {j + 1}: {avgSubject}");
        }

        // Highest and lowest marks
        int highest = m[0, 0], lowest = m[0, 0];
        for (int i = 0; i < stu; i++)
        {
            for (int j = 0; j < sub; j++)
            {
                if (m[i, j] > highest) highest = m[i, j];
                if (m[i, j] < lowest) lowest = m[i, j];
            }
        }

        Console.WriteLine($"\nHighest mark: {highest}");
        Console.WriteLine($"Lowest mark: {lowest}");
    }
}
