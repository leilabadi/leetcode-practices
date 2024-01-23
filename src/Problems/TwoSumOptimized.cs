namespace LeetcodePractices.Problems;

public class TwoSumOptimized
{
    // This solution is O(N)
    public int[] Solution(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (dic.ContainsKey(complement))
            {
                return [i, dic[complement]];
            }
            else
            {
                dic[nums[i]] = i;
            }
        }

        return null;
    }
}