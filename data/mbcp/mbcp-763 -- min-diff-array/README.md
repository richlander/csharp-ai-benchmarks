# mbcp-763 -- Find minimum difference in array elements

## Text

Write a C# function to find the minimum difference between any two elements in a given array.

## Code

```csharp
public static long FindMinDiff(int[] arr, int n) 
{ 
    Array.Sort(arr); 
    long diff = (long)1e20; 
    for (int i = 0; i < n - 1; i++) 
    { 
        if (arr[i + 1] - arr[i] < diff) 
        { 
            diff = arr[i + 1] - arr[i]; 
        } 
    } 
    return diff; 
}
```

## Test List

```csharp
Debug.Assert(FindMinDiff(new int[] { 1, 5, 3, 19, 18, 25 }, 6) == 1);
```

```csharp
Debug.Assert(FindMinDiff(new int[] { 4, 3, 2, 6 }, 4) == 1);
```

```csharp
Debug.Assert(FindMinDiff(new int[] { 30, 5, 20, 9 }, 4) == 4);
```
