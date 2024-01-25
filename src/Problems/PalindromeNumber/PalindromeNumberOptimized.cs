namespace LeetcodePractices.Problems.PalindromeNumber;

public class PalindromeNumberOptimized
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        int num = x;
        int reversed = 0;
        while (num > 0)
        {
            var (q, r) = Math.DivRem(num, 10);
            reversed = 10 * reversed + r;
            num = q;
        }

        return x == reversed;
    }
}