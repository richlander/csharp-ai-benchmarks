# mbcp918 -- Count the number of ways to make coin change

## Text

Write a function to count coin change.

## Code

```csharp
public int CoinChange(int[] S, int m, int n) 
{
    int[,] table = new int[n + 1, m];
    for (int i = 0; i < m; i++) 
    {
        table[0, i] = 1;
    }
    for (int i = 1; i <= n; i++) 
    {
        for (int j = 0; j < m; j++) 
        {
            int x = (i - S[j] >= 0) ? table[i - S[j], j] : 0;
            int y = (j >= 1) ? table[i, j - 1] : 0;
            table[i, j] = x + y;
        }
    }
    return table[n, m - 1];
}
```

## Test List

```csharp
Debug.Assert(CoinChange(new int[] { 1, 2, 3 }, 3, 4) == 4);
```

```csharp
Debug.Assert(CoinChange(new int[] { 4, 5, 6, 7, 8, 9 }, 6, 9) == 2);
```

```csharp
Debug.Assert(CoinChange(new int[] { 4, 5, 6, 7, 8, 9 }, 6, 4) == 1);
```
