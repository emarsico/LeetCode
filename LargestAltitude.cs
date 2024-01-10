

 // Top 87.75% Runtime
// 1/10/24

public class Solution {
    public int LargestAltitude(int[] gain) {
        int highestAltitude = 0;
        int newAlt = 0;

        for(int i = 0; i < gain.Length; i++)
        {
            newAlt = newAlt + gain[i];
            if(newAlt > highestAltitude)
            {
                highestAltitude = newAlt;
            }
        }

        return highestAltitude;
    }
}