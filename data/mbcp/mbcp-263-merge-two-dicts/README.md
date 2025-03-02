# mbcp263 -- Merge two dictionaries into one unified dictionary

## Text

Write a function to merge two dictionaries.

## Code

```csharp
public Dictionary<TKey, TValue> MergeDict<TKey, TValue>(Dictionary<TKey, TValue> d1, Dictionary<TKey, TValue> d2)
{
    var d = new Dictionary<TKey, TValue>(d1);
    foreach (var kvp in d2)
    {
        d[kvp.Key] = kvp.Value;
    }
    return d;
}
```

## Test List

```csharp
Debug.Assert(MergeDict(new Dictionary<string, int>{{"a", 100}, {"b", 200}}, new Dictionary<string, int>{{"x", 300}, {"y", 200}}).SequenceEqual(new Dictionary<string, int>{{"x", 300}, {"y", 200}, {"a", 100}, {"b", 200}}));
```

```csharp
Debug.Assert(MergeDict(new Dictionary<string, int>{{"a", 900}, {"b", 900}, {"d", 900}}, new Dictionary<string, int>{{"a", 900}, {"b", 900}, {"d", 900}}).SequenceEqual(new Dictionary<string, int>{{"a", 900}, {"b", 900}, {"d", 900}, {"a", 900}, {"b", 900}, {"d", 900}}));
```

```csharp
Debug.Assert(MergeDict(new Dictionary<string, int> { { "a", 10 }, { "b", 20 } }, new Dictionary<string, int> { { "x", 30 }, { "y", 40 } }).SequenceEqual(new Dictionary<string, int> { { "x", 30 }, { "y", 40 }, { "a", 10 }, { "b", 20 } }));
```
