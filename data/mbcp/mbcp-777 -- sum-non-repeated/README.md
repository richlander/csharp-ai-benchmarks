# mbcp-777 -- Sum non-repeated elements in an array with Python

## Text

Write a C# function to find the sum of non-repeated elements in a given array.

## Code

```csharp
public int FindSum(int[] arr, int n) 
{
    Array.Sort(arr);
    int sum = arr[0];
    for (int i = 0; i < n - 1; i++) 
    {
        if (arr[i] != arr[i + 1]) 
        {
            sum += arr[i + 1];
        }
    }
    return sum;
}
```

## Test List

```csharp
Debug.Assert(FindSum(new int[] { 1, 2, 3, 1, 1, 4, 5, 6 }, 8) == 21);
```

```csharp
Debug.Assert(FindSum(new int[] { 1, 10, 9, 4, 2, 10, 10, 45, 4 }, 9) == 71);
```

```csharp
Debug.Assert(FindSum(new int[] { 12, 10, 9, 45, 2, 10, 10, 45, 10 }, 9) == 78);
```
