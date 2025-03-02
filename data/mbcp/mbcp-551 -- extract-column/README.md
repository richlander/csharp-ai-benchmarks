# mbcp-551 -- Extract a column from a nested list in Python

## Text

Write a function to extract a specified column from a given nested list.

## Code

```csharp
public List<object> ExtractColumn(List<List<object>> list1, int n)
{
    List<object> result = new List<object>();
    foreach (var i in list1)
    {
        result.Add(i[n]);
        i.RemoveAt(n);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(ExtractColumn(new int[,] { { 1, 2, 3 }, { 2, 4, 5 }, { 1, 1, 1 } }, 0).SequenceEqual(new int[] { 1, 2, 1 }));
```

```csharp
Debug.Assert(ExtractColumn(new int[][] { new int[] { 1, 2, 3 }, new int[] { -2, 4, -5 }, new int[] { 1, -1, 1 } }, 2).SequenceEqual(new int[] { 3, -5, 1 }));
```

```csharp
Debug.Assert(ExtractColumn(new int[][] { new int[] { 1, 3 }, new int[] { 5, 7 }, new int[] { 1, 3 }, new int[] { 13, 15, 17 }, new int[] { 5, 7 }, new int[] { 9, 11 } }, 0).SequenceEqual(new int[] { 1, 5, 1, 13, 5, 9 }));
```
