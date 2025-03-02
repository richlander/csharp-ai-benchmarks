# mbcp149 -- Find longest subsequence with adjacent diffs of one

## Text

Write a function to find the longest subsequence such that the difference between adjacents is one for the given array.

## Code

```csharp
int LongestSubseqWithDiffOne(int[] arr, int n) 
{ 
    int[] dp = new int[n]; 
    for (int i = 0; i < n; i++) 
    { 
        dp[i] = 1; 
    } 
    for (int i = 0; i < n; i++) 
    { 
        for (int j = 0; j < i; j++) 
        { 
            if ((arr[i] == arr[j] + 1) || (arr[i] == arr[j] - 1)) 
            { 
                dp[i] = Math.Max(dp[i], dp[j] + 1); 
            } 
        } 
    } 
    int result = 1; 
    for (int i = 0; i < n; i++) 
    { 
        if (result < dp[i]) 
        { 
            result = dp[i]; 
        } 
    } 
    return result; 
}
```

## Test List

```csharp
Debug.Assert(LongestSubseqWithDiffOne(new int[] { 1, 2, 3, 4, 5, 3, 2 }, 7) == 6);
```

```csharp
Debug.Assert(LongestSubseqWithDiffOne(new int[] { 10, 9, 4, 5, 4, 8, 6 }, 7) == 3);
```

```csharp
Debug.Assert(LongestSubseqWithDiffOne(new int[] { 1, 2, 3, 2, 3, 7, 2, 1 }, 8) == 7);
```
