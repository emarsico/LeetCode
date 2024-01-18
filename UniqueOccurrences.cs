

 // O(n^2) Computational Complexity
// 1/18/24


// Note*: This can be done in O(n) by counting all of the frequencies FIRST, then checking for duplicates

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var uniqueNums = arr.ToHashSet();
        var numFrequencies = new HashSet<int>();

        foreach (int num in uniqueNums)
        {
            // This lambda expression can count the number of 'num' in arr
            int count = arr.Count(element  => element  == num);
            if(numFrequencies.Contains(count))
            {
                return false;
            }

            numFrequencies.Add(count);
        }


        return true;
    }
}