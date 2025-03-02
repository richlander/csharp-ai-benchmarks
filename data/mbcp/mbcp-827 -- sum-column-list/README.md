# mbcp-827 -- Sum a specific column from a list of lists

## Text

Write a function to sum a specific column of a list in a given list of lists.

## Code

```csharp
public static int SumColumn(List<List<int>> list1, int C) {
    int result = list1.Sum(row => row[C]);
    return result;
}
```

## Test List

```csharp
Debug.Assert(SumColumn(new int[][] { new int[] { 1, 2, 3, 2 }, new int[] { 4, 5, 6, 2 }, new int[] { 7, 8, 9, 5 } }, 0) == 12);
```

```csharp
Debug.Assert(SumColumn(new int[][] { new int[] { 1, 2, 3, 2 }, new int[] { 4, 5, 6, 2 }, new int[] { 7, 8, 9, 5 } }, 1) == 15);
```

```csharp
Debug.Assert(SumColumn(new int[][] { new int[] { 1, 2, 3, 2 }, new int[] { 4, 5, 6, 2 }, new int[] { 7, 8, 9, 5 } }, 3) == 9);
```
