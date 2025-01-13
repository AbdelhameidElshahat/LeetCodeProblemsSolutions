public class Solution {
   public  int[] FindDiagonalOrder(int[][] matrix)
{
    if (matrix.Length == 0 || matrix[0].Length == 0) return new int[0];

    int m = matrix.Length; // Number of rows
    int n = matrix[0].Length; // Number of columns
    int[] result = new int[m * n];
    int index = 0;
    int row = 0, col = 0;
    bool up = true;

    while (row < m && col < n)
    {
        if (up)
        {
            while (row > 0 && col < n - 1)
            {
                result[index++] = matrix[row][col];
                row--;
                col++;
            }
            result[index++] = matrix[row][col];
            if (col == n - 1)
            {
                row++; // Move to the next row
            }
            else
            {
                col++; // Move to the next column
            }
        }
        // If moving downwards
        else
        {
            while (col > 0 && row < m - 1)
            {
                result[index++] = matrix[row][col];
                row++;
                col--;
            }
            result[index++] = matrix[row][col];
            if (row == m - 1) 
            {
                col++; // Move to the next column
            }
            else
            {
                row++; // Move to the next row
            }
        }
        // **Switch direction after each diagonal traversal**
        up = !up; // **Added: Toggle direction**
    }

    return result;
}
}