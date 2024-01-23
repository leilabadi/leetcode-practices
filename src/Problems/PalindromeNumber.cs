namespace LeetcodePractices.Problems
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            string str = x.ToString();

            int middle = str.Length / 2;
            int last = str.Length - 1;

            for (int i = 0; i <= middle; i++)
            {
                if (str[i] != str[last - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}