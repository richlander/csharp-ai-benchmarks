# mbcp243 -- Sort list by frequency of first element in tuples

## Text

Write a function to sort the given list based on the occurrence of first element of tuples.

## Code

```csharp
public List<(string, int)> SortOnOccurrence(List<(string, int)> lst) 
{
    var dct = new Dictionary<string, List<int>>();
    foreach (var (i, j) in lst) 
    {
        if (!dct.ContainsKey(i))
        {
            dct[i] = new List<int>();
        }
        dct[i].Add(j);
    }
    return dct.Select(kvp => (kvp.Key, kvp.Value.Distinct().Count())).ToList();
}
```

## Test List

```csharp
Debug.Assert(SortOnOccurrence(new List<(int, string)>{ (1, "Jake"), (2, "Bob"), (1, "Cara") }) == new List<(int, string, string, int)>{ (1, "Jake", "Cara", 2), (2, "Bob", 1) });
```

```csharp
Debug.Assert(SortOnOccurrence(new List<Tuple<string, string>> { Tuple.Create("b", "ball"), Tuple.Create("a", "arm"), Tuple.Create("b", "b"), Tuple.Create("a", "ant") }) == new List<Tuple<string, string, string, int>> { Tuple.Create("b", "ball", "b", 2), Tuple.Create("a", "arm", "ant", 2) });
```

```csharp
Debug.Assert(SortOnOccurrence(new Tuple<int, string>[] { Tuple.Create(2, "Mark"), Tuple.Create(3, "Maze"), Tuple.Create(2, "Sara") }).SequenceEqual(new object[] { Tuple.Create(2, "Mark", "Sara", 2), Tuple.Create(3, "Maze", 1) }));
```
