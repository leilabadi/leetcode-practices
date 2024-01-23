namespace LeetcodePractices.Problems
{
    public class PalindromeNumberMoreOptimized
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;

            int num = x;
            int reversed = 0;
            while (num > reversed)
            {
                reversed = 10 * reversed + (num % 10);
                num /= 10;
            }

            return (num == reversed || num == reversed / 10);
        }
    }
}