# mbcp747 -- Find the longest common subsequence of three strings

## Text

Write a function to find the longest common subsequence for the given three string sequence.

## Code

```csharp
public int LcsOfThree(char[] X, char[] Y, char[] Z, int m, int n, int o) 
{
    int[,,] L = new int[m + 1, n + 1, o + 1];
    for (int i = 0; i <= m; i++) 
    {
        for (int j = 0; j <= n; j++) 
        {
            for (int k = 0; k <= o; k++) 
            {
                if (i == 0 || j == 0 || k == 0) 
                {
                    L[i, j, k] = 0;
                }
                else if (X[i - 1] == Y[j - 1] && X[i - 1] == Z[k - 1]) 
                {
                    L[i, j, k] = L[i - 1, j - 1, k - 1] + 1;
                }
                else 
                {
                    L[i, j, k] = Math.Max(Math.Max(L[i - 1, j, k], L[i, j - 1, k]), L[i, j, k - 1]);
                }
            }
        }
    }
    return L[m, n, o];
}
```

## Test List

```csharp
Debug.Assert(LcsOfThree("AGGT12", "12TXAYB", "12XBA", 6, 7, 5) == 2);
```

```csharp
Debug.Assert(LcsOfThree("Reels", "Reelsfor", "ReelsforReels", 5, 8, 13) == 5);
```

```csharp
Debug.Assert(LcsOfThree("abcd1e2", "bc12ea", "bd1ea", 7, 6, 5) == 3);
```
