# mbcp632 -- Move all zeroes to the end of the list

## Text

Write a C# function to move all zeroes to the end of the given list.

## Code

```csharp
public List<int> MoveZero(List<int> numList) {
    List<int> a = new List<int>(new int[numList.Count(n => n == 0)]);
    List<int> x = numList.Where(i => i != 0).ToList();
    x.AddRange(a);
    return x;
}
```

## Test List

```csharp
Debug.Assert(MoveZero(new int[] { 1, 0, 2, 0, 3, 4 }).SequenceEqual(new int[] { 1, 2, 3, 4, 0, 0 }));
```

```csharp
Debug.Assert(MoveZero(new int[] { 2, 3, 2, 0, 0, 4, 0, 5, 0 }).SequenceEqual(new int[] { 2, 3, 2, 4, 5, 0, 0, 0, 0 }));
```

```csharp
Debug.Assert(MoveZero(new int[] { 0, 1, 0, 1, 1 }).SequenceEqual(new int[] { 1, 1, 1, 0, 0 }));
```
