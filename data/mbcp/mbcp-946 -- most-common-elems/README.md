# mbcp-946 -- Find the most common elements in text and counts

## Text

Write a function to find the most common elements and their counts of a specified text.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class MyClass
{
    public List<KeyValuePair<T, int>> MostCommonElem<T>(IEnumerable<T> s, int a)
    {
        return s.GroupBy(x => x)
                .Select(g => new KeyValuePair<T, int>(g.Key, g.Count()))
                .OrderByDescending(x => x.Value)
                .Take(a)
                .ToList();
    }
}
```

## Test List

```csharp
Debug.Assert(MostCommonElem("lkseropewdssafsdfafkpwe", 3).SequenceEqual(new[] { Tuple.Create('s', 4), Tuple.Create('e', 3), Tuple.Create('f', 3) }));
```

```csharp
Debug.Assert(MostCommonElem("lkseropewdssafsdfafkpwe", 2).SequenceEqual(new List<(char, int)> { ('s', 4), ('e', 3) }));
```

```csharp
Debug.Assert(MostCommonElem("lkseropewdssafsdfafkpwe", 7).SequenceEqual(new List<Tuple<char, int>> { Tuple.Create('s', 4), Tuple.Create('e', 3), Tuple.Create('f', 3), Tuple.Create('k', 2), Tuple.Create('p', 2), Tuple.Create('w', 2), Tuple.Create('d', 2) }));
```
