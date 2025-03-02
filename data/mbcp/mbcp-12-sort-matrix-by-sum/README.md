# mbcp12 -- Sort a matrix by the sum of its rows in ascending order

## Text

Write a function to sort a given matrix in ascending order according to the sum of its rows.

## Code

```csharp
public List<List<int>> SortMatrix(List<List<int>> M)
{
    var result = M.OrderBy(row => row.Sum()).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(SortMatrix(new int[][] { new int[] { 1, 2, 3 }, new int[] { 2, 4, 5 }, new int[] { 1, 1, 1 } }) == new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 2, 3 }, new int[] { 2, 4, 5 } });
```

```csharp
Debug.Assert(SortMatrix(new int[][] { new int[] { 1, 2, 3 }, new int[] { -2, 4, -5 }, new int[] { 1, -1, 1 } }).SequenceEqual(new int[][] { new int[] { -2, 4, -5 }, new int[] { 1, -1, 1 }, new int[] { 1, 2, 3 } }));
```

```csharp
Debug.Assert(SortMatrix(new int[,] {{5,8,9},{6,4,3},{2,1,4}}).SequenceEqual(new int[,] {{2, 1, 4}, {6, 4, 3}, {5, 8, 9}}));
```
