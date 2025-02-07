public class Solution {
    public int Rob(int[] nums)
    {
        if(nums.Length == 0)
            return 0;
        var dp = new int[nums.Length + 1];
        dp[1] = nums[0];
        for(int i = 2; i <= nums.Length; i++){
            dp[i] = Math.Max(dp[i-1], dp[i - 2] + nums[i-1]);
        }
        return dp[nums.Length];
    }
}
