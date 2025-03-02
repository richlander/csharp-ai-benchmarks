# mbcp-195 -- Find first index of an element in sorted array

## Text

Write a C# function to find the first position of an element in a sorted array.

## Code

```csharp
int First(int[] arr, int x, int n) 
{ 
    int low = 0; 
    int high = n - 1; 
    int res = -1; 
    while (low <= high) 
    { 
        int mid = (low + high) / 2; 
        if (arr[mid] > x) 
        { 
            high = mid - 1; 
        } 
        else if (arr[mid] < x) 
        { 
            low = mid + 1; 
        } 
        else 
        { 
            res = mid; 
            high = mid - 1; 
        } 
    } 
    return res; 
}
```

## Test List

```csharp
Debug.Assert(First(new int[] { 1, 2, 3, 4, 5, 6, 6 }, 6, 6) == 5);
```

```csharp
Debug.Assert(First(new int[] { 1, 2, 2, 2, 3, 2, 2, 4, 2 }, 2, 9) == 1);
```

```csharp
Debug.Assert(First(new int[] { 1, 2, 3 }, 1, 3) == 0);
```
