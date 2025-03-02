# mbcp416 -- Maximize sum by recursively dividing a number

## Text

Write a function to find the maximum sum we can make by dividing number in three parts recursively and summing them up together for the given number.

## Code

```csharp
const int MAX = 1000000;

public int BreakSum(int n) 
{ 
    int[] dp = new int[n + 1]; 
    dp[0] = 0;
    dp[1] = 1;
    
    for (int i = 2; i <= n; i++) 
    { 
        dp[i] = Math.Max(dp[i / 2] + dp[i / 3] + dp[i / 4], i); 
    } 
    
    return dp[n];
}
```

## Test List

```csharp
Debug.Assert(BreakSum(12) == 13);
```

```csharp
Debug.Assert(BreakSum(24) == 27);
```

```csharp
Debug.Assert(BreakSum(23) == 23);
```
