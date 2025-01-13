public class Solution {
    public  IList<int> SpiralOrder(int[][] matrix)
{
    int n = matrix.Length;
    int m = matrix[0].Length;
    int left = 0, right = m - 1;
    int top = 0, bottom = n - 1;
    List<int> result = new List<int>();

    while (left <= right && top <= bottom)
    {
        for (int i  = left; i <= right; i++)
        {
            result.Add(matrix[top][i]);
        }
        top++;
        for (int i = top; i <= bottom; i++)
        {
            result.Add(matrix[i][right]);
        }
        right--;
        if (top <= bottom)
        {
            for (int i = right; i >= left; i--)
            {
                result.Add(matrix[bottom][i]);
            }
        bottom--;
        }
        if (left <= right)
        {
            for (int i = bottom; i >= top; i--)
            {
                result.Add(matrix[i][left]);
            }
            left++;
        }
    }
    return result;

}
}