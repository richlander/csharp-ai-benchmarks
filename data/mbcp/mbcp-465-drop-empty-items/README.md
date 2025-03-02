# mbcp465 -- Remove empty items from a dictionary function

## Text

Write a function to drop empty items from a given dictionary.

## Code

```csharp
public Dictionary<string, object> DropEmpty(Dictionary<string, object> dict1)
{
    dict1 = dict1.Where(pair => pair.Value != null).ToDictionary(pair => pair.Key, pair => pair.Value);
    return dict1;
}
```

## Test List

```csharp
Debug.Assert(DropEmpty(new Dictionary<string, string> { { "c1", "Red" }, { "c2", "Green" }, { "c3", null } }).SequenceEqual(new Dictionary<string, string> { { "c1", "Red" }, { "c2", "Green" } }));
```

```csharp
Debug.Assert(DropEmpty(new Dictionary<string, string> { {"c1", "Red"}, {"c2", null}, {"c3", null} }).SequenceEqual(new Dictionary<string, string> { {"c1", "Red"} }));
```

```csharp
Debug.Assert(DropEmpty(new Dictionary<string, string> { { "c1", null }, { "c2", "Green" }, { "c3", null } }).SequenceEqual(new Dictionary<string, string> { { "c2", "Green" } }));
```
