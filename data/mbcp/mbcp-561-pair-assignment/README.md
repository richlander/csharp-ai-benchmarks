# mbcp561 -- Pair elements in a tuple with their similar pairs

## Text

Write a function to assign with each element, its pair elements from other similar pairs in the given tuple.

## Code

```csharp
public Dictionary<object, List<object>> AssignElements(List<Tuple<object, object>> testList) {
    var res = new Dictionary<object, List<object>>();
    foreach (var tuple in testList) {
        var key = tuple.Item1;
        var val = tuple.Item2;
        if (!res.ContainsKey(val)) {
            res[val] = new List<object>();
        }
        if (!res.ContainsKey(key)) {
            res[key] = new List<object>();
        }
        res[key].Add(val);
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(AssignElements(new Tuple<int, int>[] { Tuple.Create(5, 3), Tuple.Create(7, 5), Tuple.Create(2, 7), Tuple.Create(3, 8), Tuple.Create(8, 4) }) .SequenceEqual(new Dictionary<int, List<int>> { { 3, new List<int> { 8 } }, { 5, new List<int> { 3 } }, { 7, new List<int> { 5 } }, { 2, new List<int> { 7 } }, { 8, new List<int> { 4 } }, { 4, new List<int> { } } }));
```

```csharp
Debug.Assert(AssignElements(new (int, int)[] { (6, 4), (9, 4), (3, 8), (4, 9), (9, 5) }) .SequenceEqual(new Dictionary<int, List<int>> { { 4, new List<int> { 9 } }, { 6, new List<int> { 4 } }, { 9, new List<int> { 4, 5 } }, { 8, new List<int>() }, { 3, new List<int> { 8 } }, { 5, new List<int>() } }));
```

```csharp
Debug.Assert(AssignElements(new (int, int)[] { (6, 2), (6, 8), (4, 9), (4, 9), (3, 7) }) 
    .SequenceEqual(new Dictionary<int, List<int>> { { 2, new List<int>() }, { 6, new List<int> { 2, 8 } }, { 8, new List<int>() }, { 9, new List<int>() }, { 4, new List<int> { 9, 9 } }, { 7, new List<int>() }, { 3, new List<int> { 7 } } }));
```
