


 // O(n) Computational Complexity
// 2/4/24

public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if(word1.Length != word2.Length) return false;

        // Create O(1) letter frequency arrays
        int[] frequency1 = new int[26];
        int[] frequency2 = new int[26];

        for(int index=0; index<word1.Length; index++){
            frequency1[word1[index] - 'a']++;   // Subtracting ASCII 'a' from the char will give us the index of the char in the frequency array
            frequency2[word2[index] - 'a']++;
        }

        // Make sure the same unique letters are used
        for(int index=0; index<26; index++){
            if(frequency1[index] == 0 && frequency2[index] != 0)
                return false;
            if(frequency1[index] != 0 && frequency2[index] == 0)
                return false;
        }

        Array.Sort(frequency1);
        Array.Sort(frequency2);

        return frequency1.SequenceEqual(frequency2);
    }
}




  // Bad Solution
 // O(n^2) Computational Complexity
// 2/4/24

public class Solution {
    public bool CloseStrings(string word1, string word2) {
        // Map the occurrences of each char in word 1
        Dictionary<char, int> occurrences1 = new Dictionary<char, int>();
        foreach (char ch in word1)
        {
            if (!occurrences1.ContainsKey(ch))
            {
                occurrences1[ch] = 1;
            }
            else
            {
                occurrences1[ch]++;
            }
        }

        // Map the occurrences of each char in word 2
        Dictionary<char, int> occurrences2 = new Dictionary<char, int>();
        foreach (char ch in word2)
        {
            if (!occurrences2.ContainsKey(ch))
            {
                occurrences2[ch] = 1;
            }
            else
            {
                occurrences2[ch]++;
            }
        }

        // Ensure both words have the same unique characters
        if (!occurrences1.Keys.OrderBy(k => k).SequenceEqual(occurrences2.Keys.OrderBy(k => k)))
            return false;

        // Compare the two dictionaries by occurrences to see if they are similar
        foreach (var charPair in occurrences1)
        {
            bool hasRemoved = false; 
            foreach (var charPair2 in occurrences2)
            {
                if(!hasRemoved && charPair.Value == charPair2.Value)
                {
                    occurrences2.Remove(charPair2.Key);
                    hasRemoved = true;
                }
            }
        }
        return (occurrences2.Count == 0);
    }
}