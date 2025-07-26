using System;
using System.Collections.Generic;

class CircularShifter
{
    static void Main()
    {
        const int arraySize = 10;
        int[] original = new int[arraySize];

        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Element {i + 1}: ");
            while (int.TryParse(Console.ReadLine(), out original[i]))
            {
                Console.Write("Invalid input. ");
            }
        }

        Console.Write("\nEnter shift value k: ");
        int k;
        while (!int.TryParse(Console.ReadLine(), out k) || k < 0)
        {
            Console.Write("Invalid input. ");
        }

        k = k % arraySize;

        int[] shifted = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            shifted[(i + k) % arraySize] = original[i];
        }

        Console.WriteLine("\nOriginal Array:");
        Console.WriteLine(string.Join(", ", original));

        Console.WriteLine("\nShifted Array:");
        Console.WriteLine(string.Join(", ", shifted));
    }
}
