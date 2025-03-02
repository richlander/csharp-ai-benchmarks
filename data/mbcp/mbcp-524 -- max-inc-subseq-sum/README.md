# mbcp-524 -- Sum of maximum increasing subsequence in array

## Text

Write a function to find the sum of maximum increasing subsequence of the given array.

## Code

```csharp
public static int MaxSumIncreasingSubsequence(int[] arr, int n) 
{
    int max = 0;
    int[] msis = new int[n];
    for (int i = 0; i < n; i++) 
    {
        msis[i] = arr[i];
    }
    for (int i = 1; i < n; i++) 
    {
        for (int j = 0; j < i; j++) 
        {
            if (arr[i] > arr[j] && msis[i] < msis[j] + arr[i]) 
            {
                msis[i] = msis[j] + arr[i];
            }
        }
    }
    for (int i = 0; i < n; i++) 
    {
        if (max < msis[i]) 
        {
            max = msis[i];
        }
    }
    return max;
}
```

## Test List

```csharp
Debug.Assert(MaxSumIncreasingSubsequence(new int[] { 1, 101, 2, 3, 100, 4, 5 }, 7) == 106);
```

```csharp
Debug.Assert(MaxSumIncreasingSubsequence(new int[] { 3, 4, 5, 10 }, 4) == 22);
```

```csharp
Debug.Assert(MaxSumIncreasingSubsequence(new int[] { 10, 5, 4, 3 }, 4) == 10);
```
