# mbcp-661 -- Max sum of non-consecutive elements in a list

## Text

Write a function to find the maximum sum that can be formed which has no three consecutive elements present.

## Code

```csharp
public int MaxSumOfThreeConsecutive(int[] arr, int n) 
{
    int[] sum = new int[n];
    if (n >= 1) 
    {
        sum[0] = arr[0];
    }
    if (n >= 2) 
    {
        sum[1] = arr[0] + arr[1];
    }
    if (n > 2) 
    {
        sum[2] = Math.Max(sum[1], Math.Max(arr[1] + arr[2], arr[0] + arr[2]));
    }
    for (int i = 3; i < n; i++) 
    {
        sum[i] = Math.Max(Math.Max(sum[i - 1], sum[i - 2] + arr[i]), arr[i] + arr[i - 1] + sum[i - 3]);
    }
    return sum[n - 1];
}
```

## Test List

```csharp
Debug.Assert(MaxSumOfThreeConsecutive(new int[] { 100, 1000, 100, 1000, 1 }, 5) == 2101);
```

```csharp
Debug.Assert(MaxSumOfThreeConsecutive(new int[] { 3000, 2000, 1000, 3, 10 }, 5) == 5013);
```

```csharp
Debug.Assert(MaxSumOfThreeConsecutive(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8) == 27);
```
