
 // O(n^2) Computational Complexity
// 2/6/24

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> rightMoving = new Stack<int>();
        Stack<int> leftMoving = new Stack<int>();
        Stack<int> finalStack = new Stack<int>();

        for(int i = 0; i < asteroids.Length; i++)
        {
            if(asteroids[i] < 0)
            {
                // asteroids[i] Moving left
                while(rightMoving.Count > 0 && Math.Abs(asteroids[i]) > Math.Abs(rightMoving.Peek()))
                {
                    // left destroys right
                    rightMoving.Pop();
                }

                if(rightMoving.Count == 0)
                {
                    finalStack.Push(asteroids[i]);
                }
                else if(Math.Abs(asteroids[i]) == Math.Abs(rightMoving.Peek()))
                {
                    // both explode
                    rightMoving.Pop();
                }
            }
            else
            {
                // asteroids[i] moving right
                rightMoving.Push(asteroids[i]);
            }
        }

        // Intermediate storage to reverse the order
        Stack<int> tempStack = new Stack<int>();
        while (rightMoving.Count > 0)
        {
            tempStack.Push(rightMoving.Pop());
        }

        while(tempStack.Count > 0)
        {
            finalStack.Push(tempStack.Pop());
        }

        // Initialize an array of the same size as the stack
        int[] remaining = new int[finalStack.Count];
        
        // Pop elements from the stack and store them into the array
        for (int i = remaining.Length - 1; i >= 0; i--)
        {
            remaining[i] = finalStack.Pop();
        }

        return remaining;
    }
}
