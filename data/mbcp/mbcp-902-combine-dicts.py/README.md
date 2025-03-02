# mbcp902 -- Combine two dictionaries summing values for common keys

## Text

Write a function to combine two dictionaries by adding values for common keys.

## Code

```csharp
using System.Collections.Generic;

public static IDictionary<TKey, int> AddDict<TKey>(IDictionary<TKey, int> d1, IDictionary<TKey, int> d2)
{
    var addDict = new Dictionary<TKey, int>(d1);
    
    foreach (var kvp in d2)
    {
        if (addDict.ContainsKey(kvp.Key))
        {
            addDict[kvp.Key] += kvp.Value;
        }
        else
        {
            addDict[kvp.Key] = kvp.Value;
        }
    }

    return addDict;
}
```

## Test List

```csharp
Debug.Assert(AddDict(new Dictionary<string, int>{{"a", 100}, {"b", 200}, {"c", 300}}, new Dictionary<string, int>{{"a", 300}, {"b", 200}, {"d", 400}}).SequenceEqual(new Dictionary<string, int>{{"b", 400}, {"d", 400}, {"a", 400}, {"c", 300}}));
```

```csharp
Debug.Assert(AddDict(new Dictionary<string, int> { { "a", 500 }, { "b", 700 }, { "c", 900 } }, new Dictionary<string, int> { { "a", 500 }, { "b", 600 }, { "d", 900 } }).SequenceEqual(new Dictionary<string, int> { { "b", 1300 }, { "d", 900 }, { "a", 1000 }, { "c", 900 } }));
```

```csharp
Debug.Assert(AddDict(new Dictionary<string, int>{{"a", 900}, {"b", 900}, {"d", 900}}, new Dictionary<string, int>{{"a", 900}, {"b", 900}, {"d", 900}}).SequenceEqual(new Dictionary<string, int>{{"b", 1800}, {"d", 1800}, {"a", 1800}}));
```
