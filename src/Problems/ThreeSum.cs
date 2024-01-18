namespace LeetcodePractices.Problems;

public class ThreeSum
{
    public IList<IList<int>> Solution1(int[] nums)
    {
        Dictionary<int, int> dic = new();
        for (int i = 0; i < nums.Length; i++)
        {
            dic[nums[i]] = i;
        }

        List<int> visited = new();
        IList<IList<int>> results = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int complement = -(nums[i] + nums[j]);
                if (dic.ContainsKey(complement))
                {
                    if (i == dic[complement] || j == dic[complement]) continue;
                    int hash = GenerateHash(nums, i, j, dic[complement]);
                    Console.WriteLine($"hash: {hash}");
                    if (!visited.Contains(hash))
                    {
                        visited.Add(hash);
                        results.Add([nums[i], nums[j], complement]);
                        Console.WriteLine($"{nums[i]}, {nums[j]}, {complement}");
                    }
                }
            }
        }

        return results;
    }

    public IList<IList<int>> Solution2(int[] nums)
    {
        List<int> visited = new();
        IList<IList<int>> results = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        int hash = GenerateHash(nums, i, j, k);
                        if (!visited.Contains(hash))
                        {
                            visited.Add(hash);
                            results.Add([nums[i], nums[j], nums[k]]);
                        }
                    }
                }
            }
        }

        return results;
    }

    private int GenerateHash(int[] nums, int i, int j, int k)
    {
        return (int)(nums[i] * Math.Pow(2, i) + nums[j] * Math.Pow(2, j) + nums[k] * Math.Pow(2, k));
    }
}