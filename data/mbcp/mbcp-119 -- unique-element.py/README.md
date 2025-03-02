# mbcp-119 -- Find unique element in sorted array using Python

## Text

Write a C# function to find the element that appears only once in a sorted array.

## Code

```csharp
public int Search(int[] arr, int n) 
{
    int XOR = 0;
    for (int i = 0; i < n; i++) 
    {
        XOR ^= arr[i];
    }
    return XOR;
}
```

## Test List

```csharp
Debug.Assert(Search(new int[] { 1, 1, 2, 2, 3 }, 5) == 3);
```

```csharp
Debug.Assert(Search(new int[] { 1, 1, 3, 3, 4, 4, 5, 5, 7, 7, 8 }, 11) == 8);
```

```csharp
Debug.Assert(Search(new int[] { 1, 2, 2, 3, 3, 4, 4 }, 7) == 1);
```
