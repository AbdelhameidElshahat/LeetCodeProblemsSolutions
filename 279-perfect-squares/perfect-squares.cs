public class Solution {
    public int NumSquares(int n) {
        HashSet<int> squares = new HashSet<int>();
        for (int i = 1 ; i<= Math.Sqrt(n); i++){
            squares.Add(i * i);
        }

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(n);
        int level = 0 ;
        while(queue.Count>0){
            level++;
            int size = queue.Count;
            for(int i = 0 ; i<size ; i++){
                int remainder = queue.Dequeue();
                if(squares.Contains(remainder)){
                    return level;
                }

                foreach(int sqr in squares){
                    if(remainder > sqr){
                        queue.Enqueue(remainder - sqr);
                    }
                }
            }
        }
        return -1 ;
    }
}