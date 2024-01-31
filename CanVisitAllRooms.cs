


 // O(n) Computational Complexity
// 1/31/24


public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        bool[] visitedRooms = new bool[rooms.Count];
        if(rooms[0].Count == 0){ return false; }
        
        visitedRooms[0] = true;
        SearchForKeysFromRoom(visitedRooms, rooms, 0);

        return !visitedRooms.Contains(false);
    }
    
    public void SearchForKeysFromRoom(bool[] visited, IList<IList<int>> rooms, int room)
    {
        for(int i = 0; i < rooms[room].Count; i++)
        {
            if(visited[rooms[room][i]] == false)
            {
                visited[rooms[room][i]] = true;
                SearchForKeysFromRoom(visited, rooms, rooms[room][i]);
            }
        }
    }
}