# mbcp-225 -- Find minimum in a sorted rotated array

## Text

Write a C# function to find the minimum element in a sorted and rotated array.

## Code

```csharp
public int FindMin(int[] arr, int low, int high) 
{ 
    while (low < high) 
    { 
        int mid = low + (high - low) / 2; 
        if (arr[mid] == arr[high]) 
        { 
            high--; 
        } 
        else if (arr[mid] > arr[high]) 
        { 
            low = mid + 1; 
        } 
        else 
        { 
            high = mid; 
        } 
    } 
    return arr[high]; 
}
```

## Test List

```csharp
Debug.Assert(FindMin(new int[] { 1, 2, 3, 4, 5 }, 0, 4) == 1);
```

```csharp
Debug.Assert(FindMin(new int[] { 4, 6, 8 }, 0, 2) == 4);
```

```csharp
Debug.Assert(FindMin(new int[] { 2, 3, 5, 7, 9 }, 0, 4) == 2);
```
