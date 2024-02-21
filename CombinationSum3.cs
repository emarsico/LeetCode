

 // REVISIT //
 // O(3^k) Computational Complexity
// 2/21/24


public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        IList<IList<int>> solutions = new List<IList<int>>();
        IList<int> currentCombination = new List<int>();

        void Backtrack(int start, int remainingSum, int remainingNumbers) {
            // If the remaining sum is 0 and we have chosen k numbers, add the current combination to solutions
            if (remainingSum == 0 && remainingNumbers == 0) {
                solutions.Add(new List<int>(currentCombination));
                return;
            }

            // If no more numbers are remaining to be chosen, return
            if (remainingNumbers == 0) {
                return;
            }

            for (int i = start; i <= 9; i++) {
                // If adding the current number would exceed the remaining sum, break the loop to avoid unnecessary checks
                if (i > remainingSum) {
                    break;
                }

                currentCombination.Add(i);
                Backtrack(i + 1, remainingSum - i, remainingNumbers - 1);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }

        Backtrack(1, n, k);

        return solutions;
    }
}
