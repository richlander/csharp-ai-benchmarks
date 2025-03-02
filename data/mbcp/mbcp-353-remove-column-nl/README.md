# mbcp353 -- Remove a specified column from a nested list

## Text

Write a function to remove a specified column from a given nested list.

## Code

```csharp
public List<List<T>> RemoveColumn<T>(List<List<T>> list1, int n) 
{
    foreach (var i in list1)
    {
        i.RemoveAt(n);
    }
    return list1;
}
```

## Test List

```csharp
Debug.Assert(RemoveColumn(new int[][] { new int[] { 1, 2, 3 }, new int[] { 2, 4, 5 }, new int[] { 1, 1, 1 } }, 0).SequenceEqual(new int[][] { new int[] { 2, 3 }, new int[] { 4, 5 }, new int[] { 1, 1 } }));
```

```csharp
Debug.Assert(RemoveColumn(new int[][] { new int[] { 1, 2, 3 }, new int[] { -2, 4, -5 }, new int[] { 1, -1, 1 } }, 2).SequenceEqual(new int[][] { new int[] { 1, 2 }, new int[] { -2, 4 }, new int[] { 1, -1 } }));
```

```csharp
Debug.Assert(RemoveColumn(new int[][] { new int[] { 1, 3 }, new int[] { 5, 7 }, new int[] { 1, 3 }, new int[] { 13, 15, 17 }, new int[] { 5, 7 }, new int[] { 9, 11 } }, 0).SequenceEqual(new int[][] { new int[] { 3 }, new int[] { 7 }, new int[] { 3 }, new int[] { 15, 17 }, new int[] { 7 }, new int[] { 11 } }));
```
