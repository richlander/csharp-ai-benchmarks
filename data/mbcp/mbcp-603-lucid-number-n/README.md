# mbcp603 -- Get the nearest lucid number to n

## Text

Write a function to get a lucid number smaller than or equal to n.

## Code

```csharp
public List<int> GetLudic(int n) {
    List<int> ludics = new List<int>();
    for (int i = 1; i <= n; i++) {
        ludics.Add(i);
    }
    int index = 1;
    while (index != ludics.Count) {
        int firstLudic = ludics[index];
        int removeIndex = index + firstLudic;
        while (removeIndex < ludics.Count) {
            ludics.RemoveAt(removeIndex);
            removeIndex += firstLudic - 1;
        }
        index++;
    }
    return ludics;
}
```

## Test List

```csharp
Debug.Assert(GetLudic(10).SequenceEqual(new List<int> { 1, 2, 3, 5, 7 }));
```

```csharp
Debug.Assert(GetLudic(25).SequenceEqual(new List<int> { 1, 2, 3, 5, 7, 11, 13, 17, 23, 25 }));
```

```csharp
Debug.Assert(GetLudic(45).SequenceEqual(new List<int> { 1, 2, 3, 5, 7, 11, 13, 17, 23, 25, 29, 37, 41, 43 }));
```
