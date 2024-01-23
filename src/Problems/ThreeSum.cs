namespace LeetcodePractices.Problems;

public class ThreeSum
{
    public IList<IList<int>> Solution(int[] nums)
    {
        Dictionary<int, int> dic = [];
        for (int i = 0; i < nums.Length; i++)
        {
            dic[nums[i]] = i;
        }

        Dictionary<(int, int, int), bool> visited = [];
        IList<IList<int>> results = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int complement = -(nums[i] + nums[j]);
                if (dic.ContainsKey(complement))
                {
                    if (i == dic[complement] || j == dic[complement]) continue;
                    var tuple = GetOrderedTuple(nums, i, j, dic[complement]);
                    if (!visited.ContainsKey(tuple))
                    {
                        visited[tuple] = true;
                        results.Add([nums[i], nums[j], complement]);
                    }
                }
            }
        }

        return results;
    }

    private (int, int, int) GetOrderedTuple(int[] nums, int i, int j, int k)
    {
        int[] subset = [nums[i], nums[j], nums[k]];
        int[] ordered = [.. subset.Order()];
        return (ordered[0], ordered[1], ordered[2]);
    }

}