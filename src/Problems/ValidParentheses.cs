namespace LeetcodePractices.Problems
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new();

            foreach (char ch in s)
            {
                switch (ch)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    default:
                        if (stack.Count == 0 || stack.Pop() != ch) return false;
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}