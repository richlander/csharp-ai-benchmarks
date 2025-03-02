# mbcp-328 -- Rotate a list left by a given number of items

## Text

Write a function to rotate a given list by specified number of items to the left direction.

## Code

```csharp
public List<T> RotateLeft<T>(List<T> list1, int m, int n)
{
    var result = list1.GetRange(m, list1.Count - m).Concat(list1.GetRange(0, n)).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(RotateLeft(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, 4).SequenceEqual(new int[] { 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4 }));
```

```csharp
Debug.Assert(RotateLeft(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, 2).SequenceEqual(new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 1, 2 }));
```

```csharp
Debug.Assert(RotateLeft(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 2).SequenceEqual(new int[] { 6, 7, 8, 9, 10, 1, 2 }));
```
