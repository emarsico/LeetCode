

 // O(n) Computational Complexity
// 1/26/24


public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new Stack<char>();
        string modified = "";

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '*')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }

        while(stack.Count > 0)
        {
            modified = stack.Pop() + modified;
        }

        return modified;
    }
}


 // Bad Computational Complexity

public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new Stack<char>();
        string modified = "";

        for(int i = 0; i < s.Length; i++)
        {
            stack.Push(s[i]);
        }

        while(stack.Count > 0)
        {
            char top = stack.Pop();
            if(top == '*')
            {
                int numStarsPopped = 0;
                char next;
                // remove the next non * char
                do
                {
                    next = stack.Pop();
                    if(next == '*')
                    {
                        numStarsPopped += 1;
                    }
                }while(next == '*');
                
                // re-add the additional *s
                for(int i = 0; i < numStarsPopped; i++)
                {
                    stack.Push('*');
                }
            }
            else
            {
                modified += top;
            }
        }

        return new string(modified.Reverse().ToArray());
    }
}