namespace LeetcodePractices.Problems;

public class ThreeSumOptimized
{
    // This solution is O(N^2)?
    public IList<IList<int>> Solution(int[] nums)
    {
        List<IList<int>> allResults = [];

        if (nums.Length <= 2) return allResults;

        Array.Sort(nums);

        int start = 0;
        // Choose the first number from the sorted array in a loop and then find the other two numbers in the right side of the array
        while (start < nums.Length - 2)
        {
            // Choose the most left and most right numbers from the rest of the array
            int left = start + 1;
            int right = nums.Length - 1;

            // Try to find the other two numbers to sum up to 0
            while (left < right)
            {
                int sum = nums[start] + nums[left] + nums[right];

                // Because the array is sorted, if sum is less than 0, we need to increase the left pointer
                if (sum < 0)
                {
                    left++;
                }
                // Because the array is sorted, if sum is greater than 0, we need to decrease the right pointer
                else if (sum > 0)
                {
                    right--;
                }
                // If sum is 0, we found a triplet
                else
                {
                    int[] result = [nums[start], nums[left], nums[right]];
                    allResults.Add(result);

                    // Skip duplicates for left because we already found a triplet for this number
                    while (left < right && nums[left] == result[1])
                    {
                        left++;
                    }
                    // Skip duplicates for right because we already found a triplet for this number
                    while (left < right && nums[right] == result[2])
                    {
                        right--;
                    }
                }
            }

            int currect = nums[start];
            // Skip duplicates for start because we already found all the triplets for this number
            while (start < nums.Length - 2 && nums[start] == currect)
            {
                start++;
            }
        }
        return allResults;
    }
}