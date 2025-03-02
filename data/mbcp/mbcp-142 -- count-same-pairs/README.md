# mbcp-142 -- Count identical pairs in three lists

## Text

Write a function to count the same pair in three given lists.

## Code

```csharp
public int CountSamePair(List<int> list1, List<int> list2, List<int> list3) {
    int result = list1.Zip(list2, (m, n) => new { m, n })
                      .Zip(list3, (pair, o) => pair.m == pair.n && pair.m == o)
                      .Count(equal => equal);
    return result;
}
```

## Test List

```csharp
Debug.Assert(CountSamePair(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 2, 2, 3, 1, 2, 6, 7, 9 }, new int[] { 2, 1, 3, 1, 2, 6, 7, 9 }) == 3);
```

```csharp
Debug.Assert(CountSamePair(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 2, 2, 3, 1, 2, 6, 7, 8 }, new int[] { 2, 1, 3, 1, 2, 6, 7, 8 }) == 4);
```

```csharp
Debug.Assert(CountSamePair(new int[] { 1, 2, 3, 4, 2, 6, 7, 8 }, new int[] { 2, 2, 3, 1, 2, 6, 7, 8 }, new int[] { 2, 1, 3, 1, 2, 6, 7, 8 }) == 5);
```
