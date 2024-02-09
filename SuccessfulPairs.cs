

 // O(nlogn) Computational Complexity
// 2/9/24

public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        int[] successful = new int[spells.Length];
        Array.Sort(potions); // Sort the potions to allow for binary search

        for(int i = 0; i < spells.Length; i++) {
            // Ensure the result is rounded up by adding spells[i] - 1 before division
            long minPot = (success + spells[i] - 1) / spells[i];
            int minPotionIndex = FindMinPotion(minPot, potions, 0, potions.Length - 1);
            successful[i] = potions.Length - minPotionIndex;
        }

        return successful;
    }

    public int FindMinPotion(long minPot, int[] potions, int start, int end) {
        if (start > end) {
            return start; // Return start as the insertion point
        }

        int mid = start + (end - start) / 2;

        if (minPot <= potions[mid]) {
            // If minPot is less than or equal to mid potion, search in the left half including mid
            return FindMinPotion(minPot, potions, start, mid - 1);
        } else {
            // If minPot is greater, search in the right half excluding mid
            return FindMinPotion(minPot, potions, mid + 1, end);
        }
    }
}
