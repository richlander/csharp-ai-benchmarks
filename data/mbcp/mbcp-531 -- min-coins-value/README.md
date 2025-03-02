# mbcp-531 -- Find the least coins for a specific value

## Text

Write a function to find minimum number of coins that make a given value.

## Code

```csharp
using System;

class CoinChanger
{
    public static int MinCoins(int[] coins, int m, int V)
    {
        if (V == 0)
        {
            return 0;
        }
        int res = int.MaxValue;
        for (int i = 0; i < m; i++)
        {
            if (coins[i] <= V)
            {
                int sub_res = MinCoins(coins, m, V - coins[i]);
                if (sub_res != int.MaxValue && sub_res + 1 < res)
                {
                    res = sub_res + 1;
                }
            }
        }
        return res;
    }
}
```

## Test List

```csharp
Debug.Assert(MinCoins(new int[] { 9, 6, 5, 1 }, 4, 11) == 2);
```

```csharp
Debug.Assert(MinCoins(new int[] { 4, 5, 6, 7, 8, 9 }, 6, 9) == 1);
```

```csharp
Debug.Assert(MinCoins(new int[] { 1, 2, 3 }, 3, 4) == 2);
```
