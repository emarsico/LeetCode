
 // O(n) Computational Complexity
// 1/19/24

public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s == "")
        {
            return true;
        }
        else if(t == "" && !(s == ""))
        {
            return false;
        }

        Char[] subseq = s.ToArray();
        Char[] parent = t.ToArray();

        if(subseq.Length > parent.Length)
        {
            return false;
        }

        int subIndex = 0;
        for(int i = 0; i < parent.Length; i++)
        {
            if((subIndex < subseq.Length) && parent[i] == subseq[subIndex])
            {
                subIndex++;
            }
        }

        return (subIndex == (subseq.Length));
    }
}

/*
ahbgdc
abc

s =
"b"
t =
"abc"

*/
