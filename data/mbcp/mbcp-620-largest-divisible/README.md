# mbcp620 -- Find the largest divisible subset from a set

## Text

Write a function to find the largest subset where each pair is divisible.

## Code

```csharp
public int LargestSubset(int[] a, int n) {
    int[] dp = new int[n];
    dp[n - 1] = 1; 
    for (int i = n - 2; i >= 0; i--) {
        int mxm = 0;
        for (int j = i + 1; j < n; j++) {
            if (a[j] % a[i] == 0 || a[i] % a[j] == 0) {
                mxm = Math.Max(mxm, dp[j]);
            }
        }
        dp[i] = 1 + mxm;
    }
    return dp.Max();
}
```

## Test List

```csharp
Debug.Assert(LargestSubset(new int[] { 1, 3, 6, 13, 17, 18 }, 6) == 4);
```

```csharp
Debug.Assert(LargestSubset(new int[] { 10, 5, 3, 15, 20 }, 5) == 3);
```

```csharp
Debug.Assert(LargestSubset(new int[] { 18, 1, 3, 6, 13, 17 }, 6) == 4);
```
