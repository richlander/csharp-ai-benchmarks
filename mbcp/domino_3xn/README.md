# 5 -- Count tiling ways for a 3xn board.

domino_3xn

## Prompt

Write a function to find the number of ways to fill it with 2 x 1 dominoes for the given 3 x n board.

## Solution

```csharp
using System;
using System.Diagnostics;

int CountWays(int n)
{
    int[] A = new int[n + 1];
    int[] B = new int[n + 1];
    A[0] = 1;
    if(n >= 1)
    {
        A[1] = 0;
    }
    B[0] = 0;
    if(n >= 1)
    {
        B[1] = 1;
    }
    for (int i = 2; i <= n; i++)
    {
        A[i] = A[i - 2] + 2 * B[i - 1];
        B[i] = A[i - 1] + B[i - 2];
    }
    return A[n];
}
```

## Tests

```csharp
Debug.Assert(CountWays(2) == 3);
```

```csharp
Debug.Assert(CountWays(8) == 153);
```

```csharp
Debug.Assert(CountWays(12) == 2131);
```
