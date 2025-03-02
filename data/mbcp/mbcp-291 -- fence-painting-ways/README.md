# mbcp-291 -- Count ways to paint a fence with constraints

## Text

Write a function to find out the number of ways of painting the fence such that at most 2 adjacent posts have the same color for the given fence with n posts and k colors.

## Code

```csharp
public static long CountNoOfWays(int n, int k) 
{ 
    long[] dp = new long[n + 1]; 
    long total = k; 
    long mod = 1000000007; 
    dp[1] = k; 
    dp[2] = k * k; 
    for (int i = 3; i <= n; i++) 
    { 
        dp[i] = ((k - 1) * (dp[i - 1] + dp[i - 2])) % mod; 
    } 
    return dp[n]; 
}
```

## Test List

```csharp
Debug.Assert(CountNoOfWays(2, 4) == 16);
```

```csharp
Debug.Assert(CountNoOfWays(3, 2) == 6);
```

```csharp
Debug.Assert(CountNoOfWays(4, 4) == 228);
```
