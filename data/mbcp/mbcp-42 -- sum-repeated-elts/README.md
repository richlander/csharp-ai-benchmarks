# mbcp-42 -- Sum repeated elements in an array using Python

## Text

Write a C# function to find the sum of repeated elements in a given array.

## Code

```csharp
public int FindSum(int[] arr, int n) 
{ 
    return arr.Where(x => arr.Count(y => y == x) > 1).Sum(); 
}
```

## Test List

```csharp
Debug.Assert(FindSum(new int[] { 1, 2, 3, 1, 1, 4, 5, 6 }, 8) == 3);
```

```csharp
Debug.Assert(FindSum(new int[] { 1, 2, 3, 1, 1 }, 5) == 3);
```

```csharp
Debug.Assert(FindSum(new int[] { 1, 1, 2 }, 3) == 2);
```
