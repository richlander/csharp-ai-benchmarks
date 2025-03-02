# mbcp-550 -- Find max element in a sorted rotated array

## Text

Write a C# function to find the maximum element in a sorted and rotated array.

## Code

```csharp
public int FindMax(int[] arr, int low, int high) 
{ 
    if (high < low) 
    { 
        return arr[0]; 
    } 
    if (high == low) 
    { 
        return arr[low]; 
    } 
    int mid = low + (high - low) / 2; 
    if (mid < high && arr[mid + 1] < arr[mid]) 
    { 
        return arr[mid]; 
    } 
    if (mid > low && arr[mid] < arr[mid - 1]) 
    { 
        return arr[mid - 1]; 
    } 
    if (arr[low] > arr[mid]) 
    { 
        return FindMax(arr, low, mid - 1); 
    } 
    else 
    { 
        return FindMax(arr, mid + 1, high); 
    } 
}
```

## Test List

```csharp
Debug.Assert(FindMax(new int[] { 2, 3, 5, 6, 9 }, 0, 4) == 9);
```

```csharp
Debug.Assert(FindMax(new int[] { 3, 4, 5, 2, 1 }, 0, 4) == 5);
```

```csharp
Debug.Assert(FindMax(new int[] { 1, 2, 3 }, 0, 2) == 3);
```
