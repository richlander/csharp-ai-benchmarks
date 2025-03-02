# mbcp469 -- Max profit from k stock transactions function

## Text

Write a function to find the maximum profit earned from a maximum of k stock transactions

## Code

```csharp
public int MaxProfit(int[] price, int k) {
    int n = price.Length;
    int[,] finalProfit = new int[k + 1, n];
    
    for (int i = 0; i <= k; i++) {
        for (int j = 0; j < n; j++) {
            if (i == 0 || j == 0) {
                finalProfit[i, j] = 0;
            } else {
                int maxSoFar = 0;
                for (int x = 0; x < j; x++) {
                    int currPrice = price[j] - price[x] + finalProfit[i - 1, x];
                    if (maxSoFar < currPrice) {
                        maxSoFar = currPrice;
                    }
                }
                finalProfit[i, j] = Math.Max(finalProfit[i, j - 1], maxSoFar);
            }
        }
    }
    return finalProfit[k, n - 1];
}
```

## Test List

```csharp
Debug.Assert(MaxProfit(new int[] { 1, 5, 2, 3, 7, 6, 4, 5 }, 3) == 10);
```

```csharp
Debug.Assert(MaxProfit(new int[] { 2, 4, 7, 5, 4, 3, 5 }, 2) == 7);
```

```csharp
Debug.Assert(MaxProfit(new int[] { 10, 6, 8, 4, 2 }, 2) == 2);
```
