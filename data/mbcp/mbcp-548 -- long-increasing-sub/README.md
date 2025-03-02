# mbcp-548 -- Find the longest increasing subsequence length

## Text

Write a function to find the length of the longest increasing subsequence of the given sequence.

## Code

```csharp
public int LongestIncreasingSubsequence(int[] arr) 
{
    int n = arr.Length;
    int[] longestIncreasingSubsequence = new int[n];
    for (int i = 0; i < n; i++)
    {
        longestIncreasingSubsequence[i] = 1;
    }
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (arr[i] > arr[j] && longestIncreasingSubsequence[i] < longestIncreasingSubsequence[j] + 1)
            {
                longestIncreasingSubsequence[i] = longestIncreasingSubsequence[j] + 1;
            }
        }
    }
    int maximum = 0;
    for (int i = 0; i < n; i++)
    {
        maximum = Math.Max(maximum, longestIncreasingSubsequence[i]);
    }
    return maximum;
}
```

## Test List

```csharp
Debug.Assert(LongestIncreasingSubsequence(new int[] { 10, 22, 9, 33, 21, 50, 41, 60 }) == 5);
```

```csharp
Debug.Assert(LongestIncreasingSubsequence(new int[] { 3, 10, 2, 1, 20 }) == 3);
```

```csharp
Debug.Assert(LongestIncreasingSubsequence(new int[] { 50, 3, 10, 7, 40, 80 }) == 4);
```
