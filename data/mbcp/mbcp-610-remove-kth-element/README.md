# mbcp610 -- Remove the k'th element from a list in Python

## Text

Write a C# function to remove the k'th element from a given list.

## Code

```csharp
public List<T> RemoveKthElement<T>(List<T> list1, int L) {
    return list1.Take(L - 1).Concat(list1.Skip(L)).ToList();
}
```

## Test List

```csharp
Debug.Assert(RemoveKthElement(new List<int> { 1, 1, 2, 3, 4, 4, 5, 1 }, 3).SequenceEqual(new List<int> { 1, 1, 3, 4, 4, 5, 1 }));
```

```csharp
Debug.Assert(RemoveKthElement(new List<int> { 0, 0, 1, 2, 3, 4, 4, 5, 6, 6, 6, 7, 8, 9, 4, 4 }, 4).SequenceEqual(new List<int> { 0, 0, 1, 3, 4, 4, 5, 6, 6, 6, 7, 8, 9, 4, 4 }));
```

```csharp
Debug.Assert(RemoveKthElement(new List<int> { 10, 10, 15, 19, 18, 18, 17, 26, 26, 17, 18, 10 }, 5).SequenceEqual(new List<int> { 10, 10, 15, 19, 18, 17, 26, 26, 17, 18, 10 }));
```
