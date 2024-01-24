namespace LeetcodePractices.Problems
{
    public class LongestSubstringWithoutRepeat
    {
        // This solution is O(N^2)
        public int Solution(string s)
        {
            if (s.Length <= 1) return s.Length;

            int left = 0;
            int maxLength = 1;
            for (int i = 0; i < s.Length; i++)
            {
                int j;
                for (j = left; j < i; j++)
                {
                    if (s[j] == s[i])
                    {
                        int length = i - left;
                        if (length > maxLength)
                        {
                            maxLength = length;
                        }
                        left = j + 1;
                        break;
                    }
                }
                if (j == i)
                {
                    int length = j - left + 1;
                    if (length > maxLength)
                    {
                        maxLength = length;
                    }
                }
            }

            return maxLength;
        }
    }
}