

 // O(n) Computational Complexity
// 1/15/24

public class Solution {
   public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int i = 0;
        while(i < flowerbed.Length){
            if(flowerbed[i] == 0){
                if(i == 0 || flowerbed[i-1] == 0){
                    if(i==flowerbed.Length-1 || flowerbed[i+1]==0){
                        n--;
                        i++;    // This incrementing removes the need for modifying flowerbed.
                    }
                }
            }
            i++;
        }
        return n <=0;
    }
}



 // Top 36.39% Runtime
// 1/15/24


public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {

        if(flowerbed.Length == 1 && flowerbed[0] == 0 || flowerbed.Length == 2 && flowerbed[0] == 0 && flowerbed[1] == 0)
        { 
            n-= 1;
            return (n<=0);
        } // flowerbed => [0] or [0, 0]

        for(int i = 1; i < (flowerbed.Length - 1); i++)
        {
            if(i == 1 && flowerbed[i] == 0 && flowerbed[i-1] == 0) // Left end of list
            {
                flowerbed[i-1] = 1;
                n -= 1;
            }
            else if(flowerbed[i-1] == 0 && flowerbed[i] == 0 && flowerbed[i+1] == 0)
            {
                flowerbed[i] = 1;
                n -= 1;
            }
            else if(i+2 == flowerbed.Length && flowerbed[i] == 0 && flowerbed[i+1] == 0) // Right end of list
            {
                flowerbed[i+1] = 1;
                n -= 1;
            }
        }

        if(flowerbed[flowerbed.Length-1] == 0 && flowerbed[flowerbed.Length-2] == 0){ n-= 1;}

        return (n<=0);
    }
}