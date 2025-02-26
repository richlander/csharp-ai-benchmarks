# 1 -- Find minimum cost path in a cost matrix

min_cost_path

## Prompt

Write a function to find the minimum cost path to reach (m, n) from (0, 0) for the given cost matrix cost[][] and a position (m, n) in cost[][].

## Solution

```csharp
using System;
using System.Diagnostics;

int MinCost(int[,] cost, int m, int n)
{
    int R = cost.GetLength(0);
    int C = cost.GetLength(1);
    int[,] tc = new int[R, C];
    tc[0, 0] = cost[0, 0];
    for (int i = 1; i <= m; i++)
    {
        tc[i, 0] = tc[i - 1, 0] + cost[i, 0];
    }
    for (int j = 1; j <= n; j++)
    {
        tc[0, j] = tc[0, j - 1] + cost[0, j];
    }
    for (int i = 1; i <= m; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            tc[i, j] = Math.Min(tc[i - 1, j - 1], Math.Min(tc[i - 1, j], tc[i, j - 1])) + cost[i, j];
        }
    }
    return tc[m, n];
}
```

## Tests

```csharp
int[,] cost1 = new int[,] { { 1, 2, 3 }, { 4, 8, 2 }, { 1, 5, 3 } };
Debug.Assert(MinCost(cost1, 2, 2) == 8);
```

```csharp
int[,] cost2 = new int[,] { { 2, 3, 4 }, { 5, 9, 3 }, { 2, 6, 4 } };
Debug.Assert(MinCost(cost2, 2, 2) == 12);
```

```csharp
int[,] cost3 = new int[,] { { 3, 4, 5 }, { 6, 10, 4 }, { 3, 7, 5 } };
Debug.Assert(MinCost(cost3, 2, 2) == 16);
```
