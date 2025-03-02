# mbcp-513 -- Convert tuple to list with string after each element

## Text

Write a function to convert tuple into list by adding the given string after every element.

## Code

```csharp
public List<object> AddStr(IEnumerable<IEnumerable<object>> testTup, object K) 
{
    var res = testTup.SelectMany(sub => new List<object> { sub, K }).ToList();
    return res;
}
```

## Test List

```csharp
Debug.Assert(AddStr(new Tuple<int, int, int, int, int>(5, 6, 7, 4, 9), "FDF").SequenceEqual(new object[] { 5, "FDF", 6, "FDF", 7, "FDF", 4, "FDF", 9, "FDF" }));
```

```csharp
Debug.Assert(AddStr(new int[] { 7, 8, 9, 10 }, "PF").SequenceEqual(new object[] { 7, "PF", 8, "PF", 9, "PF", 10, "PF" }));
```

```csharp
Debug.Assert(AddStr(new int[] { 11, 14, 12, 1, 4 }, "JH").SequenceEqual(new object[] { 11, "JH", 14, "JH", 12, "JH", 1, "JH", 4, "JH" }));
```
