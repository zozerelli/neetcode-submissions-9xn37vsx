public class Solution {
    public int[] CountBits(int n) {
        int[] dp = new int[n+1];
int offset = 1;
dp[0]=0;
for (int i = 1; i<=n; i++)
{
    if (2*offset==i)
    {
        offset =2*offset;
        dp[i]=1;
    }
    else {
        dp[i]=1+dp[i-offset];
    }
        
}
return dp;
    }
}
