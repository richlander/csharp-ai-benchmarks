# mbcp890 -- Find index of an extra element in a sorted array

## Text

Write a C# function to find the index of an extra element present in one sorted array.

## Code

```csharp
public int FindExtra(int[] arr1, int[] arr2, int n) 
{ 
    for (int i = 0; i < n; i++) 
    { 
        if (arr1[i] != arr2[i]) 
        { 
            return i; 
        } 
    } 
    return n; 
}
```

## Test List

```csharp
Debug.Assert(FindExtra(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 }, 3) == 3);
```

```csharp
Debug.Assert(FindExtra(new int[] { 2, 4, 6, 8, 10 }, new int[] { 2, 4, 6, 8 }, 4) == 4);
```

```csharp
Debug.Assert(FindExtra(new int[] { 1, 3, 5, 7, 9, 11 }, new int[] { 1, 3, 5, 7, 9 }, 5) == 5);
```
