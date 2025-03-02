# mbcp370 -- Sort a tuple based on its float elements

## Text

Write a function to sort a tuple by its float element.

## Code

```csharp
public List<List<string>> FloatSort(List<List<string>> price)
{
    var floatSort = price.OrderByDescending(x => float.Parse(x[1])).ToList();
    return floatSort;
}
```

## Test List

```csharp
Debug.Assert(FloatSort(new Tuple<string, string>[] { Tuple.Create("item1", "12.20"), Tuple.Create("item2", "15.10"), Tuple.Create("item3", "24.5") }).SequenceEqual(new Tuple<string, string>[] { Tuple.Create("item3", "24.5"), Tuple.Create("item2", "15.10"), Tuple.Create("item1", "12.20") }));
```

```csharp
Debug.Assert(FloatSort(new Tuple<string, string>[] { Tuple.Create("item1", "15"), Tuple.Create("item2", "10"), Tuple.Create("item3", "20") }).SequenceEqual(new Tuple<string, string>[] { Tuple.Create("item3", "20"), Tuple.Create("item1", "15"), Tuple.Create("item2", "10") }));
```

```csharp
Debug.Assert(FloatSort(new Tuple<string, string>[] { Tuple.Create("item1", "5"), Tuple.Create("item2", "10"), Tuple.Create("item3", "14") }).SequenceEqual(new Tuple<string, string>[] { Tuple.Create("item3", "14"), Tuple.Create("item2", "10"), Tuple.Create("item1", "5") }));
```
