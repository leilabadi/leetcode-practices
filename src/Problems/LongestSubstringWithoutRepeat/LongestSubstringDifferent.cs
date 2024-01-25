namespace LeetcodePractices.Problems.LongestSubstringWithoutRepeat;

public class LongestSubstringDifferent
{
    // This solution is O(N)
    public int Solution(string s)
    {
        int left = 0;
        int maxLength = 0;
        int[] map = new int[128];

        // Initialize all indexes with -1
        Array.Fill(map, -1);

        // Loop through the string to find the longest substring
        for (int right = 0; right < s.Length; right++)
        {
            var rightChar = s[right];

            // If the character is not in our map
            if (map[rightChar] < left)
            {
                // Add the character to the map
                map[rightChar] = right;
                // Update the maxLength to the current length
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            // If the character is in the map
            else
            {
                // Update the left index to invalidate any characters that appear before and including the duplicate character at left
                left = map[rightChar] + 1;
                // Update the character in the map to the current index
                map[rightChar] = right;
            }
        }

        return maxLength;
    }
}