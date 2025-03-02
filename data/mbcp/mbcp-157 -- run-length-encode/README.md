# mbcp-157 -- Reflect run-length encoding in a list function

## Text

Write a function to reflect the run-length encoding from a list.

## Code

```csharp
public List<List<object>> EncodeList(List<int> list1) {
    return list1.GroupBy(x => x)
                 .Select(g => new List<object> { g.Count(), g.Key })
                 .ToList();
}
```

## Test List

```csharp
Debug.Assert(EncodeList(new List<object> { 1, 1, 2, 3, 4, 4.3, 5, 1 }).SequenceEqual(new List<List<object>> { new List<object> { 2, 1 }, new List<object> { 1, 2 }, new List<object> { 1, 3 }, new List<object> { 1, 4 }, new List<object> { 1, 4.3 }, new List<object> { 1, 5 }, new List<object> { 1, 1 } }));
```

```csharp
Debug.Assert(EncodeList("automatically").SequenceEqual(new List<List<object>> { new List<object> { 1, 'a' }, new List<object> { 1, 'u' }, new List<object> { 1, 't' }, new List<object> { 1, 'o' }, new List<object> { 1, 'm' }, new List<object> { 1, 'a' }, new List<object> { 1, 't' }, new List<object> { 1, 'i' }, new List<object> { 1, 'c' }, new List<object> { 1, 'a' }, new List<object> { 2, 'l' }, new List<object> { 1, 'y' } }));
```

```csharp
Debug.Assert(EncodeList("python").SequenceEqual(new List<List<object>> { new List<object> { 1, 'p' }, new List<object> { 1, 'y' }, new List<object> { 1, 't' }, new List<object> { 1, 'h' }, new List<object> { 1, 'o' }, new List<object> { 1, 'n' } } }));
```
