# mbcp-758 -- Count unique lists in a given list of lists

## Text

Write a function to count number of unique lists within a list.

## Code

```csharp
public Dictionary<(int, int), int> UniqueSublists(List<List<int>> list1) {
    var result = new Dictionary<(int, int), List<int>>();
    foreach (var l in list1) {
        var key = (l[0], l[1]);
        if (!result.ContainsKey(key)) {
            result[key] = new List<int>();
        }
        result[key].Add(1);
    }
    var finalResult = new Dictionary<(int, int), int>();
    foreach (var kvp in result) {
        finalResult[kvp.Key] = kvp.Value.Sum();
    }
    return finalResult;
}
```

## Test List

```csharp
Debug.Assert(UniqueSublists(new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 1, 3 }, new List<int> { 13, 15, 17 }, new List<int> { 5, 7 }, new List<int> { 9, 11 } }) .SequenceEqual(new Dictionary<Tuple<int, int>, int> { { Tuple.Create(1, 3), 2 }, { Tuple.Create(5, 7), 2 }, { Tuple.Create(13, 15, 17), 1 }, { Tuple.Create(9, 11), 1 } }));
```

```csharp
Debug.Assert(UniqueSublists(new List<List<string>> { new List<string> { "green", "orange" }, new List<string> { "black" }, new List<string> { "green", "orange" }, new List<string> { "white" } }).SequenceEqual(new Dictionary<(string, string), int> { { ("green", "orange"), 2 }, { ("black"), 1 }, { ("white"), 1 } }));
```

```csharp
Debug.Assert(UniqueSublists(new List<List<int>> { new List<int> { 10, 20, 30, 40 }, new List<int> { 60, 70, 50, 50 }, new List<int> { 90, 100, 200 } }).SequenceEqual(new Dictionary<Tuple<int, int, int, int>, int> { { Tuple.Create(10, 20, 30, 40), 1 }, { Tuple.Create(60, 70, 50, 50), 1 }, { Tuple.Create(90, 100, 200), 1 } }));
```
