# mbcp510 -- Count subsequences with product less than k

## Text

Write a function to find the number of subsequences having product smaller than k for the given non negative array.

## Code

```csharp
public int NoOfSubsequences(int[] arr, int k) 
{
    int n = arr.Length;
    int[,] dp = new int[k + 1, n + 1];

    for (int i = 1; i <= k; i++) 
    {
        for (int j = 1; j <= n; j++) 
        {
            dp[i, j] = dp[i, j - 1];
            if (arr[j - 1] <= i && arr[j - 1] > 0) 
            {
                dp[i, j] += dp[i / arr[j - 1], j - 1] + 1;
            }
        }
    }
    return dp[k, n];
}
```

## Test List

```csharp
Debug.Assert(NoOfSubsequences(new int[] { 1, 2, 3, 4 }, 10) == 11);
```

```csharp
Debug.Assert(NoOfSubsequences(new int[] { 4, 8, 7, 2 }, 50) == 9);
```

```csharp
Debug.Assert(NoOfSubsequences(new int[] { 5, 6, 7, 8 }, 15) == 4);
```
