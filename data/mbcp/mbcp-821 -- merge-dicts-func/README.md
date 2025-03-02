# mbcp-821 -- Merge two dictionaries into one expression

## Text

Write a function to merge two dictionaries into a single expression.

## Code

```csharp
using System.Collections.Generic;

public Dictionary<TKey, TValue> MergeDictionaries<TKey, TValue>(Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2)
{
    var mergedDict = new Dictionary<TKey, TValue>(dict1);
    foreach (var kvp in dict2)
    {
        mergedDict[kvp.Key] = kvp.Value;
    }
    return mergedDict;
}
```

## Test List

```csharp
Debug.Assert(MergeDictionaries(new Dictionary<string, string> { { "R", "Red" }, { "B", "Black" }, { "P", "Pink" } }, new Dictionary<string, string> { { "G", "Green" }, { "W", "White" } }).SequenceEqual(new Dictionary<string, string> { { "B", "Black" }, { "R", "Red" }, { "P", "Pink" }, { "G", "Green" }, { "W", "White" } }));
```

```csharp
Debug.Assert(MergeDictionaries(new Dictionary<string, string> { { "R", "Red" }, { "B", "Black" }, { "P", "Pink" } }, new Dictionary<string, string> { { "O", "Orange" }, { "W", "White" }, { "B", "Black" } }).SequenceEqual(new Dictionary<string, string> { { "O", "Orange" }, { "P", "Pink" }, { "B", "Black" }, { "W", "White" }, { "R", "Red" } }));
```

```csharp
Debug.Assert(MergeDictionaries(new Dictionary<string, string> { { "G", "Green" }, { "W", "White" } }, new Dictionary<string, string> { { "O", "Orange" }, { "W", "White" }, { "B", "Black" } }).SequenceEqual(new Dictionary<string, string> { { "W", "White" }, { "O", "Orange" }, { "G", "Green" }, { "B", "Black" } }));
```
