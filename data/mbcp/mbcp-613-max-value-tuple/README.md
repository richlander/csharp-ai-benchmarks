# mbcp613 -- Find max value in tuple attribute of list

## Text

Write a function to find the maximum value in record list as tuple attribute in the given tuple list.

## Code

```csharp
public List<Tuple<TKey, int>> MaximumValue<TKey>(List<Tuple<TKey, List<int>>> testList) {
    var res = testList.Select(item => Tuple.Create(item.Item1, item.Item2.Max())).ToList();
    return res;
}
```

## Test List

```csharp
Debug.Assert(MaximumValue(new List<Tuple<string, List<int>>>() { 
    new Tuple<string, List<int>>("key1", new List<int>() { 3, 4, 5 }), 
    new Tuple<string, List<int>>("key2", new List<int>() { 1, 4, 2 }), 
    new Tuple<string, List<int>>("key3", new List<int>() { 9, 3 }) 
}) ).SequenceEqual(new List<Tuple<string, int>>() { 
    new Tuple<string, int>("key1", 5), 
    new Tuple<string, int>("key2", 4), 
    new Tuple<string, int>("key3", 9) }));
```

```csharp
Debug.Assert(MaximumValue(new List<Tuple<string, List<int>>> { 
    Tuple.Create("key1", new List<int> { 4, 5, 6 }), 
    Tuple.Create("key2", new List<int> { 2, 5, 3 }), 
    Tuple.Create("key3", new List<int> { 10, 4 }) 
}) == new List<Tuple<string, int>> { 
    Tuple.Create("key1", 6), 
    Tuple.Create("key2", 5), 
    Tuple.Create("key3", 10) });
```

```csharp
Debug.Assert(MaximumValue(new List<Tuple<string, List<int>>> { 
    new Tuple<string, List<int>>("key1", new List<int> { 5, 6, 7 }), 
    new Tuple<string, List<int>>("key2", new List<int> { 3, 6, 4 }), 
    new Tuple<string, List<int>>("key3", new List<int> { 11, 5 }) 
}) == new List<Tuple<string, int>> { 
    new Tuple<string, int>("key1", 7), 
    new Tuple<string, int>("key2", 6), 
    new Tuple<string, int>("key3", 11) });
```
