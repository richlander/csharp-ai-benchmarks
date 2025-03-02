# mbcp466 -- Find the peak element in an array efficiently

## Text

Write a function to find the peak element in the given array.

## Code

```csharp
public static int FindPeakUtil(int[] arr, int low, int high, int n) 
{
    int mid = low + (high - low) / 2;
    if ((mid == 0 || arr[mid - 1] <= arr[mid]) && 
        (mid == n - 1 || arr[mid + 1] <= arr[mid]))
    {
        return mid;
    }
    else if (mid > 0 && arr[mid - 1] > arr[mid])
    {
        return FindPeakUtil(arr, low, mid - 1, n);
    }
    else
    {
        return FindPeakUtil(arr, mid + 1, high, n);
    }
}

public static int FindPeak(int[] arr, int n) 
{
    return FindPeakUtil(arr, 0, n - 1, n);
}
```

## Test List

```csharp
Debug.Assert(FindPeakUtil(new int[] { 1, 3, 20, 4, 1, 0 }, 6) == 2);
```

```csharp
Debug.Assert(FindPeakUtil(new int[] { 2, 3, 4, 5, 6 }, 5) == 4);
```

```csharp
Debug.Assert(FindPeakUtil(new int[] { 8, 9, 11, 12, 14, 15 }, 6) == 5);
```
