
 // O(n) Computational Complexity
// 1/21/24


// This was supposed to be a queue question using Enqueue and Dequeue

public class RecentCounter {
    List<int> counter;

    public RecentCounter() {
        counter = new List<int>();
    }
    
    public int Ping(int t) {
        counter.Add(t);

        while(counter[0] < (t-3000)){
            counter.RemoveAt(0);
        }

        return counter.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
