# mbcp49 -- Extract specified elements from a 2D list

## Text

Write a function to extract every first or specified element from a given two-dimensional list.

## Code

```csharp
public List<T> SpecifiedElement<T>(List<List<T>> nums, int N) 
{
    return nums.Select(i => i[N]).ToList();
}
```

## Test List

```csharp
Debug.Assert(SpecifiedElement(new int[][] { new int[] { 1, 2, 3, 2 }, new int[] { 4, 5, 6, 2 }, new int[] { 7, 1, 9, 5 } }, 0).SequenceEqual(new int[] { 1, 4, 7 }));
```

```csharp
Debug.Assert(SpecifiedElement(new int[][] { new int[] { 1, 2, 3, 2 }, new int[] { 4, 5, 6, 2 }, new int[] { 7, 1, 9, 5 } }, 2).SequenceEqual(new int[] { 3, 6, 9 }));
```

```csharp
Debug.Assert(SpecifiedElement(new int[][] { new int[] { 1, 2, 3, 2 }, new int[] { 4, 5, 6, 2 }, new int[] { 7, 1, 9, 5 } }, 1).SequenceEqual(new List<int> { 2, 5, 1 }));
```
