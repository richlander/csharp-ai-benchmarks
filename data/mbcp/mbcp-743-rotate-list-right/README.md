# mbcp743 -- Rotate a list to the right by a specified amount

## Text

Write a function to rotate a given list by specified number of items to the right direction.

## Code

```csharp
public List<T> RotateRight<T>(List<T> list1, int m, int n)
{
    var result = list1.Skip(list1.Count - m).ToList().Concat(list1.Take(list1.Count - n)).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(RotateRight(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, 4).SequenceEqual(new List<int> { 8, 9, 10, 1, 2, 3, 4, 5, 6 }));
```

```csharp
Debug.Assert(RotateRight(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, 2).SequenceEqual(new List<int> { 9, 10, 1, 2, 3, 4, 5, 6, 7, 8 }));
```

```csharp
Debug.Assert(RotateRight(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 2).SequenceEqual(new int[] { 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8 }));
```
