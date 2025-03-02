# mbcp25 -- Product of unique array elements in Python

## Text

Write a C# function to find the product of non-repeated elements in a given array.

## Code

```csharp
public int FindProduct(int[] arr, int n) 
{ 
    Array.Sort(arr); 
    int prod = 1; 
    for (int i = 0; i < n; i++) 
    { 
        if (arr[i - 1] != arr[i]) 
        { 
            prod *= arr[i]; 
        } 
    } 
    return prod; 
}
```

## Test List

```csharp
Debug.Assert(FindProduct(new int[] { 1, 1, 2, 3 }, 4) == 6);
```

```csharp
Debug.Assert(FindProduct(new int[] { 1, 2, 3, 1, 1 }, 5) == 6);
```

```csharp
Debug.Assert(FindProduct(new int[] { 1, 1, 4, 5, 6 }, 5) == 120);
```
