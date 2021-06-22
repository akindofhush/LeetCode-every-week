public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] dp = new int[nums.Length];
        Array.Fill(dp,1);
        for(int i = 0; i < nums.Length;i++){
            for(int j = 0; j < i; j++){
                if(nums[i] > nums[j]){
                    dp[i] = Math.Max(dp[i],dp[j]+1);
                }
            }
        }
        var result = 0;
        for(int i = 0; i < nums.Length; i++){
            result = Math.Max(result, dp[i]);
        }
        return result;
    }
}
