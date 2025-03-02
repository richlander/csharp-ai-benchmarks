# mbcp529 -- Find the nth Jacobsthal-Lucas number

## Text

Write a function to find the nth jacobsthal-lucas number.

## Code

```csharp
public int JacobsthalLucas(int n) 
{ 
    int[] dp = new int[n + 1]; 
    dp[0] = 2; 
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
Debug.Assert(jacobsthalLucas(5) == 31);
```

```csharp
Debug.Assert(jacobsthalLucas(2) == 5);
```

```csharp
Debug.Assert(jacobsthalLucas(4) == 17);
```
