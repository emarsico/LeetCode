

 // Top 95.67% Runtime
// 1/6/9

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        char[] w1 = word1.ToCharArray();
        char[] w2 = word2.ToCharArray();
        List<char> wordList = new List<char>();
        
        int i = 0, j = 0;
        while(i < (w1.Length) || j < (w2.Length))
        {
            if(i < (w1.Length))
            {
                wordList.Add(w1[i]);
                i++;
            }

            if(j < (w2.Length))
            {
                wordList.Add(w2[j]);
                j++;
            }
        }

        return new string(wordList.ToArray());
    }
}