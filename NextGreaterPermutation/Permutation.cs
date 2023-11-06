using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGreaterPermutation
{

    public class Permutation
    {
        public void NextPermutation(int[] nums)
        {
            // Find the first element that is smaller than its right neighbor
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            // If i is not found, reverse nums and return
            if (i < 0)
            {
                Array.Reverse(nums);
                return;
            }

            // Find the rightmost element that is greater than nums[i]
            int j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[i])
            {
                j--;
            }

            // Swap nums[i] and nums[j]
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;

            // Reverse the subarray nums[i+1..n-1]
            Array.Reverse(nums, i + 1, nums.Length - i - 1);

            // Return nums
            return;
        }
    }
}