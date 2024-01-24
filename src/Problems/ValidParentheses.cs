namespace LeetcodePractices.Problems
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var parenthesisCount = 0;
            var squareBracketCount = 0;
            var curlyBracketCount = 0;
            Stack<char> stack = new();

            foreach (char ch in s)
            {
                switch (ch)
                {
                    case '(':
                        stack.Push(ch);
                        parenthesisCount++;
                        break;
                    case '[':
                        stack.Push(ch);
                        squareBracketCount++;
                        break;
                    case '{':
                        stack.Push(ch);
                        curlyBracketCount++;
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(') return false;
                        if (--parenthesisCount < 0) return false;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[') return false;
                        if (--squareBracketCount < 0) return false;
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{') return false;
                        if (--curlyBracketCount < 0) return false;
                        break;
                    default:
                        return false;
                }
            }

            return stack.Count == 0 && parenthesisCount == 0 && squareBracketCount == 0 && curlyBracketCount == 0;
        }
    }
}