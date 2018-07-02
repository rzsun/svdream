// https://leetcode.com/problems/unique-paths/

public class Solution {
    public int UniquePaths(int m, int n) {
        if (m <= 1 || n <= 1) {
            return 1;
        }
        
        int[,] uniquePaths = new int[m, n];
        
        for (int i = 0; i < m; i++) {
            uniquePaths[i, 0] = 1;
        }
        
        for (int i = 0; i < n; i++) {
            uniquePaths[0, i] = 1;
        }
        
        for (int x = 1; x < m; x++) {
            for (int y = 1; y < n; y++) {
                uniquePaths[x, y] = uniquePaths[x - 1, y] + uniquePaths[x, y - 1];
            }
        }
        
        return uniquePaths[m - 1, n - 1];
    }
}