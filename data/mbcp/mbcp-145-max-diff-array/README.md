# mbcp145 -- Find max difference between elements in an array

## Text

Write a C# function to find the maximum difference between any two elements in a given array.

## Code

```csharp
public static int MaxAbsDiff(int[] arr, int n) 
{ 
    int minEle = arr[0]; 
    int maxEle = arr[0]; 
    for (int i = 1; i < n; i++) 
    { 
        minEle = Math.Min(minEle, arr[i]); 
        maxEle = Math.Max(maxEle, arr[i]); 
    } 
    return (maxEle - minEle); 
}
```

## Test List

```csharp
Debug.Assert(MaxAbsDiff(new int[] { 2, 1, 5, 3 }, 4) == 4);
```

```csharp
Debug.Assert(MaxAbsDiff(new int[] {9, 3, 2, 5, 1}, 5) == 8);

public static int MaxAbsDiff(int[] values, int target)
{
    // Implementation here
}
```

```csharp
Debug.Assert(MaxAbsDiff(new int[] {3, 2, 1}, 3) == 2);
```
