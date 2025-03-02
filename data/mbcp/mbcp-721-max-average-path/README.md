# mbcp721 -- Maximize average path in a square matrix

## Text

Write a function to find a path with the maximum average over all existing paths for the given square matrix of size n*n.

## Code

```csharp
public static double MaxAverageOfPath(int[,] cost, int N) 
{
    int[,] dp = new int[N + 1, N + 1];
    dp[0, 0] = cost[0, 0];
    for (int i = 1; i < N; i++) 
    {
        dp[i, 0] = dp[i - 1, 0] + cost[i, 0];
    }
    for (int j = 1; j < N; j++) 
    {
        dp[0, j] = dp[0, j - 1] + cost[0, j];
    }
    for (int i = 1; i < N; i++) 
    {
        for (int j = 1; j < N; j++) 
        {
            dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]) + cost[i, j];
        }
    }
    return (double)dp[N - 1, N - 1] / (2 * N - 1);
}
```

## Test List

```csharp
Debug.Assert(MaxAverageOfPath(new int[][] { new int[] { 1, 2, 3 }, new int[] { 6, 5, 4 }, new int[] { 7, 3, 9 } }, 3) == 5.2);
```

```csharp
Debug.Assert(MaxAverageOfPath(new int[][] { new int[] { 2, 3, 4 }, new int[] { 7, 6, 5 }, new int[] { 8, 4, 10 } }, 3) == 6.2);
```

```csharp
Debug.Assert(MaxAverageOfPath(new int[][] { new int[] { 3, 4, 5 }, new int[] { 8, 7, 6 }, new int[] { 9, 5, 11 } }, 3) == 7.2);
```
