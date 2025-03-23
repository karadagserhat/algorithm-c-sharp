namespace Algorithm
{
    public class SolutionIsValid
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = [];

            foreach (char c in s)
            {
                if (c == '{' || c == '[' || c == '(') stack.Push(c);
                else
                {
                    if (stack.Count == 0) return false; // Kapanış var ama açılış yoksa geçersiz


                    char top = stack.Pop();

                    if ((c == '}' && top != '{') ||
                       (c == ']' && top != '[') ||
                       (c == ')' && top != '(')) return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
