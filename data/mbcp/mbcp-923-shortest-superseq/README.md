# mbcp923 -- Find shortest string containing two subsequences

## Text

Write a function to find the length of the shortest string that has both str1 and str2 as subsequences.

## Code

```csharp
int SuperSeq(string X, string Y, int m, int n) {
    if (m == 0) {
        return n;
    }
    if (n == 0) {
        return m;
    }
    if (X[m - 1] == Y[n - 1]) {
        return 1 + SuperSeq(X, Y, m - 1, n - 1);
    }
    return 1 + Math.Min(SuperSeq(X, Y, m - 1, n), SuperSeq(X, Y, m, n - 1));
}
```

## Test List

```csharp
Debug.Assert(SuperSeq("AGGTAB", "GXTXAYB", 6, 7) == 9);
```

```csharp
Debug.Assert(SuperSeq("feek", "eke", 4, 3) == 5);
```

```csharp
Debug.Assert(SuperSeq("PARRT", "RTA", 5, 3) == 6);
```
