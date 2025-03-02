# mbcp-971 -- Maximize segments from given lengths using n

## Text

Write a function to find the maximum number of segments of lengths a, b and c that can be formed from n.

## Code

```csharp
public int MaximumSegments(int n, int a, int b, int c) 
{
    int[] dp = new int[n + 10];
    for (int i = 0; i < dp.Length; i++) 
    {
        dp[i] = -1;
    }
    dp[0] = 0;

    for (int i = 0; i < n; i++) 
    {
        if (dp[i] != -1) 
        {
            if (i + a <= n) 
            {
                dp[i + a] = Math.Max(dp[i] + 1, dp[i + a]);
            }
            if (i + b <= n) 
            {
                dp[i + b] = Math.Max(dp[i] + 1, dp[i + b]);
            }
            if (i + c <= n) 
            {
                dp[i + c] = Math.Max(dp[i] + 1, dp[i + c]);
            }
        }
    }
    return dp[n];
}
```

## Test List

```csharp
Debug.Assert(MaximumSegments(7, 5, 2, 5) == 2);
```

```csharp
Debug.Assert(MaximumSegments(17, 2, 1, 3) == 17);
```

```csharp
Debug.Assert(MaximumSegments(18, 16, 3, 6) == 6);
```
