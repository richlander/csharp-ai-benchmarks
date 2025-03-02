# mbcp752 -- Find the nth jacobsthal number in a sequence

## Text

Write a function to find the nth jacobsthal number.

## Code

```csharp
public int JacobsthalNum(int n) 
{ 
    int[] dp = new int[n + 1]; 
    dp[0] = 0; 
    dp[1] = 1; 
    for (int i = 2; i <= n; i++) 
    { 
        dp[i] = dp[i - 1] + 2 * dp[i - 2]; 
    } 
    return dp[n]; 
}
```

## Test List

```csharp
Debug.Assert(JacobsthalNum(5) == 11);
```

```csharp
Debug.Assert(JacobsthalNum(2) == 1);
```

```csharp
Debug.Assert(JacobsthalNum(4) == 5);
```
