# mbcp-298 -- Find elements in a nested list present in another list

## Text

Write a function to find the nested list elements which are present in another list.

## Code

```csharp
public List<List<int>> IntersectionNestedLists(List<int> l1, List<List<int>> l2) {
    var result = new List<List<int>>();
    foreach (var lst in l2) {
        var filteredList = new List<int>();
        foreach (var n in lst) {
            if (l1.Contains(n)) {
                filteredList.Add(n);
            }
        }
        result.Add(filteredList);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(IntersectionNestedLists(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, new List<List<int>> { new List<int> { 12, 18, 23, 25, 45 }, new List<int> { 7, 11, 19, 24, 28 }, new List<int> { 1, 5, 8, 18, 15, 16 } }) == new List<List<int>> { new List<int> { 12 }, new List<int> { 7, 11 }, new List<int> { 1, 5, 8 } });
```

```csharp
Debug.Assert(IntersectionNestedLists(new List<List<int>> { new List<int> { 2, 3, 1 }, new List<int> { 4, 5 }, new List<int> { 6, 8 } }, new List<List<int>> { new List<int> { 4, 5 }, new List<int> { 6, 8 } }) == new List<List<int>> { new List<int>(), new List<int>() });
```

```csharp
Debug.Assert(IntersectionNestedLists(new List<string> { "john", "amal", "joel", "george" }, new List<List<string>> { new List<string> { "john" }, new List<string> { "jack", "john", "mary" }, new List<string> { "howard", "john" }, new List<string> { "jude" } }).SequenceEqual(new List<List<string>> { new List<string> { "john" }, new List<string> { "john" }, new List<string> { "john" }, new List<string> { } }));
```
