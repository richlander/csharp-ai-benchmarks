# mbcp417 -- Find common first element in list of tuples

## Text

Write a function to find common first element in given list of tuple.

## Code

```csharp
public List<Tuple> GroupTuples(List<Tuple> input)
{
    Dictionary<object, List<object>> outDict = new Dictionary<object, List<object>>();
    foreach (var elem in input)
    {
        try
        {
            outDict[elem.Item1].AddRange(elem.Item2.ToList());
        }
        catch (KeyNotFoundException)
        {
            outDict[elem.Item1] = new List<object>(elem.ToList());
        }
    }
    return outDict.Values.Select(values => Tuple.Create(values.ToArray())).ToList();
}
```

## Test List

```csharp
Debug.Assert(GroupTuples(new List<Tuple<string, string>> { Tuple.Create("x", "y"), Tuple.Create("x", "z"), Tuple.Create("w", "t") }).SequenceEqual(new List<Tuple<string, string, string>> { Tuple.Create("x", "y", "z"), Tuple.Create("w", "t") }));
```

```csharp
Debug.Assert(GroupTuples(new List<ValueTuple<string, string>> { ("a", "b"), ("a", "c"), ("d", "e") }).SequenceEqual(new List<ValueTuple<string, string>> { ("a", "b", "c"), ("d", "e") }));
```

```csharp
Debug.Assert(GroupTuples(new (string, string)[] { ("f", "g"), ("f", "g"), ("h", "i") }).SequenceEqual(new (string, string, string)[] { ("f", "g", "g"), ("h", "i") }));
```
