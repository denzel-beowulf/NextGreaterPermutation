using System;
using NextGreaterPermutation;

namespace NextGreaterPermutation;
class Program
{
    static void Main(string[] args)
    {
        // Create a vector of integers
        int[] nums = { 1, 2, 3};

        // Print the original vector
        Console.WriteLine("Original vector: " + string.Join(", ", nums));

        // Call the function that finds the next permutation
        var perm = new Permutation();
        perm.NextPermutation(nums);

        // Print the next permutation
        Console.WriteLine("Next permutation: " + string.Join(", ", nums));
    }
}