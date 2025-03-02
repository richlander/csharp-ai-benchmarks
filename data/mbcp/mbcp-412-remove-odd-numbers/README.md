# mbcp412 -- Remove odd numbers from a list in Python

## Text

Write a C# function to remove odd numbers from a given list.

## Code

```csharp
public List<int> RemoveOdd(List<int> l) {
    for (int i = l.Count - 1; i >= 0; i--) {
        if (l[i] % 2 != 0) {
            l.RemoveAt(i);
        }
    }
    return l;
}
```

## Test List

```csharp
Debug.Assert(RemoveOdd(new int[] { 1, 2, 3 }).SequenceEqual(new int[] { 2 }));
```

```csharp
Debug.Assert(RemoveOdd(new List<int> { 2, 4, 6 }).SequenceEqual(new List<int> { 2, 4, 6 }));
```

```csharp
Debug.Assert(RemoveOdd(new List<int> { 10, 20, 3 }).SequenceEqual(new List<int> { 10, 20 }));
```
