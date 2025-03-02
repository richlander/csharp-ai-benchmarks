# mbcp-34 -- Find the missing number in a sorted array

## Text

Write a C# function to find the missing number in a sorted array.

## Code

```csharp
public int FindMissing(int[] ar, int N) 
{ 
    int l = 0; 
    int r = N - 1; 
    while (l <= r) 
    { 
        int mid = (l + r) / 2; 
        if (ar[mid] != mid + 1 && mid > 0 && ar[mid - 1] == mid) 
        { 
            return mid + 1; 
        } 
        else if (ar[mid] != mid + 1) 
        { 
            r = mid - 1; 
        } 
        else 
        { 
            l = mid + 1; 
        } 
    } 
    return -1; 
}
```

## Test List

```csharp
Debug.Assert(FindMissing(new int[] { 1, 2, 3, 5 }) == 4);
```

```csharp
Debug.Assert(FindMissing(new int[] { 1, 3, 4, 5 }, 4) == 2);
```

```csharp
Debug.Assert(FindMissing(new int[] { 1, 2, 3, 5, 6, 7 }, 5) == 4);
```
