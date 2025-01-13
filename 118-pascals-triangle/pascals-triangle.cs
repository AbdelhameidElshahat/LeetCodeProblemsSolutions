public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> triangle = new List<IList<int>>();
        
        if (numRows == 0) return triangle;
        List<int> firstRow = new List<int> { 1 };
        triangle.Add(firstRow);
        
        for (int i = 1; i < numRows; i++) {
            List<int> previousRow = (List<int>)triangle[i - 1];
            
            List<int> row = new List<int>();
            
            row.Add(1);
            
            for (int j = 1; j < i; j++) {
                row.Add(previousRow[j - 1] + previousRow[j]);
            }
            
            row.Add(1);
            
            triangle.Add(row);
        }
        
        return triangle;
    }
}