# mbcp627 -- Find the smallest missing number in an array

## Text

Write a C# function to find the smallest missing number from the given array.

## Code

```csharp
public int FindFirstMissing(int[] array, int start, int end) 
{ 
    if (start > end) 
    { 
        return end + 1; 
    } 
    if (start != array[start]) 
    { 
        return start; 
    } 
    int mid = (start + end) / 2; 
    if (array[mid] == mid) 
    { 
        return FindFirstMissing(array, mid + 1, end); 
    } 
    return FindFirstMissing(array, start, mid); 
}
```

## Test List

```csharp
Debug.Assert(FindFirstMissing(new int[] { 0, 1, 2, 3 }, 0, 3) == 4);
```

```csharp
Debug.Assert(FindFirstMissing(new int[] { 0, 1, 2, 6, 9 }, 0, 4) == 3);
```

```csharp
Debug.Assert(FindFirstMissing(new int[] { 2, 3, 5, 8, 9 }, 0, 4) == 0);
```
