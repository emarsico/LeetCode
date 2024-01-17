

 // O(n) Computational Complexity
// 1/17/24


public class Solution {
    public string ReverseVowels(string s) {
        List<int> vowelPositions = new List<int>();
        List<char> vowels = new List<char>();

        // Fill the lists of vowels and positions
        for(int i = 0; i < s.Length; i++)
        {
            if ("aeiouAEIOU".IndexOf(s[i]) >= 0)
            {
                vowelPositions.Add(i);
                vowels.Add(s[i]);
            }
        }

        // Reverse the vowels
        while(vowels.Count > 0)
        {
            s = s.Substring(0, vowelPositions[0]) + vowels[vowels.Count - 1] + s.Substring(vowelPositions[0] + 1, s.Length - vowelPositions[0] - 1);

            vowelPositions.RemoveAt(0);
            vowels.RemoveAt(vowels.Count - 1);
        }

        return s;
    }
}


/*
POPULATION

OUAIO


10
3


*/