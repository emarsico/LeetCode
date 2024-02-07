


 // O(nlogn) Computational Complexity
// 2/7/24

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {

        // Sort the array by starting point
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        return RecursiveErase(intervals, intervals.Length - 1, 0, 0);
    }

    public int RecursiveErase(int[][] intervals, int backIndex, int skips, int total)
    {
        // Will allow us to peek one backwards
        if(backIndex > 0){
            if(intervals[backIndex-1][1] <= intervals[backIndex+skips][0])
            {
                // No erase needed
                return RecursiveErase(intervals, backIndex-1, 0, total);
            }
            else
            {
                int backEndPos = intervals[backIndex][0];
                int frontEndPos = intervals[backIndex-1][0];

                if(frontEndPos > backEndPos)
                {
                    return RecursiveErase(intervals, backIndex-1, 1, total+1);
                }
                else
                {
                    return RecursiveErase(intervals, backIndex-1, skips+1, total+1);
                }
            }
        }
        return total;
    }
}