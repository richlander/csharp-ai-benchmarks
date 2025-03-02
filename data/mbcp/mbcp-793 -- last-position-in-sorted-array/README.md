# mbcp-793 -- Find last position of an element in sorted array

## Text

Write a C# function to find the last position of an element in a sorted array.

## Code

```csharp
public int Last(int[] arr, int x, int n) 
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
            low = mid + 1;
        }
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(Last(new int[] { 1, 2, 3 }, 1, 3) == 0);
```

```csharp
Debug.Assert(Last(new int[] { 1, 1, 1, 2, 3, 4 }, 1, 6) == 2);
```

```csharp
Debug.Assert(Last(new int[] { 2, 3, 2, 3, 6, 8, 9 }, 3, 8) == 3);
```
