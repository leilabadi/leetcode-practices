namespace LeetcodePractices.Problems.LongestSubstringWithoutRepeat;

public class LongestSubstringOptimized
{
    // This solution is O(N)
    public int Solution(string s)
    {
        int left = 0;
        int maxLength = 0;
        Dictionary<char, int> dic = [];

        // Loop through the string to find the longest substring
        for (int right = 0; right < s.Length; right++)
        {
            var rightChar = s[right];

            // If the character is not in the dictionary or the character is in the dictionary but the index is less than the left index
            if (!dic.ContainsKey(rightChar) || dic[rightChar] < left)
            {
                // Add the character to the dictionary
                dic[rightChar] = right;
                // Update the maxLength to the current length
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            // If the character is in the dictionary and the index is greater than the left index
            else
            {
                // Update the left index to invalidate any characters that appear before and including the duplicate character at left
                left = dic[rightChar] + 1;
                // Update the character in the dictionary to the current index
                dic[rightChar] = right;
            }
        }

        return maxLength;
    }
}