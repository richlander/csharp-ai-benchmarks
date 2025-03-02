# mbcp-571 -- Max sum of disjoint pairs up to k in array

## Text

Write a function to find maximum possible sum of disjoint pairs for the given array of integers and a number k.

## Code

```csharp
public int MaxSumPairDiffLessthanK(int[] arr, int N, int K) 
{
    Array.Sort(arr);
    int[] dp = new int[N];
    dp[0] = 0;
    for (int i = 1; i < N; i++) 
    {
        dp[i] = dp[i - 1];
        if (arr[i] - arr[i - 1] < K) 
        {
            if (i >= 2) 
            {
                dp[i] = Math.Max(dp[i], dp[i - 2] + arr[i] + arr[i - 1]);
            } 
            else 
            {
                dp[i] = Math.Max(dp[i], arr[i] + arr[i - 1]);
            }
        }
    }
    return dp[N - 1];
}
```

## Test List

```csharp
Debug.Assert(MaxSumPairDiffLessthanK(new int[] { 3, 5, 10, 15, 17, 12, 9 }, 7, 4) == 62);
```

```csharp
Debug.Assert(MaxSumPairDiffLessthanK(new int[] { 5, 15, 10, 300 }, 4, 12) == 25);
```

```csharp
Debug.Assert(MaxSumPairDiffLessthanK(new int[] { 1, 2, 3, 4, 5, 6 }, 6, 6) == 21);
```
