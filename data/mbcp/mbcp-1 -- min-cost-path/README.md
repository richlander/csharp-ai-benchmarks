# mbcp-1 -- Find minimum cost path in a cost matrix

## Text

Write a function to find the minimum cost path to reach (m, n) from (0, 0) for the given cost matrix cost[][] and a position (m, n) in cost[][].

## Code

```csharp
R = 3;
C = 3;

public int MinCost(int[][] cost, int m, int n) 
{
    int[][] tc = new int[R][];
    for (int x = 0; x < R; x++)
    {
        tc[x] = new int[C];
    }
    
    tc[0][0] = cost[0][0];
    
    for (int i = 1; i <= m; i++) 
    {
        tc[i][0] = tc[i - 1][0] + cost[i][0];
    }
    
    for (int j = 1; j <= n; j++) 
    {
        tc[0][j] = tc[0][j - 1] + cost[0][j];
    }
    
    for (int i = 1; i <= m; i++) 
    {
        for (int j = 1; j <= n; j++) 
        {
            tc[i][j] = Math.Min(Math.Min(tc[i - 1][j - 1], tc[i - 1][j]), tc[i][j - 1]) + cost[i][j];
        }
    }
    
    return tc[m][n];
}
```

## Test List

```csharp
Debug.Assert(MinCost(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 8, 2 }, new int[] { 1, 5, 3 } }, 2, 2) == 8);
```

```csharp
Debug.Assert(MinCost(new int[][] { new int[] { 2, 3, 4 }, new int[] { 5, 9, 3 }, new int[] { 2, 6, 4 } }, 2, 2) == 12);
```

```csharp
Debug.Assert(MinCost(new int[][] { new int[] { 3, 4, 5 }, new int[] { 6, 10, 4 }, new int[] { 3, 7, 5 } }, 2, 2) == 16);
```
