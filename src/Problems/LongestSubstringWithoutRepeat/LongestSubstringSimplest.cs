namespace LeetcodePractices.Problems.LongestSubstringWithoutRepeat;

public class LongestSubstringSimplest
{
    // This solution is O(N^2)
    public int Solution(string s)
    {
        if (s.Length <= 1) return s.Length;

        int left = 0;
        int maxLength = 1;
        for (int right = 0; right < s.Length; right++)
        {
            int j;
            for (j = left; j < right; j++)
            {
                if (s[j] == s[right])
                {
                    maxLength = Math.Max(maxLength, right - left);
                    left = j + 1;
                    break;
                }
            }
            if (j == right)
            {
                maxLength = Math.Max(maxLength, j - left + 1);
            }
        }

        return maxLength;
    }
}