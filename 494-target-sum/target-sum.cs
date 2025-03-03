public class Solution {
    Dictionary<(int,int) , int> cashe;
    public int FindTargetSumWays(int[] nums, int target) {
        cashe = new Dictionary<(int,int),int>();
         return dfs(nums , target , 0 , 0);
    }
    private int dfs (int[] nums , int target , int i , int sum){
        if(i == nums.Length) return sum == target ? 1 : 0 ;

        if(cashe.ContainsKey((i,sum))){
            return cashe[(i,sum)];
        }
        int add = dfs(nums , target  , i+1 , sum+nums[i]);
        int sub = dfs(nums , target , i+1  , sum-nums[i]);
        return add+sub;
    }
}