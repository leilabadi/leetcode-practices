namespace LeetcodePractices.Problems.TwoSum;

public class TwoSumSimplest
{
    // This solution is O(N)
    public int[] Solution(int[] nums, int target)
    {
        Dictionary<int, List<int>> dic = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                dic[nums[i]].Add(i);
            }
            else
            {
                dic.Add(nums[i], new List<int>([i]));
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (dic.ContainsKey(diff))
            {
                var list = dic[diff];
                if (nums[i] == diff)
                {
                    if (list.Count == 2)
                    {
                        return [list[0], list[1]];
                    }
                    continue;
                }
                return [i, list[0]];
            }
        }
        return Array.Empty<int>();
    }
}