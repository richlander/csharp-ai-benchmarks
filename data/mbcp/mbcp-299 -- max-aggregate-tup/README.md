# mbcp-299 -- Calculate the maximum sum from a list of tuples

## Text

Write a function to calculate the maximum aggregate from the list of tuples.

## Code

```csharp
public KeyValuePair<string, int> MaxAggregate(List<Tuple<string, int>> stdata) {
    var temp = new Dictionary<string, int>();
    foreach (var item in stdata) {
        temp[item.Item1] = temp.GetValueOrDefault(item.Item1, 0) + item.Item2;
    }
    return temp.OrderByDescending(x => x.Value).First();
}
```

## Test List

```csharp
Debug.Assert(MaxAggregate(new (string, int)[] { ("Juan Whelan", 90), ("Sabah Colley", 88), ("Peter Nichols", 7), ("Juan Whelan", 122), ("Sabah Colley", 84) }) == ("Juan Whelan", 212));
```

```csharp
Debug.Assert(MaxAggregate(new[] { ("Juan Whelan", 50), ("Sabah Colley", 48), ("Peter Nichols", 37), ("Juan Whelan", 22), ("Sabah Colley", 14) }) == ("Juan Whelan", 72));
```

```csharp
Debug.Assert(MaxAggregate(new List<Tuple<string, int>> {
    Tuple.Create("Juan Whelan", 10),
    Tuple.Create("Sabah Colley", 20),
    Tuple.Create("Peter Nichols", 30),
    Tuple.Create("Juan Whelan", 40),
    Tuple.Create("Sabah Colley", 50)
}) == Tuple.Create("Sabah Colley", 70));
```
