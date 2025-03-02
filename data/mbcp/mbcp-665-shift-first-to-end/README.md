# mbcp665 -- Shift first list element to the end in Python

## Text

Write a C# function to shift first element to the end of given list.

## Code

```csharp
public List<int> MoveLast(List<int> numList) {
    var a = new List<int>(numList.Count(n => n == numList[0]));
    for (int i = 0; i < numList.Count(n => n == numList[0]); i++) {
        a.Add(numList[0]);
    }
    var x = numList.Where(i => i != numList[0]).ToList();
    x.AddRange(a);
    return x;
}
```

## Test List

```csharp
Debug.Assert(MoveLast(new int[] { 1, 2, 3, 4 }).SequenceEqual(new int[] { 2, 3, 4, 1 }));
```

```csharp
Debug.Assert(MoveLast(new List<int> { 2, 3, 4, 1, 5, 0 }).SequenceEqual(new List<int> { 3, 4, 1, 5, 0, 2 }));
```

```csharp
Debug.Assert(MoveLast(new int[] { 5, 4, 3, 2, 1 }).SequenceEqual(new int[] { 4, 3, 2, 1, 5 }));
```
