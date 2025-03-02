# mbcp154 -- Extract elements from a specified 2D list

## Text

Write a function to extract every specified element from a given two dimensional list.

## Code

```csharp
public List<int> SpecifiedElement(List<List<int>> nums, int N) {
    List<int> result = new List<int>();
    foreach (var i in nums) {
        result.Add(i[N]);
    }
    return result;
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
Debug.Assert(SpecifiedElement(new int[][] { new int[] { 1, 2, 3, 2 }, new int[] { 4, 5, 6, 2 }, new int[] { 7, 1, 9, 5 } }, 3).SequenceEqual(new int[] { 2, 2, 5 }));
```
