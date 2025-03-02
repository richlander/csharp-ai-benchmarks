# mbcp-706 -- Check if one array is a subset of another array

## Text

Write a function to find whether an array is subset of another array.

## Code

```csharp
bool IsSubset(int[] arr1, int m, int[] arr2, int n) 
{ 
    HashSet<int> hashset = new HashSet<int>(); 
    for (int i = 0; i < m; i++) 
    { 
        hashset.Add(arr1[i]); 
    } 
    for (int i = 0; i < n; i++) 
    { 
        if (hashset.Contains(arr2[i])) 
        { 
            continue; 
        } 
        else 
        { 
            return false; 
        } 
    } 
    return true; 
}
```

## Test List

```csharp
Debug.Assert(IsSubset(new int[] { 11, 1, 13, 21, 3, 7 }, 6, new int[] { 11, 3, 7, 1 }, 4) == true);
```

```csharp
Debug.Assert(IsSubset(new List<int> { 1, 2, 3, 4, 5, 6 }, 6, new List<int> { 1, 2, 4 }, 3) == true);
```

```csharp
Debug.Assert(IsSubset(new List<int> { 10, 5, 2, 23, 19 }, 5, new List<int> { 19, 5, 3 }, 3) == false);
```
