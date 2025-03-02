# mbcp307 -- Get a colon from a given tuple in a function

## Text

Write a function to get a colon of a tuple.

## Code

```csharp
using System.Collections.Generic;

public List<List<int>> ColonTuplex(List<List<int>> tuplex, int m, int n)
{
    var tuplexColon = new List<List<int>>(tuplex.Count);
    foreach (var innerList in tuplex)
    {
        tuplexColon.Add(new List<int>(innerList));
    }
    tuplexColon[m].Add(n);
    return tuplexColon;
}
```

## Test List

```csharp
Debug.Assert(ColonTuplex(("HELLO", 5, new List<int>(), true), 2, 50).Equals(("HELLO", 5, new List<int> { 50 }, true)));
```

```csharp
Debug.Assert(ColonTuplex(("HELLO", 5, new List<int>(), true), 2, 100).Equals(("HELLO", 5, new List<int> { 100 }, true)));
```

```csharp
Debug.Assert(ColonTuplex(("HELLO", 5, new List<int>(), true), 2, 500).Equals(("HELLO", 5, new List<int> { 500 }, true)));
```
