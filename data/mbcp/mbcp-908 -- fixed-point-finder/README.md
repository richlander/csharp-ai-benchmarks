# mbcp-908 -- Find the fixed point in a given array

## Text

Write a function to find the fixed point in the given array.

## Code

```csharp
public int FindFixedPoint(int[] arr, int n) 
{ 
    for (int i = 0; i < n; i++) 
    { 
        if (arr[i] == i) 
        { 
            return i; 
        } 
    } 
    return -1; 
}
```

## Test List

```csharp
Debug.Assert(FindFixedPoint(new int[] { -10, -1, 0, 3, 10, 11, 30, 50, 100 }, 9) == 3);
```

```csharp
Debug.Assert(FindFixedPoint(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8) == -1);
```

```csharp
Debug.Assert(FindFixedPoint(new int[] { 0, 2, 5, 8, 17 }, 5) == 0);
```
