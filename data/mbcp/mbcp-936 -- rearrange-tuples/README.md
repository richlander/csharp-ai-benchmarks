# mbcp-936 -- Rearrange tuples based on an ordered list

## Text

Write a function to re-arrange the given tuples based on the given ordered list.

## Code

```csharp
public List<Tuple<TKey, TValue>> ReArrangeTuples<TKey, TValue>(List<Tuple<TKey, TValue>> testList, List<TKey> ordList)
{
    var temp = testList.ToDictionary(item => item.Item1, item => item.Item2);
    var res = ordList.Select(key => Tuple.Create(key, temp[key])).ToList();
    return res;
}
```

## Test List

```csharp
Debug.Assert(ReArrangeTuples(new List<Tuple<int, int>> { Tuple.Create(4, 3), Tuple.Create(1, 9), Tuple.Create(2, 10), Tuple.Create(3, 2) }, new List<int> { 1, 4, 2, 3 }).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(1, 9), Tuple.Create(4, 3), Tuple.Create(2, 10), Tuple.Create(3, 2) }));
```

```csharp
Debug.Assert(ReArrangeTuples(new (int, int)[] { (5, 4), (2, 10), (3, 11), (4, 3) }, new int[] { 3, 4, 2, 3 }) == new (int, int)[] { (3, 11), (4, 3), (2, 10), (3, 11) });
```

```csharp
Debug.Assert(ReArrangeTuples(new List<(int, int)>{(6, 3), (3, 8), (5, 7), (2, 4)}, new List<int>{2, 5, 3, 6}) == new List<(int, int)>{(2, 4), (5, 7), (3, 8), (6, 3)});
```
