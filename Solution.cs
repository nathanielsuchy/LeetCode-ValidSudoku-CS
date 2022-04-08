public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        var rows = new HashSet<string>();
        var cols = new HashSet<string>();
        var boxes = new HashSet<string>();
        
        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                if (board[r][c] == '.') {
                    continue;
                }
                
                if (rows.Contains($"{board[r][c]} found in row {r}")) {
                    return false;
                }                
                rows.Add($"{board[r][c]} found in row {r}");
                
                if (cols.Contains($"{board[r][c]} found in col {c}")) {
                    
                    return false;
                }
                cols.Add($"{board[r][c]} found in col {c}");
                
                
                if (boxes.Contains($"{board[r][c]} found in box {r/3} # {c/3}")) {
                    return false;
                }
                boxes.Add($"{board[r][c]} found in box {r/3} # {c/3}");
            }
        }
        return true;
    }
}
