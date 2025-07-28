public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var m = matrix.Length;
        var n = matrix[0].Length;
        int minNum = 0;
        int maxNum = n*m - 1;
        int row;
        int col;
        int mid;

        while (minNum <= maxNum) {
            mid = (minNum + maxNum) / 2;
            row = mid/n;
            col = mid%n;
            if (target == matrix[row][col]) {
                return true;
            } else if (target < matrix[row][col]) {
                 maxNum = mid - 1;
              }else {
                minNum = mid + 1;
            }
        }
        return false;
    }

}