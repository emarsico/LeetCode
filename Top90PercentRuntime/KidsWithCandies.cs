

 // Top 99.29% Runtime
// 1/9/24

public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> greatestAfterExtraCandies = new List<bool>(candies.Length);
        IList<int> candiesWithExtra = new List<int>(candies.Length);

        for(int i = 0; i < candies.Length; i++)
        {
            candiesWithExtra.Add(candies[i] + extraCandies);
            greatestAfterExtraCandies.Add(true);
        }
        
        for(int i = 0; i < candies.Length; i++)
        {
            int boosted = candiesWithExtra[i];
            for(int j = 0; j < candies.Length; j++)
            {
                if(boosted < candies[j])
                {
                    greatestAfterExtraCandies[i] = false;
                }
            }
        }

        return greatestAfterExtraCandies;
    }
}