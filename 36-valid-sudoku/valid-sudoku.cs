public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var sets = new HashSet<char>[27];
        for(var i = 0; i < 27; i ++) {
            sets[i] = new HashSet<char>();
        }
        var box = 0;
        for(int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                var current = board[i][j];
                if(current == '.') continue;
                box = 3*(i/3) + j/3;
                if (
                    !sets[i].Add(current)
                    || !sets[9 + j].Add(current)
                    || !sets[18 + box].Add(current)
                ) return false;
            }
        }
        return true;
    }
}