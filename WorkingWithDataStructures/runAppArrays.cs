using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDataStructures
{
    internal class runAppArrays
    {
        public runAppArrays()
        {
            // Demonstrate working with arrays

            // Example 1: Creating and initializing an array
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array of numbers: " + string.Join(", ", numbers));

            // Example 2: Accessing elements of an array
            Console.WriteLine("First element: " + numbers[0]);
            Console.WriteLine("Second element: " + numbers[1]);

            // Example 3: Modifying elements of an array
            numbers[2] = 10;
            Console.WriteLine("Modified array: " + string.Join(", ", numbers));

            // Example 4: Iterating through an array using a for loop
            Console.Write("Array elements using a for loop: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // Example 5: Iterating through an array using foreach loop
            Console.Write("Array elements using a foreach loop: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Example 6: Multidimensional array
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("2D Array:");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            // Example 7: Jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 5, 6, 7 };
            jaggedArray[2] = new int[] { 8, 9 };

            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
