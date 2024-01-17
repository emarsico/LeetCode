/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */


/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */


 // O(n) Computational Complexity (Top 100% Runtime)
// 1/13/24

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int high = n;
        int low = 1;
        int mid = low + (high - low) / 2;
        int response = guess(mid);

        while(response != 0)
        {
            if(response == -1)  // Too high
            {
                high = (mid - 1);
            }
            else    // Too low
            {
                low = (mid + 1);
            }
            mid = low + (high - low) / 2;
            response = guess(mid);
        }

        return (mid);
    }
}


/*

 // Top 71.09% Runtime
// 1/12/24


public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int numGuess = ((n+1)/2);

        return RecursiveGuessNumber(1, n, numGuess);
    }

    private int RecursiveGuessNumber(int low, int high, int oldGuess)
    {
        int response = guess(oldGuess);
        if(response == 0)
        {
            return oldGuess;
        }
        else if(response == -1) // num is too high
        {
            int mid = low + (high - low) / 2;
            return RecursiveGuessNumber(low, oldGuess - 1, mid);
        }
        else if(response == 1) // num is too low
        {
            int mid = low + (high - low) / 2;
            return RecursiveGuessNumber(oldGuess + 1, high, mid);
        }

        return -1;
    }

}


n = 8, ans = 3

1, 8, 4
    res = -1, mid = (1 + (4 - 1)) / 2 = 2, low = 1, high = 7

1, 3, 2
    res = 1, mid = (1 + (7 - 1)) / 2 = 3, low = 2, high = 7

Correct


*/