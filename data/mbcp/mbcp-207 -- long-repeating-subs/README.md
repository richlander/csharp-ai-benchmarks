# mbcp-207 -- Count longest repeating subsequences with position constraints

## Text

Write a function to count the longest repeating subsequences such that the two subsequences don’t have same string characters at same positions.

## Code

```csharp
public int FindLongestRepeatingSubseq(string str) 
{
    int n = str.Length;
    int[,] dp = new int[n + 1, n + 1];

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            if (str[i - 1] == str[j - 1] && i != j)
            {
                dp[i, j] = 1 + dp[i - 1, j - 1];
            }
            else
            {
                dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
            }
        }
    }
    return dp[n, n];
}
```

## Test List

```csharp
Debug.Assert(FindLongestRepeatingSubseq("AABEBCDD") == 3);
```

```csharp
Debug.Assert(FindLongestRepeatingSubseq("aabb") == 2);
```

```csharp
Debug.Assert(FindLongestRepeatingSubseq("aab") == 1);
```
