public class Solution {
    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter) {
        
        //2d array directions
        int[][] dirs = new int[][] {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };
        
        //result array
        int[][] res = new int[rows * cols][];

        //make 2d array (cannot set second array size in array init)
        for (int i = 0; i < res.Length; i++)
        {
            res[i] = new int[2];
        }
        
        var index = 0;
        
        HashSet<string> set = new HashSet<string>();
        
        //add center coords
        set.Add(rCenter + "/" + cCenter);

        var q = new Queue<int[]>();
        
        //queue center coords
        q.Enqueue(new int[] {rCenter, cCenter});
        
        //BFS algorithm
        /*  For each direction (up, down, left, right) defined in dirs, 
            the loop calculates the adjacent cell's coordinates(rr,cc).
            If the adjacent cell is within the bounds of the grid 
            (not less than 0 and not exceeding rows and cols) 
            and has not been visited before (set.Add(rr + "/" + cc) returns true), 
            it is added to the queue and the set for future processing.
        */

        while (q.Count() != 0) {
            int[] cur = q.Dequeue();
            res[index++] = cur;
            
            foreach (int[] dir in dirs) {
                int rr = cur[0] + dir[0];
                int cc = cur[1] + dir[1];
                if (rr < 0 || rr >= rows || cc < 0 || cc >= cols) continue;
                if (set.Add(rr + "/" + cc)) q.Enqueue(new int[]{rr, cc});
            }
        }
        return res;
    }
}