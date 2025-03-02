# mbcp709 -- Count unique keys for each tuple value

## Text

Write a function to count unique keys for each value present in the tuple.

## Code

```csharp
using System.Collections.Generic;

public class ExampleClass
{
    public string GetUnique(List<Tuple<string, string>> testList)
    {
        var res = new Dictionary<string, List<string>>();
        foreach (var sub in testList)
        {
            if (!res.ContainsKey(sub.Item2))
            {
                res[sub.Item2] = new List<string>();
            }
            res[sub.Item2].Add(sub.Item1);
        }

        var resDict = new Dictionary<string, int>();
        foreach (var key in res.Keys)
        {
            resDict[key] = new HashSet<string>(res[key]).Count;
        }

        return resDict.ToString();
    }
}
```

## Test List

```csharp
Debug.Assert(GetUnique(new List<ValueTuple<int, int>> { (3, 4), (1, 2), (2, 4), (8, 2), (7, 2), (8, 1), (9, 1), (8, 4), (10, 4) }) == "{4: 4, 2: 3, 1: 2}");
```

```csharp
Debug.Assert(GetUnique(new List<Tuple<int, int>> { new Tuple<int, int>(4, 5), new Tuple<int, int>(2, 3), new Tuple<int, int>(3, 5), new Tuple<int, int>(9, 3), new Tuple<int, int>(8, 3), new Tuple<int, int>(9, 2), new Tuple<int, int>(10, 2), new Tuple<int, int>(9, 5), new Tuple<int, int>(11, 5) }) == "{5: 4, 3: 3, 2: 2}");
```

```csharp
Debug.Assert(GetUnique(new (int, int)[] { (6, 5), (3, 4), (2, 6), (11, 1), (8, 22), (8, 11), (4, 3), (14, 3) }) == "{5: 1, 4: 1, 6: 2, 1: 1, 22: 1, 11: 1, 3: 2}");
```
