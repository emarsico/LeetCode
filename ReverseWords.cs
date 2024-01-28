

 // O(n) Computational Complexity
// 1/28/24

// Why is this a medium?

public class Solution {
    public string ReverseWords(string s) {
        string[] onlyWords = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string result = "";

        for(int i = onlyWords.Length-1; i > 0; i--)
        {
            result += onlyWords[i] + " ";
        }

        if(onlyWords.Length > 0)
        {
            result += onlyWords[0];
        }

        return result;

        // This can also be solved in one line
        // return string.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries |       StringSplitOptions.TrimEntries).Reverse());

    }
}