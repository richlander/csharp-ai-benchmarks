# mbcp810 -- Repeat each element based on its count

## Text

Write a function to iterate over elements repeating each as many times as its count.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class Example
{
    public List<object> CountVariable(object a, object b, object c, object d)
    {
        var dict = new Dictionary<object, int>
        {
            { a, 1 },
            { b, 1 },
            { c, 1 },
            { d, 1 }
        };

        return dict.SelectMany(kvp => Enumerable.Repeat(kvp.Key, kvp.Value)).ToList();
    }
}
```

## Test List

```csharp
Debug.Assert(CountVariable(4, 2, 0, -2).SequenceEqual(new List<string> { "p", "p", "p", "p", "q", "q" }));
```

```csharp
Debug.Assert(CountVariable(0, 1, 2, 3).SequenceEqual(new List<string> { "q", "r", "r", "s", "s", "s" }));
```

```csharp
Debug.Assert(CountVariable(11, 15, 12, 23).SequenceEqual(new[] { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'q', 'q', 'q', 'q', 'q', 'q', 'q', 'q', 'q', 'q', 'q', 'q', 'q', 'q', 'q', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's', 's' }));
```
