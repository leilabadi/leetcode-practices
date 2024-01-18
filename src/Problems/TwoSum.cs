namespace LeetcodePractices.Problems;

public class TwoSum
{
    public int[] Solution1(int[] nums, int target)
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

    public int[] Solution2(int[] nums, int target)
    {
        var numMap = new Dictionary<int, int>();
        var result = new int[2];

        for (var i = 0; i < nums.Length; i++)
        {
            var rightNum = target - nums[i];
            if (!numMap.ContainsKey(rightNum))
            {
                numMap[nums[i]] = i;
            }
            else
            {
                result[0] = numMap[rightNum];
                result[1] = i;
                return result;
            }
        }

        return result;
    }
}