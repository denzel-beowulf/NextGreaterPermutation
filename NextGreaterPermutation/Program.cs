using System;

namespace NextGreaterPermutation;
class Program
{
    static void Main(string[] args)
    {
        // Create a vector of integers
        int[] nums = { 1, 5, 8, 4, 7, 6, 5, 3, 1 };

        // Print the original vector
        Console.WriteLine("Original vector: " + string.Join(", ", nums));

        // Call the function that finds the next permutation
        NextPermutation(nums);

        // Print the next permutation
        Console.WriteLine("Next permutation: " + string.Join(", ", nums));
    }
}