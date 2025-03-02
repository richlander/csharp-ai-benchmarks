# mbcp-912 -- Find the m lobb number using a function

## Text

Write a function to find ln, m lobb number.

## Code

```csharp
public static int BinomialCoeff(int n, int k) {
    int[][] C = new int[n + 1][];
    for (int i = 0; i <= n; i++) {
        C[i] = new int[k + 1];
    }
    for (int i = 0; i <= n; i++) {
        for (int j = 0; j <= Math.Min(i, k); j++) {
            if (j == 0 || j == i) {
                C[i][j] = 1;
            } else {
                C[i][j] = C[i - 1][j - 1] + C[i - 1][j];
            }
        }
    }
    return C[n][k];
}

public static double LobbNum(int n, int m) {
    return ((2 * m + 1) * BinomialCoeff(2 * n, m + n)) / (double)(m + n + 1);
}
```

## Test List

```csharp
Debug.Assert(int(LobbNum(5, 3)) == 35);
```

```csharp
Debug.Assert((int)LobbNum(3, 2) == 5);
```

```csharp
Debug.Assert(Convert.ToInt32(LobbNum(4, 2)) == 20);
```
