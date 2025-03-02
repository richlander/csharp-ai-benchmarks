# mbcp-187 -- Find the longest common subsequence of two sequences

## Text

Write a function to find the longest common subsequence for the given two sequences.

## Code

```csharp
public int LongestCommonSubsequence(char[] X, char[] Y, int m, int n) 
{ 
    if (m == 0 || n == 0) 
        return 0; 
    else if (X[m - 1] == Y[n - 1]) 
        return 1 + LongestCommonSubsequence(X, Y, m - 1, n - 1); 
    else 
        return Math.Max(LongestCommonSubsequence(X, Y, m, n - 1), LongestCommonSubsequence(X, Y, m - 1, n)); 
}
```

## Test List

```csharp
Debug.Assert(LongestCommonSubsequence("AGGTAB", "GXTXAYB", 6, 7) == 4);
```

```csharp
Debug.Assert(LongestCommonSubsequence("ABCDGH", "AEDFHR", 6, 6) == 3);
```

```csharp
Debug.Assert(LongestCommonSubsequence("AXYT", "AYZX", 4, 4) == 2);
```
